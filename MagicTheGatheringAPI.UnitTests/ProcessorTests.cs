// ------------------------------------
// Magic The Gathering Look Up UI
// ------------------------------------

using MtgApiManager.Lib.Service;

namespace MagicTheGatheringAPI.UnitTests;

[TestClass]
public class ProcessorTests
{
    private readonly IProcessor _processor;

    public ProcessorTests()
    {
        var serviceProvider = new MtgServiceProvider();

        var cardService = serviceProvider.GetCardService();
        var setService = serviceProvider.GetSetService();

        _processor = new Processor(cardService, setService);
    }

    [TestMethod]
    public async Task GetAllSets_ReturnSetList()
    {
        var response = await _processor.GetAllSets();

        Assert.IsNotNull(response);
    }
}