﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name:"Home",
                url:"Anasayfa",
                defaults:new { controller="Home",action="Index" },
                 namespaces: new[] { "MVCBlog.Controllers" }
                );

            routes.MapRoute(
                name:"BlogHaber",
                url:"Blog/{title}/{id}",
                defaults:new { controller ="SiteBlog",action="Index",id=UrlParameter.Optional,title=UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "MVCBlog.Controllers" }
            );
        }
    }
}
