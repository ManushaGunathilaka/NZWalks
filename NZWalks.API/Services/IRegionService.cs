using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;

namespace NZWalks.API.Services
{
    public interface IRegionService
    {
        Task<Region> CreateNewRegionAsync(AddRegionRequestDto addRegionRequestDto);
    }
}
