using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Nethereum_Deeds_NFT.Contracts.Deeds.ContractDefinition
{


    public partial class DeedsDeployment : DeedsDeploymentBase
    {
        public DeedsDeployment() : base(BYTECODE) { }
        public DeedsDeployment(string byteCode) : base(byteCode) { }
    }

    public class DeedsDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "6080604052600160075534801562000015575f80fd5b5033604051806040016040528060078152602001664234446565647360c81b81525060405180604001604052806006815260200165108d1111515160d21b815250815f9081620000669190620001a9565b506001620000758282620001a9565b5050506001600160a01b038116620000a657604051631e4fbdf760e01b81525f600482015260240160405180910390fd5b620000b181620000b8565b5062000271565b600680546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e0905f90a35050565b634e487b7160e01b5f52604160045260245ffd5b600181811c908216806200013257607f821691505b6020821081036200015157634e487b7160e01b5f52602260045260245ffd5b50919050565b601f821115620001a4575f81815260208120601f850160051c810160208610156200017f5750805b601f850160051c820191505b81811015620001a0578281556001016200018b565b5050505b505050565b81516001600160401b03811115620001c557620001c562000109565b620001dd81620001d684546200011d565b8462000157565b602080601f83116001811462000213575f8415620001fb5750858301515b5f19600386901b1c1916600185901b178555620001a0565b5f85815260208120601f198616915b82811015620002435788860151825594840194600190910190840162000222565b50858210156200026157878501515f19600388901b60f8161c191681555b5050505050600190811b01905550565b6110ff806200027f5f395ff3fe608060405234801561000f575f80fd5b5060043610610111575f3560e01c806383c4c00d1161009e578063b88d4fde1161006e578063b88d4fde14610228578063c87b56dd1461023b578063dba98e5b1461024e578063e985e9c514610261578063f2fde38b14610274575f80fd5b806383c4c00d146101f45780638da5cb5b146101fc57806395d89b411461020d578063a22cb46514610215575f80fd5b806323b872dd116100e457806323b872dd1461019257806342842e0e146101a55780636352211e146101b857806370a08231146101cb578063715018a6146101ec575f80fd5b806301ffc9a71461011557806306fdde031461013d578063081812fc14610152578063095ea7b31461017d575b5f80fd5b610128610123366004610d5e565b610287565b60405190151581526020015b60405180910390f35b6101456102d8565b6040516101349190610dc6565b610165610160366004610dd8565b610367565b6040516001600160a01b039091168152602001610134565b61019061018b366004610e05565b61038e565b005b6101906101a0366004610e2d565b61039d565b6101906101b3366004610e2d565b61042b565b6101656101c6366004610dd8565b61044a565b6101de6101d9366004610e66565b610454565b604051908152602001610134565b610190610499565b6101de6104ac565b6006546001600160a01b0316610165565b6101456104c1565b610190610223366004610e7f565b6104d0565b610190610236366004610ecc565b6104db565b610145610249366004610dd8565b6104f2565b6101de61025c366004610e66565b610563565b61012861026f366004610fa1565b6105a3565b610190610282366004610e66565b6105d0565b5f6001600160e01b031982166380ac58cd60e01b14806102b757506001600160e01b03198216635b5e139f60e01b145b806102d257506301ffc9a760e01b6001600160e01b03198316145b92915050565b60605f80546102e690610fd2565b80601f016020809104026020016040519081016040528092919081815260200182805461031290610fd2565b801561035d5780601f106103345761010080835404028352916020019161035d565b820191905f5260205f20905b81548152906001019060200180831161034057829003601f168201915b5050505050905090565b5f6103718261060d565b505f828152600460205260409020546001600160a01b03166102d2565b610399828233610645565b5050565b6001600160a01b0382166103cb57604051633250574960e11b81525f60048201526024015b60405180910390fd5b5f6103d7838333610652565b9050836001600160a01b0316816001600160a01b031614610425576040516364283d7b60e01b81526001600160a01b03808616600483015260248201849052821660448201526064016103c2565b50505050565b61044583838360405180602001604052805f8152506104db565b505050565b5f6102d28261060d565b5f6001600160a01b03821661047e576040516322718ad960e21b81525f60048201526024016103c2565b506001600160a01b03165f9081526003602052604090205490565b6104a1610744565b6104aa5f610771565b565b5f60016007546104bc919061101e565b905090565b6060600180546102e690610fd2565b6103993383836107c2565b6104e684848461039d565b61042584848484610860565b60606104fd8261060d565b505f61051360408051602081019091525f815290565b90505f8151116105315760405180602001604052805f81525061055c565b8061053b84610986565b60405160200161054c929190611031565b6040516020818303038152906040525b9392505050565b5f61056c610744565b61057882600754610a16565b600160075f82825461058a919061105f565b90915550506007546102d29060019061101e565b919050565b6001600160a01b039182165f90815260056020908152604080832093909416825291909152205460ff1690565b6105d8610744565b6001600160a01b03811661060157604051631e4fbdf760e01b81525f60048201526024016103c2565b61060a81610771565b50565b5f818152600260205260408120546001600160a01b0316806102d257604051637e27328960e01b8152600481018490526024016103c2565b6104458383836001610a2f565b5f828152600260205260408120546001600160a01b039081169083161561067e5761067e818486610b33565b6001600160a01b038116156106b8576106995f855f80610a2f565b6001600160a01b0381165f90815260036020526040902080545f190190555b6001600160a01b038516156106e6576001600160a01b0385165f908152600360205260409020805460010190555b5f8481526002602052604080822080546001600160a01b0319166001600160a01b0389811691821790925591518793918516917fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef91a4949350505050565b6006546001600160a01b031633146104aa5760405163118cdaa760e01b81523360048201526024016103c2565b600680546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e0905f90a35050565b6001600160a01b0382166107f457604051630b61174360e31b81526001600160a01b03831660048201526024016103c2565b6001600160a01b038381165f81815260056020908152604080832094871680845294825291829020805460ff191686151590811790915591519182527f17307eab39ab6107e8899845ad3d59bd9653f200f220920489ca2b5937696c31910160405180910390a3505050565b6001600160a01b0383163b1561042557604051630a85bd0160e11b81526001600160a01b0384169063150b7a02906108a2903390889087908790600401611072565b6020604051808303815f875af19250505080156108dc575060408051601f3d908101601f191682019092526108d9918101906110ae565b60015b610943573d808015610909576040519150601f19603f3d011682016040523d82523d5f602084013e61090e565b606091505b5080515f0361093b57604051633250574960e11b81526001600160a01b03851660048201526024016103c2565b805181602001fd5b6001600160e01b03198116630a85bd0160e11b1461097f57604051633250574960e11b81526001600160a01b03851660048201526024016103c2565b5050505050565b60605f61099283610b97565b60010190505f8167ffffffffffffffff8111156109b1576109b1610eb8565b6040519080825280601f01601f1916602001820160405280156109db576020820181803683370190505b5090508181016020015b5f19016f181899199a1a9b1b9c1cb0b131b232b360811b600a86061a8153600a85049450846109e557509392505050565b610399828260405180602001604052805f815250610c6e565b8080610a4357506001600160a01b03821615155b15610b04575f610a528461060d565b90506001600160a01b03831615801590610a7e5750826001600160a01b0316816001600160a01b031614155b8015610a915750610a8f81846105a3565b155b15610aba5760405163a9fbf51f60e01b81526001600160a01b03841660048201526024016103c2565b8115610b025783856001600160a01b0316826001600160a01b03167f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b92560405160405180910390a45b505b50505f90815260046020526040902080546001600160a01b0319166001600160a01b0392909216919091179055565b610b3e838383610c84565b610445576001600160a01b038316610b6c57604051637e27328960e01b8152600481018290526024016103c2565b60405163177e802f60e01b81526001600160a01b0383166004820152602481018290526044016103c2565b5f8072184f03e93ff9f4daa797ed6e38ed64bf6a1f0160401b8310610bd55772184f03e93ff9f4daa797ed6e38ed64bf6a1f0160401b830492506040015b6d04ee2d6d415b85acef81000000008310610c01576d04ee2d6d415b85acef8100000000830492506020015b662386f26fc100008310610c1f57662386f26fc10000830492506010015b6305f5e1008310610c37576305f5e100830492506008015b6127108310610c4b57612710830492506004015b60648310610c5d576064830492506002015b600a83106102d25760010192915050565b610c788383610ce8565b6104455f848484610860565b5f6001600160a01b03831615801590610ce05750826001600160a01b0316846001600160a01b03161480610cbd5750610cbd84846105a3565b80610ce057505f828152600460205260409020546001600160a01b038481169116145b949350505050565b6001600160a01b038216610d1157604051633250574960e11b81525f60048201526024016103c2565b5f610d1d83835f610652565b90506001600160a01b03811615610445576040516339e3563760e11b81525f60048201526024016103c2565b6001600160e01b03198116811461060a575f80fd5b5f60208284031215610d6e575f80fd5b813561055c81610d49565b5f5b83811015610d93578181015183820152602001610d7b565b50505f910152565b5f8151808452610db2816020860160208601610d79565b601f01601f19169290920160200192915050565b602081525f61055c6020830184610d9b565b5f60208284031215610de8575f80fd5b5035919050565b80356001600160a01b038116811461059e575f80fd5b5f8060408385031215610e16575f80fd5b610e1f83610def565b946020939093013593505050565b5f805f60608486031215610e3f575f80fd5b610e4884610def565b9250610e5660208501610def565b9150604084013590509250925092565b5f60208284031215610e76575f80fd5b61055c82610def565b5f8060408385031215610e90575f80fd5b610e9983610def565b915060208301358015158114610ead575f80fd5b809150509250929050565b634e487b7160e01b5f52604160045260245ffd5b5f805f8060808587031215610edf575f80fd5b610ee885610def565b9350610ef660208601610def565b925060408501359150606085013567ffffffffffffffff80821115610f19575f80fd5b818701915087601f830112610f2c575f80fd5b813581811115610f3e57610f3e610eb8565b604051601f8201601f19908116603f01168101908382118183101715610f6657610f66610eb8565b816040528281528a6020848701011115610f7e575f80fd5b826020860160208301375f60208483010152809550505050505092959194509250565b5f8060408385031215610fb2575f80fd5b610fbb83610def565b9150610fc960208401610def565b90509250929050565b600181811c90821680610fe657607f821691505b60208210810361100457634e487b7160e01b5f52602260045260245ffd5b50919050565b634e487b7160e01b5f52601160045260245ffd5b818103818111156102d2576102d261100a565b5f8351611042818460208801610d79565b835190830190611056818360208801610d79565b01949350505050565b808201808211156102d2576102d261100a565b6001600160a01b03858116825284166020820152604081018390526080606082018190525f906110a490830184610d9b565b9695505050505050565b5f602082840312156110be575f80fd5b815161055c81610d4956fea2646970667358221220c93ad242b2ba7d10701856d52fb04ed17ee8031ea720a981b8396e609040500164736f6c63430008140033";
        public DeedsDeploymentBase() : base(BYTECODE) { }
        public DeedsDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class AwardTokenFunction : AwardTokenFunctionBase { }

    [Function("awardToken", "uint256")]
    public class AwardTokenFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class GetApprovedFunction : GetApprovedFunctionBase { }

    [Function("getApproved", "address")]
    public class GetApprovedFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class GetLastTokenIdFunction : GetLastTokenIdFunctionBase { }

    [Function("getLastTokenId", "uint256")]
    public class GetLastTokenIdFunctionBase : FunctionMessage
    {

    }

    public partial class IsApprovedForAllFunction : IsApprovedForAllFunctionBase { }

    [Function("isApprovedForAll", "bool")]
    public class IsApprovedForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "operator", 2)]
        public virtual string Operator { get; set; }
    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerOfFunction : OwnerOfFunctionBase { }

    [Function("ownerOf", "address")]
    public class OwnerOfFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class SafeTransferFromFunction : SafeTransferFromFunctionBase { }

    [Function("safeTransferFrom")]
    public class SafeTransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class SafeTransferFrom1Function : SafeTransferFrom1FunctionBase { }

    [Function("safeTransferFrom")]
    public class SafeTransferFrom1FunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("bytes", "data", 4)]
        public virtual byte[] Data { get; set; }
    }

    public partial class SetApprovalForAllFunction : SetApprovalForAllFunctionBase { }

    [Function("setApprovalForAll")]
    public class SetApprovalForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "operator", 1)]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 2)]
        public virtual bool Approved { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class SymbolFunction : SymbolFunctionBase { }

    [Function("symbol", "string")]
    public class SymbolFunctionBase : FunctionMessage
    {

    }

    public partial class TokenURIFunction : TokenURIFunctionBase { }

    [Function("tokenURI", "string")]
    public class TokenURIFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class ApprovalEventDTO : ApprovalEventDTOBase { }

    [Event("Approval")]
    public class ApprovalEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "approved", 2, true )]
        public virtual string Approved { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class ApprovalForAllEventDTO : ApprovalForAllEventDTOBase { }

    [Event("ApprovalForAll")]
    public class ApprovalForAllEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "operator", 2, true )]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 3, false )]
        public virtual bool Approved { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class TransferEventDTO : TransferEventDTOBase { }

    [Event("Transfer")]
    public class TransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class ERC721IncorrectOwnerError : ERC721IncorrectOwnerErrorBase { }

    [Error("ERC721IncorrectOwner")]
    public class ERC721IncorrectOwnerErrorBase : IErrorDTO
    {
        [Parameter("address", "sender", 1)]
        public virtual string Sender { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("address", "owner", 3)]
        public virtual string Owner { get; set; }
    }

    public partial class ERC721InsufficientApprovalError : ERC721InsufficientApprovalErrorBase { }

    [Error("ERC721InsufficientApproval")]
    public class ERC721InsufficientApprovalErrorBase : IErrorDTO
    {
        [Parameter("address", "operator", 1)]
        public virtual string Operator { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class ERC721InvalidApproverError : ERC721InvalidApproverErrorBase { }

    [Error("ERC721InvalidApprover")]
    public class ERC721InvalidApproverErrorBase : IErrorDTO
    {
        [Parameter("address", "approver", 1)]
        public virtual string Approver { get; set; }
    }

    public partial class ERC721InvalidOperatorError : ERC721InvalidOperatorErrorBase { }

    [Error("ERC721InvalidOperator")]
    public class ERC721InvalidOperatorErrorBase : IErrorDTO
    {
        [Parameter("address", "operator", 1)]
        public virtual string Operator { get; set; }
    }

    public partial class ERC721InvalidOwnerError : ERC721InvalidOwnerErrorBase { }

    [Error("ERC721InvalidOwner")]
    public class ERC721InvalidOwnerErrorBase : IErrorDTO
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class ERC721InvalidReceiverError : ERC721InvalidReceiverErrorBase { }

    [Error("ERC721InvalidReceiver")]
    public class ERC721InvalidReceiverErrorBase : IErrorDTO
    {
        [Parameter("address", "receiver", 1)]
        public virtual string Receiver { get; set; }
    }

    public partial class ERC721InvalidSenderError : ERC721InvalidSenderErrorBase { }

    [Error("ERC721InvalidSender")]
    public class ERC721InvalidSenderErrorBase : IErrorDTO
    {
        [Parameter("address", "sender", 1)]
        public virtual string Sender { get; set; }
    }

    public partial class ERC721NonexistentTokenError : ERC721NonexistentTokenErrorBase { }

    [Error("ERC721NonexistentToken")]
    public class ERC721NonexistentTokenErrorBase : IErrorDTO
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class OwnableInvalidOwnerError : OwnableInvalidOwnerErrorBase { }

    [Error("OwnableInvalidOwner")]
    public class OwnableInvalidOwnerErrorBase : IErrorDTO
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class OwnableUnauthorizedAccountError : OwnableUnauthorizedAccountErrorBase { }

    [Error("OwnableUnauthorizedAccount")]
    public class OwnableUnauthorizedAccountErrorBase : IErrorDTO
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }





    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetApprovedOutputDTO : GetApprovedOutputDTOBase { }

    [FunctionOutput]
    public class GetApprovedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetLastTokenIdOutputDTO : GetLastTokenIdOutputDTOBase { }

    [FunctionOutput]
    public class GetLastTokenIdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class IsApprovedForAllOutputDTO : IsApprovedForAllOutputDTOBase { }

    [FunctionOutput]
    public class IsApprovedForAllOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerOfOutputDTO : OwnerOfOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }









    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

    [FunctionOutput]
    public class SymbolOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TokenURIOutputDTO : TokenURIOutputDTOBase { }

    [FunctionOutput]
    public class TokenURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }




}
