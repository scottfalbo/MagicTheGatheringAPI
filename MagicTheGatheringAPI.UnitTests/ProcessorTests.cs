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
        var service = serviceProvider.GetCardService();

        _processor = new Processor(service);
    }

    [TestMethod]
    public async Task GetAllSets_ReturnSetList()
    {
        var response = await _processor.GetAllSets();
    }
}