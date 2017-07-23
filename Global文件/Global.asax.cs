using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Global文件
{
    /// <summary>
    /// 在使用Global文件的时候注意：(过滤器)
    ///   1）一个网站中只能有一个Global文件
    ///   2）这个文件中的方法不能改变其名称
    ///   3）这个文件中最好不要动态添加方法
    /// </summary>
    public class Global : System.Web.HttpApplication
    {

        #region 1.0应用程序开启和关闭的时候各执行一次(将来在最后一个大项目中做聊天功能的时候会用)
        protected void Application_Start(object sender, EventArgs e)
        {

        }
        protected void Application_End(object sender, EventArgs e)
        {

        }
        #endregion

        #region 2.0会话开始和结束各执行一次（可控性相对而言要低）
        protected void Session_Start(object sender, EventArgs e)
        {

        }
        protected void Session_End(object sender, EventArgs e)
        {

        }
        #endregion

        #region 3.0给管道事件的第一个以及第二个事件注册方法
        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }
        #endregion

        #region 4.0页面上统一的错误处理方法（没有被try catch的错误会被这个方法捕捉到）
        protected void Application_Error(object sender, EventArgs e)
        {
            //Redirect页面的跳转：浏览器跳转
            //Server.Transfer：服务器跳转，要跳转页面的必须是在当前网站上面的页面，Transfer不能跳转到ashx页面中。
            // Context.Response.Redirect("/Error.aspx");
            Exception exc = Server.GetLastError();
            System.Text.StringBuilder sbhtml = new System.Text.StringBuilder();
            sbhtml.Append(exc.InnerException.Message);
            Response.Write(sbhtml);
            Response.End();
        }
        #endregion

    }
}