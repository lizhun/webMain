using System.Web.Mvc;

namespace MainController.App_Start
{
    public class CSharpRazorViewEngine : RazorViewEngine
    {
        public CSharpRazorViewEngine(bool isSupportMvcAreas)
            : this(null, isSupportMvcAreas)
        {
        }

        public CSharpRazorViewEngine(IViewPageActivator viewPageActivator, bool isSupportMvcAreas)
            : base(viewPageActivator)
        {
            if (isSupportMvcAreas)
            {
                this.AreaViewLocationFormats = new[]
                {
                    "~/Areas/{2}/Views/{1}/{0}.cshtml",
                    "~/Areas/{2}/Views/Shared/{0}.cshtml",
                };
                this.AreaMasterLocationFormats = new[]
                {
                    "~/Areas/{2}/Views/{1}/{0}.cshtml",
                    "~/Areas/{2}/Views/Shared/{0}.cshtml",
                };
                this.AreaPartialViewLocationFormats = new[]
                {
                    "~/Areas/{2}/Views/{1}/{0}.cshtml",
                    "~/Areas/{2}/Views/Shared/{0}.cshtml",
                };
            }
            else {
                this.AreaViewLocationFormats = null;
                this.AreaMasterLocationFormats = null;
                this.AreaPartialViewLocationFormats = null;
            }

            this.ViewLocationFormats = new[]
            {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml",
                "~/Views/{0}.cshtml",
            };
            this.MasterLocationFormats = new[]
            {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml",
            };
            this.PartialViewLocationFormats = new[]
            {
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml",
            };

            this.FileExtensions = new[]
            {
                "cshtml",
            };
        }
    }
}