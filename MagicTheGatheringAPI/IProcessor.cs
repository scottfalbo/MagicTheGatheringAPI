// ------------------------------------
// Magic The Gathering Look Up UI
// ------------------------------------

using MagicTheGatheringAPI.Models;

namespace MagicTheGatheringAPI;

public interface IProcessor
{
    Task<List<SetDto>> GetAllSets();
}