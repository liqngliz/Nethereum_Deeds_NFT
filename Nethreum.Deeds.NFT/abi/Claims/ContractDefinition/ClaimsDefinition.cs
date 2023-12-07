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

namespace Nethereum_Deeds_NFT.Contracts.Claims.ContractDefinition
{


    public partial class ClaimsDeployment : ClaimsDeploymentBase
    {
        public ClaimsDeployment() : base(BYTECODE) { }
        public ClaimsDeployment(string byteCode) : base(byteCode) { }
    }

    public class ClaimsDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801561000f575f80fd5b5060405161091638038061091683398101604081905261002e916100db565b338061005357604051631e4fbdf760e01b81525f600482015260240160405180910390fd5b61005c8161008c565b50600280546001600160a01b039092166001600160a01b0319928316811790915560038054909216179055610108565b5f80546001600160a01b038381166001600160a01b0319831681178455604051919092169283917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e09190a35050565b5f602082840312156100eb575f80fd5b81516001600160a01b0381168114610101575f80fd5b9392505050565b610801806101155f395ff3fe608060405234801561000f575f80fd5b506004361061007a575f3560e01c8063715018a611610058578063715018a6146100dd57806383c4c00d146100e55780638da5cb5b146100fb578063f2fde38b1461010b575f80fd5b80634bd9c1291461007e57806352556421146100935780635aef2447146100bd575b5f80fd5b61009161008c36600461055a565b61011e565b005b6003546001600160a01b03165b6040516001600160a01b0390911681526020015b60405180910390f35b6100d06100cb3660046105cf565b61026b565b6040516100b491906105e6565b61009161041f565b6100ed610432565b6040519081526020016100b4565b5f546001600160a01b03166100a0565b610091610119366004610631565b6104a2565b6101266104df565b600254604080516383c4c00d60e01b8152905185926001600160a01b0316916383c4c00d9160048083019260209291908290030181865afa15801561016d573d5f803e3d5ffd5b505050506040513d601f19601f82011682018060405250810190610191919061065e565b10156101db5760405162461bcd60e51b8152602060048201526014602482015273151bdad95b88191bd95cc81b9bdd08195e1a5cdd60621b60448201526064015b60405180910390fd5b5f83815260016020526040902080546101f390610675565b15905061024d5760405162461bcd60e51b815260206004820152602260248201527f436c61696d7320616c7265616479206578697374206f6e207468697320746f6b60448201526132b760f11b60648201526084016101d2565b5f83815260016020526040902061026582848361070f565b50505050565b60608160025f9054906101000a90046001600160a01b03166001600160a01b03166383c4c00d6040518163ffffffff1660e01b8152600401602060405180830381865afa1580156102be573d5f803e3d5ffd5b505050506040513d601f19601f820116820180604052508101906102e2919061065e565b10156103275760405162461bcd60e51b8152602060048201526014602482015273151bdad95b88191bd95cc81b9bdd08195e1a5cdd60621b60448201526064016101d2565b5f828152600160205260409020805461033f90610675565b90505f036103845760405162461bcd60e51b815260206004820152601260248201527110db185a5b5cc81b9bdd081cd95d081e595d60721b60448201526064016101d2565b5f828152600160205260409020805461039c90610675565b80601f01602080910402602001604051908101604052809291908181526020018280546103c890610675565b80156104135780601f106103ea57610100808354040283529160200191610413565b820191905f5260205f20905b8154815290600101906020018083116103f657829003601f168201915b50505050509050919050565b6104276104df565b6104305f61050b565b565b600254604080516383c4c00d60e01b815290515f926001600160a01b0316916383c4c00d9160048083019260209291908290030181865afa158015610479573d5f803e3d5ffd5b505050506040513d601f19601f8201168201806040525081019061049d919061065e565b905090565b6104aa6104df565b6001600160a01b0381166104d357604051631e4fbdf760e01b81525f60048201526024016101d2565b6104dc8161050b565b50565b5f546001600160a01b031633146104305760405163118cdaa760e01b81523360048201526024016101d2565b5f80546001600160a01b038381166001600160a01b0319831681178455604051919092169283917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e09190a35050565b5f805f6040848603121561056c575f80fd5b83359250602084013567ffffffffffffffff8082111561058a575f80fd5b818601915086601f83011261059d575f80fd5b8135818111156105ab575f80fd5b8760208285010111156105bc575f80fd5b6020830194508093505050509250925092565b5f602082840312156105df575f80fd5b5035919050565b5f6020808352835180828501525f5b81811015610611578581018301518582016040015282016105f5565b505f604082860101526040601f19601f8301168501019250505092915050565b5f60208284031215610641575f80fd5b81356001600160a01b0381168114610657575f80fd5b9392505050565b5f6020828403121561066e575f80fd5b5051919050565b600181811c9082168061068957607f821691505b6020821081036106a757634e487b7160e01b5f52602260045260245ffd5b50919050565b634e487b7160e01b5f52604160045260245ffd5b601f82111561070a575f81815260208120601f850160051c810160208610156106e75750805b601f850160051c820191505b81811015610706578281556001016106f3565b5050505b505050565b67ffffffffffffffff831115610727576107276106ad565b61073b836107358354610675565b836106c1565b5f601f84116001811461076c575f85156107555750838201355b5f19600387901b1c1916600186901b1783556107c4565b5f83815260209020601f19861690835b8281101561079c578685013582556020948501946001909201910161077c565b50868210156107b8575f1960f88860031b161c19848701351681555b505060018560011b0183555b505050505056fea26469706673582212206b871652f0dcccab4920d5ca1f5b440026985cc5f0fcc1e65fcf924a42439f8f64736f6c63430008140033";
        public ClaimsDeploymentBase() : base(BYTECODE) { }
        public ClaimsDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "issuer", 1)]
        public virtual string Issuer { get; set; }
    }

    public partial class GetClaimFunction : GetClaimFunctionBase { }

    [Function("getClaim", "string")]
    public class GetClaimFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class GetIssuerFunction : GetIssuerFunctionBase { }

    [Function("getIssuer", "address")]
    public class GetIssuerFunctionBase : FunctionMessage
    {

    }

    public partial class GetLastTokenIdFunction : GetLastTokenIdFunctionBase { }

    [Function("getLastTokenId", "uint256")]
    public class GetLastTokenIdFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class SetClaimFunction : SetClaimFunctionBase { }

    [Function("setClaim")]
    public class SetClaimFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("string", "claimsHash", 2)]
        public virtual string ClaimsHash { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
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

    public partial class GetClaimOutputDTO : GetClaimOutputDTOBase { }

    [FunctionOutput]
    public class GetClaimOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetIssuerOutputDTO : GetIssuerOutputDTOBase { }

    [FunctionOutput]
    public class GetIssuerOutputDTOBase : IFunctionOutputDTO 
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

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }






}
