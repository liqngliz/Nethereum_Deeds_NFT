const { inputToConfig } = require('@ethereum-waffle/compiler');
const{expect} = require('chai');
const { ethers } = require('hardhat');


describe('Deeds contract', ()=>{
    let Token, token, owner, addr1, addr2;

    beforeEach(async ()=>{
        Token = await ethers.getContractFactory('Deeds');
        token = await Token.deploy();
        [owner, addr1, addr2, _] = await ethers.getSigners();
    });

    describe('Deployment', ()=>{
        it('Should set the right owner', async ()=>{
            await console.log("owner is " + await token.owner());
            expect(await token.owner()).to.equal(owner.address);
        });
    });

    describe('Mint', ()=>{
        it('Should mint', async ()=>{
            console.log("to address " + addr2.address);
            console.log( "minted token " + (await token.connect(owner).awardToken(addr2.address)).value.toString());
            expect(await token.ownerOf(1)).to.equal(addr2.address);
            expect(await token.getLastTokenId()).to.equal(1);

        });

        it('Should only allow deployer to mint', async ()=>{
            let mintFail = async () => {return await token.connect(addr2).awardToken(addr2.address)};
            let errorMsg = "";
            try 
            {
                await mintFail();
            }
            catch(error)
            {
                errorMsg = error.toString();
            }
            expect(errorMsg).to.equal('Error: VM Exception while processing transaction: reverted with custom error \'OwnableUnauthorizedAccount("0x3C44CdDdB6a900fa2b585dd299e03d12FA4293BC")\'');
            expect(await token.getLastTokenId()).to.equal(0);
        });
    });

});