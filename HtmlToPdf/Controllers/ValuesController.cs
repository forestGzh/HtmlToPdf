using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmlToPdf.Services;
using Microsoft.AspNetCore.Mvc;

namespace HtmlToPdf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IPDFService _PDFService;

        public ValuesController(IPDFService pDFService)
        {
            _PDFService = pDFService;
        }

        [HttpGet("pdf")]
        public FileResult GetPDF()
        {
            //获取html模板
            var htmlContent = TemplateGenerator.GetPDFHTMLString();

            //生成PDF
            var pdfBytes = _PDFService.CreatePDF(htmlContent);

            return File(pdfBytes, "application/pdf");
        }
    }
}
