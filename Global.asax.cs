using System;
using System.Linq;
using System.Web.Optimization;
using Sitefinity.PowerTools;
using SitefinityWebApp.App_Start;
using SitefinityWebApp.Mvc.Controllers;

namespace SitefinityWebApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // register mvc designers
            PowerTools.Instance
                      .Mvc
                      .RegisterDesigner<AdHocListController, AdHocListDesignerController>();

            // register bundles
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        
    }
}