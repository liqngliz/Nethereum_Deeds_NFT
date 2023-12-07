//SPDX-License-Identifier: MIT

import {Ownable} from "@openzeppelin/contracts/access/Ownable.sol";
import {Deeds} from "./Deeds.sol";
pragma solidity ^0.8.20;

contract Claims is Ownable {
    mapping(uint256 tokenId => string claimJSON) _claims;
    Deeds internal _deedsIssuer;
    address internal _issuerAddress;

    constructor(address issuer) Ownable(msg.sender)
    {
        _deedsIssuer = Deeds(issuer);
        _issuerAddress = issuer;
    }

    function setClaim(uint256 tokenId, string calldata claimsHash) public onlyOwner
    {   
        require(_deedsIssuer.getLastTokenId() >= tokenId, "Token does not exist");
        require(bytes(_claims[tokenId]).length == 0, "Claims already exist on this token");
        _claims[tokenId] = claimsHash;
    }

    function getClaim(uint tokenId) public view returns (string memory)
    {   
        require(_deedsIssuer.getLastTokenId() >= tokenId, "Token does not exist");
        require(bytes(_claims[tokenId]).length != 0, "Claims not set yet");
        return _claims[tokenId];
    }

    function getIssuer() public view returns (address)
    {
        return _issuerAddress;
    }

    function getLastTokenId() public view returns(uint256)
    {
        return _deedsIssuer.getLastTokenId();
    }
}


