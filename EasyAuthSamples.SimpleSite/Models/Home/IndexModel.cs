namespace EasyAuthSamples.SimpleSite.Models.Home
{
    public class IndexModel
    {
        public string UserName { get; set; }
        public bool IsAuthenticated
        {
            get => !string.IsNullOrWhiteSpace(UserName);
        }
    }
}
