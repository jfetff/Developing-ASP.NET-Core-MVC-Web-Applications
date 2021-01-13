# QUESTION 174

You are developing an ASP.NET MVC application. The application uses a SQL Server database and a SQL Server login and password.

You need to ensure that the password for the SQL Server login is not stored in plain text.

Which two actions should you perform? Each correct answer presents part of the solution.

NOTE: Each correct selection is worth one point.

    A. Encrypt the connection string by using aspnet_wp.exe.
    B. Encrypt the connection string by using aspnet_regiis.exe.
    C. Ensure that there is a valid encryptionKey element in the web.config file.
    D. Ensure that there is a valid machineKey element in the web.config file.


## Explicación:

SQL Server en sí mismo no cifra ni descifra los datos, sólo se cifra y descifra en tránsito.

1. ASPNET_WP.EXE es una implementación del proceso de trabajo ASP.NET que se ejecuta en IIS 5. W3WP.EXE que se ejecuta en IIS 6 es otra implementación.

Todos los procesos de trabajo, incluido ASPNET_WP.EXE, alojan .NET Framework y el tiempo de ejecución de asp.net. Todas las solicitudes cuyo recurso de destino es un recurso específico de asp.net, como .aspx, .asmx, son pasadas por IIS 5 al proceso ASPNET_WP.EXE. Cada aplicación virtual tiene un AppDomain dedicado y todos estos AppDomains están contenidos en el proceso aspnet_wp.exe. Una vez que se recicla el proceso aspnet_wp.exe, también se reciclan todos los dominios de aplicación que contiene. Pero si uno de los dominios de aplicaciones se recicla, esto no afecta a otros dominios de aplicaciones ni al proceso de trabajo de alojamiento.


2. aspnet_regiis.exe 
    - Actualiza las asignaciones de documentos para corregir la versión de aspnet_isapi.dll. 
    - Actualiza la versión de ASP.NET desde inetmgr la misma que aspnet_regiis.
    - Proporciona cualquier enlace que sepa que detalla los pasos de aspnet_regiis.exe
    - Para cifrar los datos, se debe utilizar una utilidad de línea de comandos llamada aspnet_regiis.exe que existe en la carpeta del framework. Hay dos opciones que funcionan para el cifrado, -pe y -pef. Por ejemplo, el siguiente comando cifra la sección **<connectionStrings>** del archivo Web.config para una aplicación llamada MyApplication.
    
```cs
    aspnet_regiis -pe "connectionStrings" -app "/MyApplication"
```
3. Una vez que la identidad de su aplicación ASP.NET tiene acceso de lectura al contenedor de claves RSA para el objeto RsaProtectedConfigurationProvider predeterminado, esta cifrará las secciones del archivo Web.config para su aplicación ASP.NET utilizando ese contenedor de claves. Luego, ASP.NET descifra las secciones cuando procesa el archivo Web.config.


4. El machineKey element - esta en la web ASP.NET. y el archivo configweb. Este especifica el algoritmo y las claves que ASP.NET utilizará para el cifrado. De forma predeterminada, las claves de validationKey y decryptionKey están configuradas en AutoGenerate, lo que significa que el tiempo de ejecución generará una clave aleatoria para su uso. Pero solo especificar el algoritmo no determina que sea necesario, ya que siempre hay valores predeterminados.


### Respuesta Correcta

#### **Opción B y Opción C**



### References :

- https://docs.microsoft.com/en-us/previous-versions/aspnet/dtkwfdky(v%3Dvs.100)#encrypting-sections-of-the-webconfig-file

- https://codewithshadman.com/machine-key-generator/#:~:text=What%20Is%20Machine%20Key%3F,a%20random%20key%20for%20use.
