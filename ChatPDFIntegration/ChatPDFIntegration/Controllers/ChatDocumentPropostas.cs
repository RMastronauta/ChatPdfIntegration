using ChatPDFIntegration.Domain;
using ChatPDFIntegration.Model;
using ChatPDFIntegration.Model.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChatPDFIntegration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatDocumentPropostas : ControllerBase
    {
        private readonly IChatPdfIntegration ChatDocumentPdf = new ChatPdfIntegration();
        // GET: api/<ChatDocumentPropostas>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Teste");
        }

        // POST api/<ChatDocumentPropostas>
        [HttpPost]
        public ActionResult PostDocument([FromBody] string url)
        {
            ResponseLog resp = ChatDocumentPdf.PostDocumentPdfForUrl(url);
            return Ok(resp);
        }

    }
}
