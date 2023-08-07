using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inspire
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String path = Server.MapPath("App_Data\\blogs.xml");
            List<Post> postList = XMLFile.getListBlogInXML(path);
            String category = Request.QueryString["category"];
            String disPlay = "";
            for(int i = postList.Count - 1; i >= 0; i--)
            {
                if(postList[i].Category.Equals(category))
                {
                    disPlay += postList[i].getHtml();
                }
            }
            homeContent.InnerHtml = disPlay;
        }
    }
}