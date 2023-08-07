using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inspire
{
    public class Comment
    {
        private long postID;
        private String value;
        private String userName;

        public Comment()
        {

        }

        public Comment(long postID, String value, String userName)
        {
            this.postID = postID;
            this.value = value;
            this.userName = userName;
        }

        public long PostID
        {
            get
            {
                return postID;
            }

            set
            {
                postID = value;
            }
        }

        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public String getHTML()
        {
            String html = "";
            html += "<div class =\"comment\">"
                 + "<div class=\"commentAvatar\">"
                 + "<img src = \"Images/image_user.png \">"
                 + "</div>"
                 + "<p><b>" + userName + "</b></p>"
                 + "<p>" + value + "</p>"
                 + "</div>";
            return html;
        }
    }
}