﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using Castle.Facilities.Logging;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace DistribuaAlimento.Installers
{
    public class LoggerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //log4net.Config.XmlConfigurator.Configure();
           //container.AddFacility<LoggingFacility>(f => f.UseLog4Net());
        }
    }
}