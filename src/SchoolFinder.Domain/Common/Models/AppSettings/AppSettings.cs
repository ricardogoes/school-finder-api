namespace SchoolFinder.Domain.Common.Models.AppSettings
{
    public class AppSettings
    {
        public ConnectionStringsSettings ConnectionStringsSettings { get; private set; }

        public AppSettings(ConnectionStringsSettings connectionStringsSettings)
        {
            ConnectionStringsSettings = connectionStringsSettings;
        }
    }
}
