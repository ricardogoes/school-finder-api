namespace SchoolFinder.Domain.Common.Models.AppSettings
{
    public class ConnectionStringsSettings
    {
        public string SchoolFinderDbConnection { get; private set; }

        public ConnectionStringsSettings(string dbConnection)
        {
            SchoolFinderDbConnection = dbConnection;
        }
    }
}
