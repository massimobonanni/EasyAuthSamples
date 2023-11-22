using EasyAuthSamples.Common.Entities;

namespace EasyAuthSamples.MultiProviderSite.Models.Home
{
    public class RequestDetailsModel
    {
        public IDictionary<string, string> Headers { get; set; }

        public IEnumerable<UserClaim> UserClaims { get; set; }
    }
}
