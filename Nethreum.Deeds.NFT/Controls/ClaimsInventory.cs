using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace Nethreum.Deeds.NFT.Controls
{
    public class ClaimsInventory : IInventory<Tuple<ulong, string, string>>
    {
        List<Tuple<ulong, string, string>> IInventory<Tuple<ulong, string, string>>.Inventory() {
            var file = File.ReadAllLines("Documents.json").ToString();
            var documents = JsonConvert.DeserializeObject<List<Document>>(file);
            
            

            return null;
            }

        private string sha512Hash(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            SHA512 shaM = new SHA512Managed();
            return Encoding.UTF8.GetString(shaM.ComputeHash(bytes));
        }
    }
}
