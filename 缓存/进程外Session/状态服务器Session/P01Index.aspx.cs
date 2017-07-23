using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 缓存.进程外Session.状态服务器Session
{
    public partial class P01Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                string name = Request.Form["name"];
                string pwd = Request.Form["pwd"];
                if (name == "admin" && pwd == "123")
                {
                    Session["name"] = name;
                    Response.Redirect("P02Default.aspx");
                }
            }
        }
    }
}