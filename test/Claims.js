const { inputToConfig } = require('@ethereum-waffle/compiler');
const{expect} = require('chai');
const { ethers } = require('hardhat');


describe('Deedsnp contract', ()=>{
    let Token, token, owner, addr1, addr2;
    let Token2, token2;

    beforeEach(async ()=>{
        Token = await ethers.getContractFactory('Deeds');
        token = await Token.deploy();

        Token2 = await ethers.getContractFactory('Claims');
        token2 = await Token2.deploy(token.address);

        [owner, addr1, addr2, _] = await ethers.getSigners();
    });

    describe('Deployment and bind to correct issuer', ()=>{
        it('Should set the right owner', async ()=>{

            console.log("owner of deeds  is " + await token.owner());
            expect(await token.owner()).to.equal(owner.address);

            console.log("owner of claims is" + await token2.owner());
            expect(await token2.owner()).to.equal(owner.address);

            console.log("Deeds was deployed to " + await token.address);
            console.log("Claims is deployed to " + await token2.address);
            console.log("Claims is bound to " + await token2.getIssuer());
            expect(await token2.getIssuer()).to.equal(await token.address);

        });
    });

    describe('Mint and set claim tests', ()=>{
        it('Should mint and set claim', async ()=>{
            console.log("to address " + addr2.address);
            console.log( "minted token " + (await token.connect(owner).awardToken(addr2.address)).value.toString());
            expect(await token.ownerOf(1)).to.equal(addr2.address);
            expect(await token.getLastTokenId()).to.equal(1);

            let claimJSON = {type:"fin_asset",documentHash:"AWGSRGRHAGSRGRAF"};
            await token2.setClaim(1, JSON.stringify(claimJSON));

            console.log("Claim is " + await token2.getClaim(1));
            expect(await token2.getClaim(1)).to.equal(JSON.stringify(claimJSON));
        });

        it('Should not set claim', async ()=>{
            console.log("to address " + addr2.address);
            console.log( "minted token " + (await token.connect(owner).awardToken(addr2.address)).value.toString());
            expect(await token.ownerOf(1)).to.equal(addr2.address);
            expect(await token.getLastTokenId()).to.equal(1);

            let claimJSON = {type:"fin_asset",documentHash:"AWGSRGRHAGSRGRAF"};
            await token2.setClaim(1, JSON.stringify(claimJSON));

            console.log("Claim is " + await token2.getClaim(1));
            expect(await token2.getClaim(1)).to.equal(JSON.stringify(claimJSON));

            let errorString = "";
            try
            {   
                expect(await token.getLastTokenId()).to.equal(await token2.getLastTokenId());
                await token2.setClaim(2, JSON.stringify(claimJSON));
                console.log("Claim 2 is " + await token2.getClaim(2));
            }
            catch(error)
            {   
                errorString = error.toString();
                console.log(errorString);
            }
            expect(errorString).to.equal('Error: VM Exception while processing transaction: reverted with reason string \'Token does not exist\'');

        });

        
    });

});