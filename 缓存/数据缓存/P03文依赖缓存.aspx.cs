using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 缓存.数据缓存
{
    public partial class P03文依赖缓存 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpRuntime.Cache["Time"] == null)
            {
                //设置文件依赖缓存
                object obj = DateTime.Now;

                //设置文件依赖项
                System.Web.Caching.CacheDependency dep = new System.Web.Caching.CacheDependency(Server.MapPath("/数据缓存/1.txt"));

                HttpRuntime.Cache.Add(
                    "Time",//键
                    obj,//值
                    dep,//依赖项
                    System.Web.Caching.Cache.NoAbsoluteExpiration,//绝对过期时间
                     System.Web.Caching.Cache.NoSlidingExpiration,//相对过期时间
                      System.Web.Caching.CacheItemPriority.Normal,//优先级
                       null//回调函数
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