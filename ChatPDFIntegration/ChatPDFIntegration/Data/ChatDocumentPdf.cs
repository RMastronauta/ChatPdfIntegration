using ChatPDFIntegration.Domain;
using System.Globalization;

namespace ChatPDFIntegration.Data
{
    public class ChatDocumentPdf : IChatDocumentPdf
    {
        public void PostSourceId(string sourceId)
        {
            try
            {
                if (sourceId == null)
                {
                    throw new ArgumentNullException("O id informado está nulo.");
                }
            }catch(ArgumentNullException ar)
            {
                
            }catch (Exception ex) 
            {
                
            }
        }

    }
}
