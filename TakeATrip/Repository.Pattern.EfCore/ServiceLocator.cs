using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Pattern.EfCore
{
    public class ServiceLocator
    {
        private ServiceProvider _currentServiceProvider;
        private static ServiceProvider _serviceProvider;
        public static bool IsLocationProviderSet { get; private set; }

        public ServiceLocator(ServiceProvider currentServiceProvider)
        {
            _currentServiceProvider = currentServiceProvider;
        }

        public static ServiceLocator Current
        {
            get
            {
                return new ServiceLocator(_serviceProvider);
            }
        }

        public static void SetLocatorProvider(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IsLocationProviderSet = true;
        }

        public object GetInstance(Type serviceType)
        {
            return _currentServiceProvider.GetService(serviceType);
        }

        public TService GetInstance<TService>()
        {
            return _currentServiceProvider.GetService<TService>();
        }
    }
}
