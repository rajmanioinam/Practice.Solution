using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice.Web.ASP_NET
{
    public partial class PageLifeCycle : System.Web.UI.Page
    {
        /*
        Web applications work on a stateless protocol.
        Every time a request is made for a webform, the following sequence of events occur.
        1. Web Application creates an instance of the requested webform.
        2. Processes the events of the webform.
        3. Generates the HTML, and sends the HTML back to the requested client.
        4. The webform gets destroyed and removed from the memory.

        PreInit - As the name suggests, this event happens just before page initialization event starts.
            IsPostBack, IsCallback and IsCrossPagePostBack properties are set at this stage. 
            This event allows us to set the master page and theme of a web application dynamically.
            PreInit is extensively used when working with dynamic controls.

        Init - Page Init, event occurs after the Init event, of all the individual controls on the webform. 
            Use this event to read or initialize control properties.
            The server controls are loaded and initialized from the Web form’s view state.

        InitComplete - As the name says, this event gets raised immediately after page initialization.

        PreLoad - Happens just before the Page Load event.

        Load - Page Load event, occurs before the load event of all the individual controls on that webform.

        Control Events - After the Page load event, the control events like button's click, 
            dropdownlist's selected index changed events are raised.

        Load Complete - This event is raised after the control events are handled.

        PreRender - This event is raised just before the rendering stage of the page. 

        PreRenderComplete - Raised immediately after the PreRender event.

        Unload - Raised for each control and then for the page. At this stage the page is, unloaded from memory.

        Error - This event occurs only if there is an unhandled exception
        */
        protected void Page_PreInit(object sender, EventArgs e)
        { Response.Write("Page_PreInit" + "<br/>"); }

        protected void Page_Init(object sender, EventArgs e)
        { Response.Write("Page_Init" + "<br/>"); }

        protected void Page_InitComplete(object sender, EventArgs e)
        { Response.Write("Page_InitComplete" + "<br/>"); }

        protected void Page_PreLoad(object sender, EventArgs e)
        { Response.Write("Page_PreLoad" + "<br/>"); }

        protected void Page_LoadComplete(object sender, EventArgs e)
        { Response.Write("Page_LoadComplete" + "<br/>"); }

        protected void Page_PreRender(object sender, EventArgs e)
        { Response.Write("Page_PreRender" + "<br/>"); }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        { Response.Write("Page_PreRenderComplete" + "<br/>"); }

        protected void Page_Unload(object sender, EventArgs e)
        {
            //Response.Write("Page_Unload" + "<br/>"); 
        }
    }
}