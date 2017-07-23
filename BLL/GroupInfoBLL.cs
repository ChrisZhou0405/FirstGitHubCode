using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GroupInfoBLL
    {
        IDAL.IGroupInfoDAL dal = Factory.Factory.CreateInstance();

        public string GetDatas()
        {
            return dal.GetDatas();
        }
    }
}
