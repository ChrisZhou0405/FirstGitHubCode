using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Compare
{
    public partial class P01Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string GetShowInfo(string code)
        {
            if (code == "0102")
            {
                return "You"+"WHYME";
            }
            if(code=="002")
            {return "ME";}
            return "Chris Lee"+code;
            

        }
        pubic void SayHi()
        {
           
        }
    }
}
