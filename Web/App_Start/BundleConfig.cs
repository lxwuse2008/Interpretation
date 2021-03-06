﻿using System.Web;
using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/index.css",
                      "~/Content/css/layout.css",
                      "~/Content/css/register.css"));
        }
    }
}
