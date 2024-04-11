// ------------------------------------
// Magic The Gathering Look Up UI
// ------------------------------------

using MagicTheGatheringAPI.Models;
using MtgApiManager.Lib.Service;

namespace MagicTheGatheringAPI;

public class Processor : IProcessor
{
    private readonly ICardService _cardService;
    private readonly ISetService _setService;

    public Processor(ICardService cardService, ISetService setService)
    {
        _cardService = cardService;
        _setService = setService;
    }

    public async Task<List<SetDto>> GetAllSets()
    {
        var response = await _setService.AllAsync();

        var sets = response.Value
            .Where(x => x.OnlineOnly == false
                && !string.IsNullOrWhiteSpace(x.Block)
                && x.Type != "promo")
            .Select(x => new SetDto(x))
            .OrderBy(x => x.ReleaseDate)
            .ToList();

        return sets;
    }
}