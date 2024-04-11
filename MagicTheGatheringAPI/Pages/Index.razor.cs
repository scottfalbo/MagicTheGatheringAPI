// ------------------------------------
// Magic The Gathering Look Up UI
// ------------------------------------

using Microsoft.AspNetCore.Components;

namespace MagicTheGatheringAPI.Pages;

#nullable disable

public partial class Index : ComponentBase
{
    [Inject]
    private IProcessor _processor { get; set; }
}

#nullable enable