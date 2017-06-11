using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.WebUI.Infrastructure
{
	public class DemoUnityDependencyResolver : IDependencyResolver
	{
		private IUnityContainer _unityContainer;

		public DemoUnityDependencyResolver(IUnityContainer unityContainer)
		{
			_unityContainer = unityContainer;
		}

		public object GetService(Type serviceType)
		{
			try
			{
				return _unityContainer.Resolve(serviceType);
			}
			catch(Exception)
			{
				return null;
			}
		}

		public IEnumerable<object> GetServices(Type serviceType)
		{
			try
			{
				return _unityContainer.ResolveAll(serviceType);
			}
			catch (Exception)
			{
				return new List<object>();
			}
		}
	}
}