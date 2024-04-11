// ------------------------------------
// Magic The Gathering Look Up UI
// ------------------------------------

using MtgApiManager.Lib.Service;

namespace MagicTheGatheringAPI;

public class Processor : IProcessor
{
    private readonly ICardService _cardService;

    public Processor(ICardService cardService)
    {
        _cardService = cardService;
    }

    public async Task<List<string>> GetAllSets()
    {
        var response = await _cardService.AllAsync();
        Console.WriteLine(response);

        return new List<string>();
    }
}