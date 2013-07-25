using System.Web;
using System.Web.Optimization;

namespace MvcAssignment
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles) {
			bundles.Add(new ScriptBundle("~/bundle/jquery").Include(
						"~/Scripts/jquery.min.js"));

			bundles.Add(new ScriptBundle("~/Scripts/bootstrap").Include(
						"~/Scripts/bootstrap.min.js"));

			bundles.Add(new ScriptBundle("~/Scripts/validate").Include(
						"~/Scripts/validate.min.js"));

			bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
						"~/Content/bootstrap.css",
						"~/Content/bootstrap-responsive.css"));

			bundles.Add(new StyleBundle("~/Content/fonts").Include(
						"~/Content/MyriadPro.css",
						"~/Content/OpenSans.css"));

			bundles.Add(new StyleBundle("~/Content/custom").Include(
						"~/Content/style.css"));
		}
	}
}