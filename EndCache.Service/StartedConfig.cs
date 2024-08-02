using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Graph.Models.ExternalConnectors;
using System.Diagnostics.CodeAnalysis;

namespace EndCache.Service
{

    //USAR PROTOBUFF PARA COMPACTAR OS DADOS ARMAZENADOS EM MEMORIA.
    public static class StartedConfig
    {
        public static IServiceCollection AddEndCache(this IServiceCollection services, Action<Configuracoes> configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            configuration(new Configuracoes());

            return services;
        }
    }
}
