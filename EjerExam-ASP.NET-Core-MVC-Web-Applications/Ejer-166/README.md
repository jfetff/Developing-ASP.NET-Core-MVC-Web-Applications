# QUESTION 166

## DRAG DROP

You are developing an ASP.NET Core application. You plan to use YAML as the configuration language. You create a custom YAML configuration parser.

You need to implement a mechanism to support reading and applying these YAML configurations.

How should you complete the code? To answer, drag the appropriate code segments to the correct locations. Each code segment may be used once, more than once, or not at all. You may need to drag the split bar between panes or scroll to view content.

## Explicación
#### **Caja No. 1**: FileConfigurationSource
#### **Caja No. 2**: FileConfigurationProvider

#### Errata en la respuesta del ejercicio se dan intercambiados.


## Explicación:

Para explicar la respuesta de la pregunta, lo primero es crear un proveedor de configuración!

1. Para crear un proveedor personalizado, solo necesita implementar dos interfaces del paquete **Microsoft.Extensions.Configuration.Abstractions:** IConfigurationProvider e IConfigurationSource.

En realidad, es poco probable que necesite implementarlos directamente; hay una serie de clases base que puede usar y que contienen implementaciones parciales para comenzar.

- File configuration provider

FileConfigurationProvider es la clase base para cargar la configuración desde el sistema de archivos. Los siguientes proveedores de configuración se derivan de FileConfigurationProvider:

    - Proveedor de configuración JSON
    - Proveedor de configuración XML
    - Proveedor de configuración INI


```cs
    public class YamlConfigurationProvider : FileConfigurationProvider
    {
        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            FileProvider = FileProvider ?? builder.GetFileProvider();
            return new YamlConfigurationProvider(this);
        }
    }
```

2. FileConfigurationSource Clase

Representa una clase base para un objeto IConfigurationSource basado en archivos. Entre algunas de sus propiedades se utiliza para acceder al contenido de archivos.

```cs
    public class YamlConfigurationSource : FileConfigurationSource
    {
        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            FileProvider = FileProvider ?? builder.GetFileProvider();
            return new YamlConfigurationProvider(this);
        }
    }
```

### Respuesta Correcta

#### **Caja No. 1**
    - Como se ve en el punto 1, la implementación de la interfase es necesaria, por eso Caja No. 1: FileConfigurationSource

#### **Caja No. 2**
    - Como se ve en el punto 2, la implementación de la interfase es necesaria, por eso Caja No. 2: FileConfigurationSource


### References :

- https://andrewlock.net/creating-a-custom-iconfigurationprovider-in-asp-net-core-to-parse-yaml/

- https://docs.microsoft.com/en-us/dotnet/core/extensions/configuration-providers

- https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.configuration.ini.iniconfigurationprovider?view=dotnet-plat-ext-5.0

