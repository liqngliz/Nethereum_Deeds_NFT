using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using Nethereum_Deeds_NFT.Contracts.Claims.ContractDefinition;

namespace Nethereum_Deeds_NFT.Contracts.Claims
{
    public partial class ClaimsService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, ClaimsDeployment claimsDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<ClaimsDeployment>().SendRequestAndWaitForReceiptAsync(claimsDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, ClaimsDeployment claimsDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<ClaimsDeployment>().SendRequestAsync(claimsDeployment);
        }

        public static async Task<ClaimsService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, ClaimsDeployment claimsDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, claimsDeployment, cancellationTokenSource);
            return new ClaimsService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.IWeb3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public ClaimsService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public ClaimsService(Nethereum.Web3.IWeb3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> GetClaimQueryAsync(GetClaimFunction getClaimFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetClaimFunction, string>(getClaimFunction, blockParameter);
        }

        
        public Task<string> GetClaimQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getClaimFunction = new GetClaimFunction();
                getClaimFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<GetClaimFunction, string>(getClaimFunction, blockParameter);
        }

        public Task<string> GetIssuerQueryAsync(GetIssuerFunction getIssuerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetIssuerFunction, string>(getIssuerFunction, blockParameter);
        }

        
        public Task<string> GetIssuerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetIssuerFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> GetLastTokenIdQueryAsync(GetLastTokenIdFunction getLastTokenIdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetLastTokenIdFunction, BigInteger>(getLastTokenIdFunction, blockParameter);
        }

        
        public Task<BigInteger> GetLastTokenIdQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetLastTokenIdFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(renounceOwnershipFunction);
        }

        public Task<string> RenounceOwnershipRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>(null, cancellationToken);
        }

        public Task<string> SetClaimRequestAsync(SetClaimFunction setClaimFunction)
        {
             return ContractHandler.SendRequestAsync(setClaimFunction);
        }

        public Task<TransactionReceipt> SetClaimRequestAndWaitForReceiptAsync(SetClaimFunction setClaimFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setClaimFunction, cancellationToken);
        }

        public Task<string> SetClaimRequestAsync(BigInteger tokenId, string claimsHash)
        {
            var setClaimFunction = new SetClaimFunction();
                setClaimFunction.TokenId = tokenId;
                setClaimFunction.ClaimsHash = claimsHash;
            
             return ContractHandler.SendRequestAsync(setClaimFunction);
        }

        public Task<TransactionReceipt> SetClaimRequestAndWaitForReceiptAsync(BigInteger tokenId, string claimsHash, CancellationTokenSource cancellationToken = null)
        {
            var setClaimFunction = new SetClaimFunction();
                setClaimFunction.TokenId = tokenId;
                setClaimFunction.ClaimsHash = claimsHash;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setClaimFunction, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(string newOwner)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }
    }
}
