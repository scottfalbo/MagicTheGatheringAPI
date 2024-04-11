// ------------------------------------
// Magic The Gathering Look Up UI
// ------------------------------------

using Microsoft.Azure.Cosmos;

namespace MagicTheGatheringAPI;

public class StorageClient : IStorageClient
{
    private readonly CosmosClient _cosmosClient;

    public StorageClient(CosmosClient cosmosClient)
    {
        _cosmosClient = cosmosClient;
    }

    public CosmosClient CreateClient() => _cosmosClient;
}