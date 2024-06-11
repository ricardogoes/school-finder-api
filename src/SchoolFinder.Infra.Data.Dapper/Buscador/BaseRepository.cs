using Npgsql;
using SchoolFinder.Domain.Common.Models.AppSettings;
using System.Data;

namespace SchoolFinder.Infra.Data.Dapper.Buscador
{
    public abstract class BaseRepository
    {
        private readonly AppSettings _appSettings;

        public BaseRepository(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public IDbConnection CreateConnection()
        {
            return new NpgsqlConnection(_appSettings.ConnectionStringsSettings.SchoolFinderDbConnection);
        }
    }
}
