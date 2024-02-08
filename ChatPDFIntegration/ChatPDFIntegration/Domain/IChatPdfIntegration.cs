using ChatPDFIntegration.Model.Data;
using System.Globalization;

namespace ChatPDFIntegration.Domain
{
    public interface IChatPdfIntegration
    {
        public ResponseLog PostDocumentPdfForUrl(string url);

        public string PostMensageForPdfName(EnumTipoDocumentPdf name, string mensagem);
        

    }
}