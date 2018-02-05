using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice.Web.ASP_NET.DotNetBasic
{
    public partial class StackExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Sample 1");
            stack.Push("Sample 2");
            stack.Push("Sample 3");

            Response.Write("Pop: " + stack.Pop() + "<br/>");
            
            if(stack.Contains("Sample 1"))
            {
                Response.Write("Sample 1 is present" + "<br/>");
            }

        }
    }
}