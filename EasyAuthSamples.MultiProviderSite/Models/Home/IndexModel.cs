using System.Security.Principal;

namespace EasyAuthSamples.MultiProviderSite.Models.Home
{
    public class IndexModel
    {
        public IndexModel()
        {

        }
        public IndexModel(IIdentity user)
        {
            UserName = user.Name;
            IsAuthenticated = user.IsAuthenticated;
        }

        public string UserName { get; set; }
        public bool IsAuthenticated { get; set; }

    }
}
