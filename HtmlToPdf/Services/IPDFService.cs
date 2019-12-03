using System;
namespace HtmlToPdf.Services
{
    /// <summary>
    /// 与pdf相关
    /// </summary>
    public interface IPDFService
    {
        /// <summary>
        /// 创建PDF
        /// </summary>
        /// <param name="htmlContent">传入html字符串</param>
        /// <returns></returns>
        byte[] CreatePDF(string htmlContent);
    }
}
