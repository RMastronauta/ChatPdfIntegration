using ChatPDFIntegration.Data;
using ChatPDFIntegration.Domain;
using ChatPDFIntegration.Model.Data;

namespace ChatPDFIntegration.Model
{
    public class ChatPdfIntegration : IChatPdfIntegration
    {
        private readonly IChatDocumentPdf ChatDocumentPdf = new ChatDocumentPdf();
        public ResponseLog PostDocumentPdfForUrl(string url)
        {
            ResponseLog resp = new();
            string urlApi = new ChatDocument().UrlPostDocumentApi;
            string requestBody = $"{{\"chave\": {url} }}";
            PostDocumentData.PostDocument(urlApi, requestBody, resp);
            if (resp.isSuccess)
                ChatDocumentPdf.PostSourceId(resp.message);
            return resp;
        }

        public string PostMensageForPdfName(EnumTipoDocumentPdf name, string mensagem)
        {
            throw new NotImplementedException();
        }
    }
}
