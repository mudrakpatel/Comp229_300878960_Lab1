﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Comp229_Lab1_300878960
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var h1 = new HtmlGenericControl("h1");
            h1.InnerHtml = "Mudrak Patel's page";
        }
    }
}