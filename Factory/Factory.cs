using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    using System.Reflection;
    public class Factory
    {
        public static IDAL.IGroupInfoDAL CreateInstance()
        {
            //return new SQLDAL.GroupInfoDAL();
            //通过反射创建对象
            //将程序集名称配置起来
            string name = System.Configuration.ConfigurationManager.AppSettings["name"];

            //得到dal的程序集
            Assembly ass = Assembly.Load(name);
            //根据程序创建对象
            object obj = ass.CreateInstance(name+".GroupInfoDAL");
            //返回
            return (IDAL.IGroupInfoDAL)obj;
        }
    }
}
