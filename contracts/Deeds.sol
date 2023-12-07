//SPDX-License-Identifier: MIT
import {ERC721} from "@openzeppelin/contracts/token/ERC721/ERC721.sol";
import {Ownable} from "@openzeppelin/contracts/access/Ownable.sol";
pragma solidity ^0.8.20;

contract Deeds is ERC721, Ownable{
    
    uint256 internal _tokenId = 1;

    constructor() Ownable(msg.sender) ERC721("B4Deeds","B4DEED"){}

    function awardToken (address to) public onlyOwner returns (uint256)
    {
        _safeMint(to, _tokenId);
        _tokenId += 1;
        return _tokenId - 1;
    }

    function getLastTokenId() public view returns (uint256)
    {
        return _tokenId - 1;
    }
}