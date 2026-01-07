using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Html_Helpr_prj.CustomHelpers
{
    public class CustomStaticHelpers
    {
        public static IHtmlString LabelwithMark(string content)
        {
            string htmlstr = string.Format("<label><b><mark><i><del>{0}</del></i></mark></b></label>",content);
            return new HtmlString(htmlstr);
        }
    }
}