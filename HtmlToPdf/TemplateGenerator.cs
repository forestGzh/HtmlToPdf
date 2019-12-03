using System;
using System.Text;

namespace HtmlToPdf
{
    public static class TemplateGenerator
    {
        /// <summary>
        /// 获取HTML字符串
        /// </summary>
        /// <returns></returns>
        public static string GetPDFHTMLString()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append(@"
<html>
  <head>
    <meta http-equiv='Content-Type' content='text/html; charset=utf-8' />
    <style>
      
    </style>
  </head>

  <body>
    <div>
        这是一个网页！
    </div>
  </body>
</html>
            ");

            return sb.ToString();
        }
    }
}
