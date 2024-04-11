// ------------------------------------
// Magic The Gathering Look Up UI
// ------------------------------------

namespace MagicTheGatheringAPI;

public interface IProcessor
{
    Task<List<string>> GetAllSets();
}