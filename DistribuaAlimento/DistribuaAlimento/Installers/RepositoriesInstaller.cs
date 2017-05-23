using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using DistribuaAlimento.Repositorio.Implementacao;
using DistribuaAlimento.Repositorio.Interface;

namespace DistribuaAlimento.Installers
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {            
            container.Register(Classes.FromThisAssembly().Where(Component.IsInSameNamespaceAs<InstituicaoRepositorio>()).WithService.DefaultInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().Where(Component.IsInSameNamespaceAs<EventoRepositorio>()).WithService.DefaultInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().Where(Component.IsInSameNamespaceAs<AlimentoRepositorio>()).WithService.DefaultInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().Where(Component.IsInSameNamespaceAs<OrganizacoesFilantropicasRepositorio>()).WithService.DefaultInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().Where(Component.IsInSameNamespaceAs<EstoqueRepositorio>()).WithService.DefaultInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().Where(Component.IsInSameNamespaceAs<DoacaoRepositorio>()).WithService.DefaultInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().Where(Component.IsInSameNamespaceAs<ArrecadadoRepositorio>()).WithService.DefaultInterfaces().LifestyleTransient());
        }
    }
}