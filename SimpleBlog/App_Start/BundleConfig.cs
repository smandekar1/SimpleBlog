﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SimpleBlog
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/admin.css"));
                

            bundles.Add(new StyleBundle("~/styles")
                // .Include("~/scripts/jquery-1.8.0.js")  // new
                // .Include("~/scripts/jquery.validate.js") // new 
                // .Include("~/scripts/jquery.validate.unobtrusive.js") // new
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/site.css"));

            bundles.Add(new ScriptBundle("~/admin/scripts")
                .Include("~/scripts/jquery-2.1.4.js")// changed from 1.8.0 2.1.4
                .Include("~/scripts/jquery.validate.js")
                .Include("~/scripts/jquery.validate.unobtrusive.js")
                .Include("~/scripts/bootstrap.js")
                .Include("~/areas/admin/scripts/forms.js")); 


            bundles.Add(new ScriptBundle("~/scripts")
                .Include("~/scripts/jquery-2.1.4.js")// changed from   1.8.0  2.1.4
                .Include("~/scripts/jquery.validate.js")
                .Include("~/scripts/jquery.validate.unobtrusive.js")
                .Include("~/scripts/bootstrap.js"));

        }
    }
}