using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

namespace SchoolFinder.Infra.Data.Dapper.Common.Ordenacao
{
    public class OrdenadorHelper
    {
        public static IEnumerable<T>? AplicarOrdenacao<T>(IEnumerable<T> data, string orderByQueryString) where T : class
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return data;

            if (data is null || !data.Any())
                return data;

            var orderParams = orderByQueryString.Trim().Split(',');
            var propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var orderQueryBuilder = new StringBuilder();
            foreach (var param in orderParams)
            {
                var propertyFromQueryName = param.Split(" ")[0];
                var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

                if (objectProperty is null)
                    throw new Exception($"Parametro inválido: {orderByQueryString}. Esse campo não existe na entidade.");

                var sortingOrder = param.EndsWith(" desc") ? "desc" : "asc";

                orderQueryBuilder.Append($"{objectProperty.Name} {sortingOrder}, ");
            }

            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');

            return data.AsQueryable().OrderBy(orderQuery);
        }
    }
}
