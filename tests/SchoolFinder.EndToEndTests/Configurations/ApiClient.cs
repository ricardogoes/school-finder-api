using Microsoft.AspNetCore.WebUtilities;
using SchoolFinder.Infra.Messaging.JsonPolicies;
using System.Text;
using System.Text.Json;

namespace SchoolFinder.EndToEndTests.Configurations
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _defaultSerializeOptions;

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _defaultSerializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = new JsonSnakeCasePolicy(),
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<(HttpResponseMessage, TOutput)> PostAsync<TOutput>(string route, object? request) where TOutput : class
        {
            var requestJson = JsonSerializer.Serialize(request, _defaultSerializeOptions);

            var response = await _httpClient.PostAsync(route, new StringContent(requestJson, Encoding.UTF8, "application/json"));
            var output = await GetOutputAsync<TOutput>(response);

            return (response, output);
        }

        public async Task<(HttpResponseMessage, TOutput)> PutAsync<TOutput>(string route, object? request) where TOutput : class
        {
            var requestJson = JsonSerializer.Serialize(request, _defaultSerializeOptions);

            var response = await _httpClient.PutAsync(route, new StringContent(requestJson, Encoding.UTF8, "application/json"));
            var output = await GetOutputAsync<TOutput>(response);

            return (response, output);
        }

        public async Task<(HttpResponseMessage, TOutput)> GetByIdAsync<TOutput>(string route, object? queryStringParametersObject = null) where TOutput : class
        {
            var urlToCall = PrepareGetRoute(route, queryStringParametersObject);

            var response = await _httpClient.GetAsync(urlToCall);
            var output = await GetOutputAsync<TOutput>(response);

            return (response, output);
        }

        public async Task<(HttpResponseMessage, TOutput)> GetAsync<TOutput>(string route, object? queryStringParametersObject = null) where TOutput : class
        {
            var urlToCall = PrepareGetRoute(route, queryStringParametersObject);

            var response = await _httpClient.GetAsync(urlToCall);
            var output = await GetOutputAsync<TOutput>(response);

            return (response, output);
        }

        private async Task<TOutput> GetOutputAsync<TOutput>(HttpResponseMessage response) where TOutput : class
        {
            var outputString = await response.Content.ReadAsStringAsync();

            TOutput? output = null;

            if (!string.IsNullOrWhiteSpace(outputString))
                output = JsonSerializer.Deserialize<TOutput>(outputString, _defaultSerializeOptions);

            return output!;
        }

        private string PrepareGetRoute(string route, object? queryStringParametersObject)
        {
            if (queryStringParametersObject is null)
                return route;

            var parametersJson = JsonSerializer.Serialize(queryStringParametersObject, _defaultSerializeOptions);
            var parametersDictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(parametersJson);

            return QueryHelpers.AddQueryString(route, parametersDictionary!);
        }
    }
}
