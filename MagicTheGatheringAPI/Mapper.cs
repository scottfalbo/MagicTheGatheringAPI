// ------------------------------------
// Magic The Gathering Look Up UI
// ------------------------------------

using MagicTheGatheringAPI.Models;
using MagicTheGatheringAPI.StorageContracts;
using Riok.Mapperly.Abstractions;

namespace MagicTheGatheringAPI;

[Mapper]
public partial class Mapper
{
    public partial SetDto ToSetDto(SetStorageContract setStorageContract);

    [MapperIgnoreSource(nameof(setDto.PartitionKey))]
    public partial SetStorageContract ToSetStorageContract(SetDto setDto);
}