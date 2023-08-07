using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inspire
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application["tongSoTruyCap"] = (int)Application["tongSoTruyCap"] + 1;
            String path = Server.MapPath("App_Data\\blogs.xml");
            List<Post> postList = XMLFile.getListBlogInXML(path);
            String disPlay = "";
            for(int i = postList.Count - 1; i >= 0 ; i--)
            {
                disPlay += postList[i].getHtml();
            }
            homeContent.InnerHtml = disPlay;
            Label1.Text = "Số người Online:"+(int)Application["soNguoiTruyCap"];
            Label2.Text = "Tổng số người truy cập:"+(int)Application["tongSoTruyCap"];

        }
    }
}