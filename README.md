#### BlockCypher Web Api
The BlockCypher Web api is implemented with Clean Architecture approach.

#### Some NuGet Packages on this solution:

1. Entity Framework Core
2. MediatR
3. FluentValidation
4. AutoMapper
5. Newtonsoft.Json
6. Swashbuckle (Swagger)

#### Instructions:

1. Clone the repository
2. Set as StartUp project the BlockCypher.API in the solution.
3. Start the solution
4. With the swagger run several times the endpoint /api/Blockchain/createInfoRecord to store on In-memory database some records for the blockchain info.
5. Execute the other endpoints to show the latest information for the available blockchains (eth, dash, btc) and also the history of each blochchain's info for the same blockchains.
