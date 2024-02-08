using ChatPDFIntegration.Domain;
using ChatPDFIntegration.Model.Data;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.Text;

namespace ChatPDFIntegration.Model
{
    public class PostDocumentData
    {
        public static async Task PostDocument(string apiUrl, string requestBody, ResponseLog resp)
        {
            if (apiUrl == null)
            {
                resp.isSuccess = false;
                resp.message = "Url não informada.";
            }
            var headers = new Dictionary<string, string>
            {
                { "x-api-key", "sec_Nssf7VuF4RJ3LiTLwUZgurDkAd18FOm6" }
                // Adicione outros cabeçalhos conforme necessário
            };
            using (HttpClient client = new HttpClient())
            {
                try
                { 
                    foreach (var header in headers)
                    {
                        client.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }

                    HttpResponseMessage response = await client.PostAsync(apiUrl, new StringContent(requestBody, Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        dynamic sourceId = JsonConvert.DeserializeObject(result);
                        resp.isSuccess = true;
                        resp.message = sourceId.sourceId;
                    }
                    else
                    {
                        resp.isSuccess = false;
                        resp.message = $"Falha na solicitação: {response.StatusCode}";
                    }
                }
                catch (Exception ex)
                {
                    resp.isSuccess = false;
                    resp.message = $"Falha na solicitação: {ex.Message}";
                }
            }
        }
    }
}
