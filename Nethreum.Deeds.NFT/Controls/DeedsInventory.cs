namespace Nethreum.Deeds.NFT.Controls
{
    public class DeedsInventory : IInventory<Tuple<ulong, string>>
    {
        List<Tuple<ulong, string>> IInventory<Tuple<ulong, string>>.Inventory()
        {
            throw new NotImplementedException();
        }
    }
}
