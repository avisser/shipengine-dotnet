using ShipEngine.Models.Package.Dto;
using ShipEngine.Models.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShipEngine.Models;
namespace ShipEngine.Extensions
{
    public static class PackageExtensions
    {
        public async static Task<Information> TrackPackage(this ShipEngine shipEngine, string carrierCode, string trackingNumber)
        {
            var trackPackageParams = new TrackPackageParams
            {
                CarrierCode = carrierCode,
                TrackingNumber = trackingNumber,
            };

            var response = await shipEngine.Package.Track(trackPackageParams);
            return response.UnwrapResultOrThrow().Information;
        }


        public async static Task<Information> TrackPackage(this ShipEngine shipEngine, string packageId)
        {
            var trackPackageParams = new TrackPackageParams
            {
                PackageId = packageId,
            };

            var response = await shipEngine.Package.Track(trackPackageParams);
            return response.UnwrapResultOrThrow().Information;
        }
    };
};