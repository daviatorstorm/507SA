using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _507SA.DependencyInjection
{
	public interface IWebTypeResolver
	{
		void RegisterType(IUnityContainer container);
	}
}