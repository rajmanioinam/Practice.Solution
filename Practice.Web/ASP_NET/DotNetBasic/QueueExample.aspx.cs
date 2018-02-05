using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice.Web.ASP_NET.DotNetBasic
{
    public partial class QueueExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Mellon");
            Response.Write("Queue Count: " + queue.Count + "<br/>");
            Response.Write("Peek: " + queue.Peek() + "<br/>");
            Response.Write("Dequeue: " + queue.Dequeue() + "<br/>");
            Response.Write("Queue Count: " + queue.Count);
            

        }
    }
}