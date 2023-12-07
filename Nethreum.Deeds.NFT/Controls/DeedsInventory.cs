using Nethereum_Deeds_NFT.Contracts.Claims;
using Nethereum_Deeds_NFT.Contracts.Deeds;
using System.Numerics;

namespace Nethreum.Deeds.NFT.Controls
{
    public class DeedsInventory : IInventory<Deed>
    {   
        readonly DeedsService _serviceDeeds;
        readonly ClaimsService _serviceClaims;

        public DeedsInventory(DeedsService deedsService, ClaimsService claimsService) 
        { 
            _serviceDeeds = deedsService;
            _serviceClaims = claimsService;
        }

        public List<Deed> Inventory()
        {
            var maxTokenNumber = (ulong)_serviceDeeds.GetLastTokenIdQueryAsync().Result;
            var result = new List<Deed>();
            for (ulong i = 1; i <= maxTokenNumber; i++) 
            {
                BigInteger iAsBigInt = i;
                var hash = _serviceClaims.GetClaimQueryAsync(iAsBigInt).Result;
                Deed tuple = new(i, hash);
                result.Add(tuple);
            }

            return result;
        }
    }

    public record Deed(ulong TokenId, string DocumentHash);
}
