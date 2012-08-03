﻿using System;
using Microsoft.Web.Optimization;

[assembly: WebActivator.PostApplicationStartMethod(typeof(FoundationASPMVC.App_Start.BundleStart), "Start")]
namespace FoundationASPMVC.App_Start
{
    public class BundleConfig
    {
        //add Script paths here
        public static string[] scriptPaths = 
    {
        "~/Scripts/jquery-1.7.2.min.js" /* Shipped with MVC via nuget */,
        "~/Scripts/core/jquery.foundation.reveal.js",
        "~/Scripts/core/jquery.foundation.orbit.js",
        "~/Scripts/core/jquery.foundation.navigation.js",
        "~/Scripts/core/jquery.foundation.buttons.js",
        "~/Scripts/core/jquery.foundation.tabs.js",
        "~/Scripts/core/jquery.foundation.forms.js",
        "~/Scripts/core/jquery.foundation.tooltips.js",
        "~/Scripts/core/jquery.foundation.accordion.js",
        // current version of placeholder.js does not work with jquery.validation.js
        //"~/Scripts/core/jquery.placeholder.js",
        "~/Scripts/core/jquery.foundation.alerts.js"
    };

        //add style sheets here
        public static string[] cssPaths = 
    {
        // current release of Foundation has pre-minified css
        // expected to change in future versions
    	"~/Content/core/foundation.css"
    };

        public static void BundleJs()
        {
            Bundle jsBundle = new Bundle("~/Scripts/core/min.js", typeof(JsMinify));
            foreach (var item in scriptPaths)
            {
                jsBundle.AddFile(item.ToString());
            }
            BundleTable.Bundles.Add(jsBundle);
        }

        public static void BundleCss()
        {
            Bundle cssBundle = new Bundle("~/Content/core/min.css", typeof(CssMinify));
            foreach (var item in cssPaths)
            {
                cssBundle.AddFile(item);
            }
            BundleTable.Bundles.Add(cssBundle);
        }
    }

    public static class BundleStart
    {

        public static void Start()
        {
            BundleConfig.BundleCss();
            BundleConfig.BundleJs();
        }
    }
}