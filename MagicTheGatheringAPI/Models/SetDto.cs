// ------------------------------------
// Magic The Gathering Look Up UI
// ------------------------------------

using MtgApiManager.Lib.Model;

namespace MagicTheGatheringAPI.Models;

public record SetDto
{
    public string Block { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public bool? OnlineOnly { get; set; }

    public string ReleaseDate { get; set; }

    public string Type { get; set; }

    public SetDto(ISet set)
    {
        Block = set.Block;
        Code = set.Code;
        Name = set.Name;
        OnlineOnly = set.OnlineOnly;
        ReleaseDate = set.ReleaseDate;
        Type = set.Type;
    }
}