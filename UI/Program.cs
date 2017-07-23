using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            BLL.GroupInfoBLL bll = new BLL.GroupInfoBLL();
            Console.WriteLine(bll.GetDatas());
            Console.ReadKey();
        }
    }
}
