using EasyAuthSamples.Common.Entities;

namespace EasyAuthSamples.UserClaimsSite.Models.Home
{
    public class RequestDetailsModel
    {
        public IDictionary<string, string> Headers { get; set; }

        public IEnumerable<UserClaim> UserClaims { get; set; }
    }
}
