using Nethereum.Web3;
using Nethereum_Deeds_NFT.Contracts.Claims;
using Nethereum_Deeds_NFT.Contracts.Deeds;
using Nethreum.Deeds.NFT.Controls;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);


var services = builder.Services;
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();

var url = "http://127.0.0.1:8545/";
var web3 = new Web3(url);
// An already-deployed SimpleStorage.sol contract on Rinkeby:
var contractAddressDeeds = "0x5FbDB2315678afecb367f032d93F642f64180aa3";
var serviceDeeds = new DeedsService(web3, contractAddressDeeds);

var contractAddressClaims = "0xe7f1725E7734CE288F8367e1Bb143E90bb3F0512";
var serviceClaims = new ClaimsService(web3, contractAddressClaims);
var inventory = new DeedsInventory(serviceDeeds, serviceClaims);

app.MapGet("/", () => JsonConvert.SerializeObject(inventory.Inventory()));

app.Run();
