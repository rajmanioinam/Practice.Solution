using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice.Web.ASP_NET.DotNetBasic
{
    public partial class DictionaryExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<h2>Prefered over list when looking up for data in the collection of the items. </h2>");
            Response.Write("<h3>Data stored as key value pair. </h3>");
            Response.Write("List Result <br/>");
            List<string> list = new List<string>();
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Mellon");

            Response.Write(list.Find(l=> l=="Mellon") + "<br/><br/>");

            Response.Write("Dictionary Result <br/>");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Apple");
            dictionary.Add(2, "Banana");
            dictionary.Add(3, "Avocado");

            string result = string.Empty;
            result = dictionary.ContainsKey(2) ? dictionary[2] : null;
            Response.Write(result + "<br/>");

            dictionary[3] = "Grapes";
            Response.Write(dictionary[3]);
        }
    }
}