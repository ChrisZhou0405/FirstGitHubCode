using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Global文件
{
    /// <summary>
    /// P03Index 的摘要说明
    /// </summary>
    public class P03Index : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}