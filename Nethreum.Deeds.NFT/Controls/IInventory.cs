namespace Nethreum.Deeds.NFT.Controls
{
    public interface IInventory <T>
    {
        public List<T> Inventory();
    }

    public record doc(string Document);
}
