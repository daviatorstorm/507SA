﻿using System.Web;
using System.Web.Optimization;
namespace _507SA.App_Start
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css"));

			bundles.Add(new StyleBundle("~/css/layout").Include(
					  "~/Content/main.css"));

			bundles.Add(new StyleBundle("~/css/join").Include(
					  "~/Content/join.css"));
		}
	}
}