﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static Warp.WebUI.Controllers.AccountController Account = new Warp.WebUI.Controllers.T4MVC_AccountController();
    public static Warp.WebUI.Controllers.AuthenticationController Authentication = new Warp.WebUI.Controllers.T4MVC_AuthenticationController();
    public static Warp.WebUI.Controllers.ClientController Client = new Warp.WebUI.Controllers.T4MVC_ClientController();
    public static Warp.WebUI.Controllers.DashboardControlsController DashboardControls = new Warp.WebUI.Controllers.T4MVC_DashboardControlsController();
    public static Warp.WebUI.Controllers.HomeController Home = new Warp.WebUI.Controllers.T4MVC_HomeController();
    public static Warp.WebUI.Controllers.TextResourceController TextResource = new Warp.WebUI.Controllers.T4MVC_TextResourceController();
    public static Warp.WebUI.Controllers.UserController User = new Warp.WebUI.Controllers.T4MVC_UserController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
        public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
        public static readonly string jquery_2_1_1_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.1.intellisense.min.js") ? Url("jquery-2.1.1.intellisense.min.js") : Url("jquery-2.1.1.intellisense.js");
        public static readonly string jquery_2_1_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.1.min.js") ? Url("jquery-2.1.1.min.js") : Url("jquery-2.1.1.js");
        public static readonly string jquery_2_1_1_min_js = Url("jquery-2.1.1.min.js");
        public static readonly string jquery_2_1_1_min_map = Url("jquery-2.1.1.min.map");
        public static readonly string jquery_typewatch_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.typewatch.min.js") ? Url("jquery.typewatch.min.js") : Url("jquery.typewatch.js");
        public static readonly string jquery_unobtrusive_ajax_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.unobtrusive-ajax.min.js") ? Url("jquery.unobtrusive-ajax.min.js") : Url("jquery.unobtrusive-ajax.js");
        public static readonly string jquery_unobtrusive_ajax_min_js = Url("jquery.unobtrusive-ajax.min.js");
        public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.bootstrap.min.js") ? Url("jquery.validate.unobtrusive.bootstrap.min.js") : Url("jquery.validate.unobtrusive.bootstrap.js");
        public static readonly string jquery_validate_unobtrusive_bootstrap_min_js = Url("jquery.validate.unobtrusive.bootstrap.min.js");
        public static readonly string jquery_validate_unobtrusive_bootstrap_min_js_map = Url("jquery.validate.unobtrusive.bootstrap.min.js.map");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        public static readonly string npm_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/npm.min.js") ? Url("npm.min.js") : Url("npm.js");
        public static readonly string TwitterBootstrapMvcJs_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/TwitterBootstrapMvcJs.min.js") ? Url("TwitterBootstrapMvcJs.min.js") : Url("TwitterBootstrapMvcJs.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_theme_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap-theme.min.css") ? Url("bootstrap-theme.min.css") : Url("bootstrap-theme.css");
             
        public static readonly string bootstrap_theme_css_map = Url("bootstrap-theme.css.map");
        public static readonly string bootstrap_theme_min_css = Url("bootstrap-theme.min.css");
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
             
        public static readonly string bootstrap_css_map = Url("bootstrap.css.map");
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        public static readonly string flaty_responsive_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/flaty-responsive.min.css") ? Url("flaty-responsive.min.css") : Url("flaty-responsive.css");
             
        public static readonly string flaty_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/flaty.min.css") ? Url("flaty.min.css") : Url("flaty.css");
             
        public static readonly string font_awesome_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/font-awesome.min.css") ? Url("font-awesome.min.css") : Url("font-awesome.css");
             
        public static readonly string font_awesome_min_css = Url("font-awesome.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Images {
            private const string URLPATH = "~/Content/Images";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string HospitalityGemLogo300dpi_png = Url("HospitalityGemLogo300dpi.png");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Styles {
            private const string URLPATH = "~/Content/Styles";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Authentication {
                private const string URLPATH = "~/Content/Styles/Authentication";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string Login_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Login.min.css") ? Url("Login.min.css") : Url("Login.css");
                     
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Shared {
                private const string URLPATH = "~/Content/Styles/Shared";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            }
        
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class SVG {
            private const string URLPATH = "~/Content/SVG";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Loaders {
                private const string URLPATH = "~/Content/SVG/Loaders";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string tail_spin_svg = Url("tail-spin.svg");
            }
        
        }
    
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
    }
}


[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
		return virtualPath;
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009


