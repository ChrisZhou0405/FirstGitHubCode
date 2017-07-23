using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GroupInfoDAL:IDAL.IGroupInfoDAL
    {
        public string GetDatas()
        {
            return "数据来源于ORACAL";
        }
    }
}
