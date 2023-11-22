using System.Security.Principal;

namespace EasyAuthSamples.MultiProviderSite.Models.AuthenticatedFeatures
{
    public class IndexModel
    {
        public IndexModel()
        {

        }
        public IndexModel(IIdentity user)
        {
            this.UserName = user.Name;
            this.IsAuthenticated = user.IsAuthenticated;
        }

        public string UserName { get; set; }
        public bool IsAuthenticated { get; set; }


    }
}
