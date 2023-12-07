using Nethereum.Web3;
using Nethereum_Deeds_NFT.Contracts.Deeds;

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

app.MapGet("/", async () => (await serviceDeeds.GetLastTokenIdQueryAsync()).ToString());

app.Run();
