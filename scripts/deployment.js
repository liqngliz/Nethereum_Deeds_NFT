const sample = require('../Nethreum.Deeds.NFT/Documents.json');
const sha512 = require('js-sha512');
const fs = require('fs');
const { ethers } = require('hardhat');


async function main(){
    Token = await ethers.getContractFactory('Deeds');
    token = await Token.deploy();

    Token2 = await ethers.getContractFactory('Claims');
    token2 = await Token2.deploy(token.address);

    [deployer] = await ethers.getSigners();

    const data ={
        address: token.address,
        abi: JSON.parse(token.interface.format('json'))
    };

    fs.writeFileSync('abi/Deeds.json', JSON.stringify(data));

    const data2 ={
        address: token2.address,
        abi: JSON.parse(token2.interface.format('json'))
    };

    fs.writeFileSync('abi/Claims.json', JSON.stringify(data2));
    
    console.log(`deploying with account: ${deployer.address}`);
    console.log(`account balance: ${(await deployer.getBalance()).toString()}`);

    //deploy sample NFTs with claims
    for(var i = 0; i < sample.length; i++)
    {
        let doc = sample[i].document;
        console.log(doc);
        console.log(sha512(doc));
        await token.awardToken(deployer.address);
        let tokenId = (await token.getLastTokenId()).toNumber();
        console.log(tokenId);
        await token2.setClaim(tokenId, sha512(doc));
        console.log("Claim is " + await token2.getClaim(tokenId));
        console.log("Owner is " + await token.ownerOf(tokenId));
    }

    console.log("deeds deployed to " + await token.address);
    console.log("claims deployed to " + await token2.address);
}

main()
    .then(()=> process.exit(0))
    .catch(error => {
        console.log(error);
        process.exit(1);
    });