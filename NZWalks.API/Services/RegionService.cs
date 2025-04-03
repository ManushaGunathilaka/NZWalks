//using Microsoft.EntityFrameworkCore;
//using NZWalks.API.Data;
//using NZWalks.API.Models.Domain;
//using NZWalks.API.Models.DTO;

//namespace NZWalks.API.Services
//{
//    public class RegionService : IRegionService
//    {
//        private readonly NZWalksDbContext _dbContext;

//        public RegionService(NZWalksDbContext nZWalksDbContext)
//        {
//            _dbContext = nZWalksDbContext;
//        }
//        public Task<Region> CreateNewRegion(AddRegionRequestDto addRegionRequestDto)
//        {
//            //Map or Convert DTO to Domain Model
//            var regionsDomainModel = new Region
//            {
//                Code = addRegionRequestDto.Code,
//                Name = addRegionRequestDto.Name,
//                RegionImageUrl = addRegionRequestDto.RegionImageUrl
//            };

//            //Use Domain Model to Create Region
//            _dbContext.regions.Add(regionsDomainModel);
//            _dbContext.SaveChanges();

//            //Map Domain Model Back to DTO
//            var regionDto = new RegionDto
//            {
//                Id = regionsDomainModel.Id,
//                Code = regionsDomainModel.Code,
//                Name = regionsDomainModel.Name,
//                RegionImageUrl = regionsDomainModel.RegionImageUrl
//            };
//        }
//    }
//}
