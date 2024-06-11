using SchoolFinder.Infra.Messaging.Extensions;
using System.Text.Json;

namespace SchoolFinder.Infra.Messaging.JsonPolicies
{
    public class JsonSnakeCasePolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
            => name.ToSnakeCase();
    }
}
