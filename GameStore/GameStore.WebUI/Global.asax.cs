﻿using GameStore.Domain.Abstract;
using GameStore.WebUI.Controllers;
using GameStore.WebUI.Infrastructure;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GameStore.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

			IUnityContainer container = new UnityContainer();
			container.RegisterType<GameController>();
			container.RegisterType<IGameRepository, LocalRepository>();
			DependencyResolver.SetResolver(new DemoUnityDependencyResolver(container));
		}
    }
}
