// ------------------------------------
// Magic The Gathering Look Up UI
// ------------------------------------

using Microsoft.Azure.Cosmos;

namespace MagicTheGatheringAPI;

public interface IStorageClient
{
    CosmosClient CreateClient();
}