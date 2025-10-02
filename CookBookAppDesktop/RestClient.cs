using CookBookAppDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CookBookAppDesktop
{
    internal class RestClient
    {
        private static readonly HttpClient _httpClient = new()
        {
            DefaultRequestHeaders =
            {
                Accept = { new MediaTypeWithQualityHeaderValue("application/json") }
            }
        };

        public string BaseUrl { get; set; }

        public string JwtToken { get; set; }

        private async Task<HttpResponseMessage> SendAsync(HttpMethod method, string endUrl, HttpContent content = null, Dictionary<string, string> customHeaders = null)
        {
            string Url = CombinerUrl(BaseUrl, endUrl);

            var request = new HttpRequestMessage(method, Url) { Content = content };
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Authorization = string.IsNullOrWhiteSpace(JwtToken) ? null : new AuthenticationHeaderValue("Bearer", JwtToken);

            if (customHeaders != null)
            {
                foreach (var header in customHeaders)
                {
                    request.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
            }

            HttpResponseMessage response;
            try
            {
                response = await _httpClient.SendAsync(request);
            }
            catch (Exception)
            {
                throw new HttpRequestException($"Erreur d'accès à l'API '{Url}'");
            }

            if (!response.IsSuccessStatusCode)
                await HandleError(response);

            return response;
        }

        private async Task HandleError(HttpResponseMessage response)
        {
            APIError problem = null;
            string raw = null;

            try
            {
                // On tente de lire le contenu comme APIError
                problem = await response.Content.ReadFromJsonAsync<APIError>();
            }
            catch
            {
                // Si la désérialisation échoue (pas du JSON ou mauvais format)
                problem = null;
            }

            // Si la désérialisation a échoué ou ne donne pas d'infos utiles
            if (problem == null || (string.IsNullOrWhiteSpace(problem.Error) && string.IsNullOrWhiteSpace(problem.Details)))
            {
                // On lit le contenu brut (JSON ou autre)
                raw = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(raw))
                {
                    throw new HttpRequestException($"Erreur HTTP {(int)response.StatusCode} : {response.ReasonPhrase}\nAucun contenu retourné.");
                }
                else
                {
                    throw new HttpRequestException($"Erreur HTTP {(int)response.StatusCode} : {response.ReasonPhrase}\nContenu non reconnu : {raw}");
                }
            }

            // Si on a pu désérialiser un objet APIError valide
            var message = $"Erreur {(int)response.StatusCode} : {problem.Error}\nDétails :\n{problem.Details}";
            throw new HttpRequestException(message);
        }

        private string CombinerUrl(string baseUrl, string endUrl)
        {
            if (string.IsNullOrEmpty(baseUrl))
                return endUrl;
            if (string.IsNullOrEmpty(endUrl))
                return baseUrl;
            return $"{baseUrl.TrimEnd('/')}/{endUrl.TrimStart('/')}";
        }


        #region GET

        public async Task<T> GetAsync<T>(string endpoint, Dictionary<string, string> customHeaders = null)
        {
            HttpResponseMessage response = await SendAsync(HttpMethod.Get, endpoint, null, customHeaders);

            // Si la réponse est vide (NoContent ou Content-Length = 0 ou null), retourne default
            var contentLength = response.Content?.Headers?.ContentLength;
            if (response.StatusCode == HttpStatusCode.NoContent || contentLength == 0 || contentLength is null)
                return default;

            return await response.Content.ReadJsonSafeAsync<T>();
        }

        #endregion GET

        #region POST

        public async Task<T> PostAsync<T, C>(string endpoint, C content, Dictionary<string, string> customHeaders = null)
        {
            HttpResponseMessage response = await SendAsync(HttpMethod.Post, endpoint, JsonContent.Create(content), customHeaders);

            // Si la réponse est vide (NoContent ou Content-Length = 0 ou null), retourne default
            var contentLength = response.Content?.Headers?.ContentLength;
            if (response.StatusCode == HttpStatusCode.NoContent || contentLength == 0 || contentLength is null)
                return default;

            return await response.Content.ReadJsonSafeAsync<T>();
        }

        public async Task PostAsync<C>(string endpoint, C content, Dictionary<string, string> customHeaders = null)
        {
            await SendAsync(HttpMethod.Post, endpoint, JsonContent.Create(content), customHeaders);
        }

        public async Task PostAsync(string endpoint, Dictionary<string, string> customHeaders = null)
        {
            await SendAsync(HttpMethod.Post, endpoint, null, customHeaders);
        }

        #endregion POST

        #region PUT

        public async Task<T> PutAsync<T, C>(string endpoint, C content, Dictionary<string, string> customHeaders = null)
        {
            HttpResponseMessage response = await SendAsync(HttpMethod.Put, endpoint, JsonContent.Create(content), customHeaders);

            // Si la réponse est vide (NoContent ou Content-Length = 0 ou null), retourne default
            var contentLength = response.Content?.Headers?.ContentLength;
            if (response.StatusCode == HttpStatusCode.NoContent || contentLength == 0 || contentLength is null)
                return default;

            return await response.Content.ReadJsonSafeAsync<T>();
        }

        public async Task PutAsync<C>(string endpoint, C content, Dictionary<string, string> customHeaders = null)
        {
            await SendAsync(HttpMethod.Put, endpoint, JsonContent.Create(content), customHeaders);
        }

        public async Task PutAsync(string endpoint, Dictionary<string, string> customHeaders = null)
        {
            await SendAsync(HttpMethod.Put, endpoint, null, customHeaders);
        }

        #endregion PUT

        #region DELETE

        public async Task<T> DeleteAsync<T>(string endpoint, Dictionary<string, string> customHeaders = null)
        {
            HttpResponseMessage response = await SendAsync(HttpMethod.Delete, endpoint, null, customHeaders);

            // Si la réponse est vide (NoContent ou Content-Length = 0 ou null), retourne default
            var contentLength = response.Content?.Headers?.ContentLength;
            if (response.StatusCode == HttpStatusCode.NoContent || contentLength == 0 || contentLength is null)
                return default;

            return await response.Content.ReadJsonSafeAsync<T>();
        }

        public async Task DeleteAsync(string endpoint, Dictionary<string, string> customHeaders = null)
        {
            await SendAsync(HttpMethod.Delete, endpoint, null, customHeaders);
        }

        public async Task DeleteAsync(string endpoint, object content, Dictionary<string, string> customHeaders = null)
        {
            await SendAsync(HttpMethod.Delete, endpoint, JsonContent.Create(content), customHeaders);
        }

        #endregion DELETE
    }





    public static class HttpContentExtensions
    {
        public static async Task<T> ReadJsonSafeAsync<T>(this HttpContent content)
        {
            try
            {
                return await content.ReadFromJsonAsync<T>();
            }
            catch (JsonException)
            {
                return default;
            }
        }
    }
}






