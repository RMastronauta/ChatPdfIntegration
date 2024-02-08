using System.Globalization;
using static System.Net.WebRequestMethods;

namespace ChatPDFIntegration.Model.Data
{
    public class ChatDocument
    {
        public string UrlPostDocumentApi { get; } = "https://uscode.house.gov/static/constitution.pdf";
        public string UrlPostMensagem { get; } = "https://api.chatpdf.com/v1/chats/message";

    }
}
