using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using FoundationNetCore.Cms.Settings;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FoundationNetCore.Infrastructure
{
    [ModuleDependency(typeof(ServiceContainerInitialization))]
    [ModuleDependency(typeof(InitializationModule))]
    public class InitializeSite : IConfigurableModule
    {
        private IServiceCollection _services;
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            _services = context.Services;
            _services.AddHttpContextAccessor();
            _services.AddSingleton<ISettingsService, SettingsService>();
        }

        public void Initialize(InitializationEngine context)
        {
            context.InitComplete += ContextOnInitComplete;
        }

        public void Uninitialize(InitializationEngine context)
        {
            context.InitComplete -= ContextOnInitComplete;
        }

        private void ContextOnInitComplete(object sender, EventArgs eventArgs)
        {
            //Extensions.InstallDefaultContent();
            ServiceLocator.Current.GetInstance<ISettingsService>().InitializeSettings();
        }
    }
}
