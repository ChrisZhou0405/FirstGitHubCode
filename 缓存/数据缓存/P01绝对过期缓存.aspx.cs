using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 缓存.数据缓存
{
    public partial class P01绝对过期缓存 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpRuntime.Cache["Time"] == null)
            {
                ///设置绝对过期缓存
                object obj = DateTime.Now;//从数据库中读取出来的
                //将数据库中查询出来的数据保存到缓存中
                HttpRuntime.Cache.Add(
                    "Time",//缓存的键
                    obj,//缓存的值
                    null,//缓存依赖项
                    DateTime.Now.AddSeconds(10),//绝对过期时间
                    System.Web.Caching.Cache.NoSlidingExpiration,//滑动过期时间
                    System.Web.Caching.CacheItemPriority.Normal,//缓存移除的优先级
                    null//移除时的回调函数
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