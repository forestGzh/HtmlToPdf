using System;
using DinkToPdf;
using DinkToPdf.Contracts;

namespace HtmlToPdf.Services
{
    /// <summary>
    /// 与pdf相关
    /// </summary>
    public class PDFService : IPDFService
    {
        private IConverter _converter;
        public PDFService(IConverter converter)
        {
            _converter = converter;
        }

        /// <summary>
        /// 创建PDF
        /// </summary>
        /// <param name="htmlContent">传入html字符串</param>
        /// <returns></returns>
        public byte[] CreatePDF(string htmlContent)
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                //Margins = new MarginSettings
                //{
                //    Top = 10,
                //    Left = 0,
                //    Right = 0,
                //},
                DocumentTitle = "PDF Report",
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = htmlContent,
                // Page = "www.baidu.com", //USE THIS PROPERTY TO GENERATE PDF CONTENT FROM AN HTML PAGE
                //WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },
                WebSettings = { DefaultEncoding = "utf-8" },
                //HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                //FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var file = _converter.Convert(pdf);

            //return File(file, "application/pdf");

            return file;

        }
    }
}
