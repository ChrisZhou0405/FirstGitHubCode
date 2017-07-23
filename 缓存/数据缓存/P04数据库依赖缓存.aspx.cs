using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 缓存.数据缓存
{
    public partial class P04数据库依赖缓存 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //设置数据库依赖缓存
            if (HttpRuntime.Cache["Time"] == null)
            {
                object obj = DateTime.Now;
                ///两个参数的含义：第一个：配置文件中配置的名称，第二个：设置缓存表的名称
                ///设置数据库依赖项
                System.Web.Caching.SqlCacheDependency sqlDep = new System.Web.Caching.SqlCacheDependency("contents", "GroupInfo");

                HttpRuntime.Cache.Add(
                    "Time",
                     obj,
                     sqlDep,
                     System.Web.Caching.Cache.NoAbsoluteExpiration,
                     System.Web.Caching.Cache.NoSlidingExpiration,
                     System.Web.Caching.CacheItemPriority.Normal,
                     null
                    );
                Response.Write("缓存设置成功，当前缓存的时间为：" + obj.ToString());
            }
            else
            {
                Response.Write("从缓存得到时间，时间为：" + HttpRuntime.Cache["Time"].ToString());
            }


        }
    }
}