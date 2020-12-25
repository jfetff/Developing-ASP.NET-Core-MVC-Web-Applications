# Módulo 12: Desempeño y Comunicación

Siempre que la ruta a un archivo comience con *[Raíz del repositorio]*, reemplácela con la ruta absoluta a la carpeta en la que reside el repositorio 20486. Por ejemplo, si clonó o extrajo el repositorio 20486 en **C:\Users\John Doe\Downloads\20486**, cambiar el camino de: **[Repository Root]\AllFiles\20486D\Mod01** al **C:\Users\John Doe\Downloads\20486\AllFiles\20486D\Mod01**

Fichero de Instrucciones: Instructions\20486D_MOD012_LAK.md

Entregar el url de GitHub con la solución y un readme con las siguiente información:

1. **Nombres y apellidos:** José René Fuentes Cortez
2. **Fecha:** 24 de Diciembre 2020.
3. **Resumen del Modulo 12:** Este módulo consta de dos ejercicios:
    -  En el primer ejercio nos ayuda a entender como usar la metodología del ASP.NET Identity.
    - En el ejercicio 2 la práctica nos ayuda a entender como autorizar el acceso a aciones del controlador.


4. **Dificultad o problemas presentados y como se resolvieron:** Ninguna.

**NOTA**: Si no hay descripcion de problemas o dificultades, y al yo descargar el código para realizar la comprobacion y el código no funcionar, el resultado de la califaciación del laboratorio será afectado.

---

# Laboratorio: Desempeño y Comunicación

### Configuración del Lab

Tiempo estimado: **60 minutos**

### Pasos de Preparación

1. Asegúrate de que has clonado el directorio **20486D** de GitHub. Contiene los segmentos de código para los laboratorios y demostraciones de este curso. 
**(https://github.com/MicrosoftLearning/20486D-DevelopingASPNETMVCWebApplications/tree/master/Allfiles)**

2. En el Explorador de Archivos, navega a **[Repository Root]\Allfiles\Mod12\Labfiles\01_ElectricStore_begin\ElectricStore** y después copiarla en la dirección en la barra de direcciones.

3. Haz clic en **Start**, y luego escribe **cmd**.

4. En **Best match**, haz clic con el botón derecho del ratón en **Command Prompt**, y luego haz clic en **Run as administrator**.

5. En el cuadro de diálogo **Control de cuentas de usuario**, haga clic en **Sí**.

6. En el cuadro de diálogo **Administrador: Command Prompt**, escriba el siguiente comando y luego pulse Intro.
  ```cs
       cd {copied folder path}
  ```

>**Nota**: Si la *{pista de la carpeta copiada}* es diferente de la unidad de disco en la que se encuentra el símbolo del sistema, deberá escribir *{pista de disco}:* antes de escribir el comando **cd** *{pista de la carpeta copiada}*.

7. En el **Administrador: Command Prompt**, escriba el siguiente comando y, a continuación, pulse Intro.
  ```cs
       npm install
  ```
>**Nota**: Si se muestran mensajes de advertencia en la línea de comandos, puede ignorarlos.

8. Cierre la ventana.

9. En el Explorador de Archivos, navega a **[Repository Root]\Allfiles\Mod12\Labfiles\01_ElectricStore_begin**, y luego haz doble clic en **ElectricStore.sln**.

    >**Nota**: Si aparece un cuadro de diálogo de **Aviso de Seguridad para la Tienda Eléctrica**, verifica que la casilla de verificación **Pregúntame por cada proyecto de esta solución** esté despejada, y luego haz clic en **OK**.

10. En la ventana **Almacén Eléctrico - Microsoft Visual Studio**, en el menú **Herramientas**, haga clic en **Opciones**.

11. En el cuadro de diálogo **Opciones**, en la casilla **Opciones de búsqueda**, escriba **Gestión de paquetes web**, y luego pulse Intro.

12. En la lista **Ubicaciones de herramientas externas**, seleccione **$(PATH)**, haga clic en el botón **Flecha arriba** hasta que **$(PATH)** esté en la parte superior de la lista, y luego haga clic en **OK**.

13. En la ventana **ElectricStore - Microsoft Visual Studio**, en Solution Explorer, haga clic en **package.json**.

14. Examinar la ventana de código **package.json**.

      >**Nota**: Hay dependencias en los paquetes **jquery**, **jquery-validation**, **jquery-validation-unobtrusive**, **bootstrap** y **popper.js**.

15. En la ventana **ElectricStore - Microsoft Visual Studio**, en el menú **DEBUG**, haga clic en **Start Without Debugging**.

16. En Microsoft Edge, en la barra de direcciones, anote el número de puerto que aparece al final del URL **http://localhost:[port]**. Usarás el número de puerto durante este laboratorio.

17. En Microsoft Edge, haz clic en **Cerrar**.

### Ejercicio 1: Implementación de una estrategia de almacenamiento en caché

#### Tarea 1: Añadir un ayudante de la etiqueta de la caché a una vista

1. En la ventana **ElectricStore - Microsoft Visual Studio**, en el Solution Explorer, expandir **Views**, expandir **Shared**, y luego hacer clic en **_Layout.cshtml**.

2. En la ventana de código **_Layout.cshtml**, localice el siguiente código:
  ```cs
       <ul class="navbar-nav" id="nav-content">
       </ul>
  ```
3. Ponga el cursor antes del signo **<** (menos de) de la etiqueta **&lt;/ul&gt;**, pulse Intro, presione la tecla de flecha arriba y escriba el siguiente código:
  ```cs
       <cache vary-by-route="RefreshCache">
           @await Component.InvokeAsync("NavbarMenu")
       </cache>
  ```
#### Tarea 2: Insertar los datos que serán almacenados en la memoria caché por el ayudante de la etiqueta de la memoria caché


2. En la casilla **NewFolder**, escriba **ViewComponents**, y luego presione Enter.

3. En la ventana **ElectricStore - Microsoft Visual Studio**, en el Solution Explorer, haz clic con el botón derecho del ratón en **ViewComponents**, apunta a **Add**, y luego haz clic en **Class**.

4. En el cuadro de diálogo **Agregar nuevo elemento - Tienda Eléctrica**, en el cuadro **Nombre**, escriba **NavbarMenúVerComponentes**, y luego haga clic en **Agregar**.

5. En la ventana de código **NavbarMenuViewComponent.cs**, localice el siguiente código:
  ```cs
       using System.Threading.Tasks;
  ```

6. Ponga el cursor al final del código localizado, presione Enter, y luego escriba el siguiente código:
  ```cs
       using ElectricStore.Data;
       using Microsoft.AspNetCore.Mvc;
  ```

7. En la ventana del código **NavbarMenuViewComponent.cs**, localice el siguiente código:
  ```cs
       public class NavbarMenuViewComponent
  ```

8. Añada el siguiente código a la línea de código existente.
  ```cs
       : ViewComponent
  ```

9.	En la ventana de código **NavbarMenuViewComponent.cs**, coloque el cursor dentro del bloque de código **NavbarMenuViewComponent.cs**, y luego escriba el siguiente código:
  ```cs
       private StoreContext _context;

       public NavbarMenuViewComponent(StoreContext context)
       {
           _context = context;
       }

       public IViewComponentResult Invoke()
       {
           var categories = _context.menuCategories.OrderBy(c => c.Name).ToList();
           return View("MenuCategories", categories);
       }
  ```

10. En la ventana **ElectricStore - Microsoft Visual Studio**, en el Solution Explorer, en **Views**, haga clic con el botón derecho **Compartido**, apunte a **Add**, y luego haga clic en **Nueva Carpeta**.

11. En el cuadro **Nueva Carpeta**, escriba **Componentes**, y luego pulse Intro.

12. En la ventana **Tienda Eléctrica - Microsoft Visual Studio**, en el Explorador de soluciones, haga clic con el botón derecho del ratón en **Componentes**, apunte a **Agregar**, y luego haga clic en **Nueva carpeta**.

13. En el cuadro **Nueva Carpeta**, escriba **NavbarMenú**, y luego presione Enter.

14. En la ventana **Tienda Eléctrica - Microsoft Visual Studio**, en el Explorador de soluciones, haga clic con el botón derecho del ratón en **NavbarMenú**, apunte a **Agregar** y, a continuación, haga clic en **Nuevo elemento**.

15. En el cuadro de diálogo **Agregar nuevo elemento - ElectricStore**, haga clic en **Web**, y luego, en el panel de resultados, haga clic en **Razor View**.

16. En el cuadro de diálogo **Agregar nuevo artículo - ElectricStore**, en el cuadro **Nombre**, escriba **MenúCategorías**, y luego haga clic en **Agregar**.

17. En la ventana de código **MenuCategories.cshtml**, borra todo el contenido.

18. En la ventana **MenuCategories.cshtml** code, coloque el cursor al principio del documento, y luego escriba el siguiente código:

  ```cs
       @model IEnumerable<ElectricStore.Models.MenuCategory>

       <li class="nav-item">
           <a class="nav-link" href="@Url.Action("Index", "Products")">Home<span class="sr-only">(current)</span></a>
       </li>

       <li class="nav-item dropdown">
           <a class="nav-link dropdown-toggle" href="#" id="navbarDropdownMenuLink" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
               Electronics
           </a>
           <div class="dropdown-menu" aria-labelledby="navbarDropdownMenuLink">
               @foreach (var item in Model)
               {
                   <a class="dropdown-item" asp-action="GetByCategory" asp-controller="Products" asp-route-id="@item.Id">@Html.DisplayFor(modelItem => item.Name)</a>
               }
           </div>
       </li>

       <li class="nav-item">
           <a class="nav-link" href="@Url.Action("AddToShoppingList", "Products")">Add to Shopping List</a>
       </li>
       <li class="nav-item">
           <a class="nav-link" href="@Url.Action("Index", "ShoppingCart")">My Shopping Cart</a>
       </li>
       <li class="nav-item">
           <div class="display-cached-time">The content cached Since: @DateTime.Now</div>
       </li>
  ```


#### Tarea 3: Ejecutar la aplicación

1. En la ventana de **Electric Store - Microsoft Visual Studio**, en el menú **FILE**, haga clic en **Save All**.

2. En la ventana **Almacén Eléctrico - Microsoft Visual Studio**, en el menú **DEBUG**, haga clic en **Iniciar sin depuración**.

3. En la barra de tareas, haz clic con el botón derecho del ratón en el icono **Microsoft Edge**, y luego haz clic en **Nueva ventana**.

4. En la segunda ventana de **Microsoft Edge**, en la barra de direcciones, escribe **http://localhost:[port]**, y luego presiona Enter.

    >**Nota**: Examinar el contenido del navegador. La barra de menú de la aplicación está en caché desde la hora que aparece en la barra de menú; la hora es la misma en ambas páginas de **Microsoft Edge**.
    
5. En la barra de tareas, haga clic con el botón derecho del ratón en el icono **Borde de Microsoft** y luego haga clic en **Nueva ventana**.

6. En la tercera ventana de **Microsoft Edge**, en la barra de direcciones, escriba **http://localhost:[port]/products/index/1/RefreshCache**, y luego presione Enter.

    >**Nota**: La barra de menú de la aplicación está en caché desde la hora que aparece en la barra de menú; la hora no es la misma que las otras dos páginas de **Microsoft Edge** porque el **RefreshCache** de la ruta desencadena una recarga del componente de la vista.

7. Cierra todas las ventanas de **Microsoft Edge**.
 
#### Tarea 4: Insertar elementos en un cache de memoria

1. En la ventana **ElectricStore - Microsoft Visual Studio**, en el Solution Explorer, expandir **Controladores**, y luego hacer clic en **ProductsController.cs**.

2. En la ventana del código **ProductsController.cs**, localice el siguiente código:
  ```cs
       using Microsoft.EntityFrameworkCore;
  ```
3. Asegúrese de que el cursor esté al final del espacio de nombres **Microsoft.EntityFrameworkCore**, pulse Intro y luego escriba el siguiente código:
  ```cs
       using Microsoft.Extensions.Caching.Memory;
  ```

4. En el bloque de código **ProductsController.cs**, localiza el siguiente código:
  ```cs
       private StoreContext _context;
       private IHostingEnvironment _environment;
  ```

5. Ponga el cursor al final del código localizado, presione Enter, y luego escriba el siguiente código:
  ```cs
       private IMemoryCache _memoryCache;
       private const string PRODUCT_KEY = "Products";
  ```

6. En el bloque de código **ProductsController.cs**, seleccione el siguiente código:
  ```cs
       public ProductsController(StoreContext context, IHostingEnvironment environment)
       {
           _context = context;
           _environment = environment;
       }
  ```

7. Reemplazar el código seleccionado por el siguiente código:
  ```cs
       public ProductsController(StoreContext context, IHostingEnvironment environment, IMemoryCache memoryCache)
       {
           _context = context;
           _environment = environment;
           _memoryCache = memoryCache;
       }   
  ```

8. En el bloque de código **ProductsController.cs**, seleccione el siguiente código:
  ```cs
       public IActionResult Index()
       {
           return View();
       }
  ```

9. Reemplazar el código seleccionado por el siguiente código:
  ```cs
       public IActionResult Index()
       {
           List<Product> products;
           if (!_memoryCache.TryGetValue(PRODUCT_KEY, out products))
           {
               products = _context.Products.ToList();
               products.Select(c => { c.LoadedFromDatabase = DateTime.Now; return c; }).ToList();
               MemoryCacheEntryOptions cacheOptions = new MemoryCacheEntryOptions();
               cacheOptions.SetPriority(CacheItemPriority.High);
               _memoryCache.Set(PRODUCT_KEY, products, cacheOptions);
           }
           return View(products);
       }
  ```

10. En la ventana **ElectricStore - Microsoft Visual Studio**, en Solution Explorer, en **Views**, expandir **Products**, y luego hacer clic en **Index.cshtml**.

11. En la ventana **Index.cshtml** código, localiza el siguiente código:

  ```cs
       <h2 class="title">
           <img src="~/images/sale-banner.jpg" />
           <span class="span-col-s">Sale of The Day</span>
       </h2>
  ```

12. Coloque el cursor después del signo **>** (mayor que) de la etiqueta **&lt;/h2&gt;**, presione Enter dos veces, y luego escriba el siguiente código: 
  ```cs
       <div class="page-container">
           @foreach (var item in Model)
           {
               <div class="item">
                   <h3>
                       @Html.DisplayFor(modelItem => item.ProductName)
                   </h3>
                   @if (item.PhotoFileName != null)
                   {
                       <div>
                           <img src="@Url.Action("GetImage", "Products", new { productId = item.Id })" />
                       </div>
                   }
                       <div>
                           <p>
                               @Html.DisplayFor(model => item.Description)
                           </p>
                           <p>
                               @Html.DisplayFor(model => item.Price)
                           </p>
                       </div>
                       <div>
                           <p>
                               @Html.DisplayNameFor(model => item.LoadedFromDatabase)
                           </p>
                           <p>
                               @Html.DisplayFor(model => item.LoadedFromDatabase)
                           </p>
                       </div>
               </div>
           }
       </div>
  ```

#### Tarea 5: Ejecutar la aplicación

1. En la ventana de **Electric Store - Microsoft Visual Studio**, en el menú **FILE**, haga clic en **Save All**.

2. En la ventana **Almacén Eléctrico - Microsoft Visual Studio**, en el menú **DEBUG**, haga clic en **Iniciar sin depuración**.

    >**Nota**: Examinar los productos **Último recuperado en** datos.

3. En la barra de tareas, haga clic con el botón derecho del ratón en el icono **Microsoft Edge**, y luego haga clic en **Nueva ventana**.

4. En la segunda ventana de **Microsoft Edge**, en la barra de direcciones, escriba **http://localhost:[port]**, y luego presione Enter.

    >**Nota**: Al examinar el contenido del navegador, puede ver que los productos en el contenido de la página **"Venta del día "** están en caché, ya que la hora que se muestra en los datos de los productos **Último recuperado en** es idéntica en ambas páginas **Microsoft Edge**.

5. Cierra todas las ventanas de **Microsoft Edge**.

>**Resultados**: Después de completar este ejercicio, podrás implementar una estrategia de cacheo añadiendo un ayudante de etiqueta de cacheo a una vista, e insertar elementos en un cacheo de memoria. 

### Ejercicio 2: Administración del estado

#### Tarea 1: Permitir el trabajo con las sesiones

1. En la ventana **ElectricStore - Microsoft Visual Studio**, en el Explorador de soluciones, haga clic en **Startup.cs**.

2. En la ventana del código **Startup.cs**, localice el siguiente código:
  ```cs
       services.AddDbContext<StoreContext>(options =>
            options.UseSqlite("Data Source=electricStore.db"))
  ```

3. Asegúrate de que el cursor esté al final del código localizado, pulsa Enter dos veces, y luego escribe el siguiente código:
  ```cs
       services.AddSession(options =>
       {
           options.IdleTimeout = TimeSpan.FromSeconds(60);
       });
  ```

4. En la ventana del código **Startup.cs**, localiza el siguiente código:
  ```cs
       app.UseNodeModules(environment.ContentRootPath);
  ```

5. Asegúrate de que el cursor está al final del código localizado, pulsa Intro, y luego escribe el siguiente código:
  ```cs
       app.UseSession();
  ```

#### Tarea 2: Usar la sesión para almacenar valores

1. En la ventana **ElectricStore - Microsoft Visual Studio**, en el Solution Explorer, en **Controllers**, haga clic en **ProductsController.cs**.

2. En la ventana del código **ProductsController.cs**, localice el siguiente código:
  ```cs
       using Microsoft.Extensions.Caching.Memory;
  ```
3. Asegúrate de que el cursor está al final del espacio de nombres **Microsoft.Extensions.Caching.Memory**, presiona Enter, y luego escribe el siguiente código:
  ```cs
       using Microsoft.AspNetCore.Http;
       using Newtonsoft.Json;
  ```
4. En el bloque de código **ProductsController.cs**, seleccione el siguiente código:

  ```cs
       [HttpPost, ActionName("AddToShoppingList")]
       public IActionResult AddToShoppingListPost(Customer customer)
       {
           if (ModelState.IsValid)
           {
               _context.Customers.Add(customer);
               _context.SaveChanges();
               return RedirectToAction(nameof(Index));
           }
           PopulateProductsList(customer.SelectedProductsList);
           return View(customer);
       }
  ```


5. Reemplazar el código seleccionado por el siguiente código:
  ```cs
        [HttpPost, ActionName("AddToShoppingList")]
        public IActionResult AddToShoppingListPost(Customer customer)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("CustomerFirstName", customer.FirstName);
                HttpContext.Session.SetString("CustomerLastName", customer.LastName);
                HttpContext.Session.SetString("CustomerEmail", customer.Email);
                HttpContext.Session.SetString("CustomerAddress", customer.Address);
                HttpContext.Session.SetInt32("CustomerPhoneNumber", customer.PhoneNumber);
                if (HttpContext.Session.GetString("CustomerProducts") != null)
                {
                    List<int> productsListId = JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("CustomerProducts"));
                    customer.SelectedProductsList.AddRange(productsListId);
                }
                var serialisedDate = JsonConvert.SerializeObject(customer.SelectedProductsList);
                HttpContext.Session.SetString("CustomerProducts", serialisedDate);
                return RedirectToAction(nameof(Index));
            }
            PopulateProductsList(customer.SelectedProductsList);
            return View(customer);
        }
  ```

#### Tarea 3: Recuperar los valores de una sesión

1. En la ventana **ElectricStore - Microsoft Visual Studio**, en el Solution Explorer, en **Controllers**, haga clic en **ProductsController.cs**.

2. En el bloque de código **ProductsController.cs**, seleccione el siguiente código:
  ```cs
        [HttpGet]
        public IActionResult AddToShoppingList()
        {
            PopulateProductsList();
            return View();
        }
  ```

3. Reemplazar el código seleccionado por el siguiente código:
  ```cs
        [HttpGet]
        public IActionResult AddToShoppingList()
        {
            if (HttpContext.Session.GetString("CustomerFirstName") != null)
            {
                Customer sessionCustomer = new Customer()
                {
                    FirstName = HttpContext.Session.GetString("CustomerFirstName"),
                    LastName = HttpContext.Session.GetString("CustomerLastName"),
                    Email = HttpContext.Session.GetString("CustomerEmail"),
                    Address = HttpContext.Session.GetString("CustomerAddress"),
                    PhoneNumber = HttpContext.Session.GetInt32("CustomerPhoneNumber").Value,
                };
                PopulateProductsList();
                return View(sessionCustomer);
            }
            PopulateProductsList();
            return View();
        }
  ```

4. En la ventana **ElectricStore - Microsoft Visual Studio**, en el Solution Explorer, en **Controllers**, haga clic en **ShoppingCartController.cs**.

5. En la ventana del código **ShoppingCartController.cs**, localice el siguiente código:
  ```cs
      using Microsoft.AspNetCore.Mvc;
  ```
6. Asegúrate de que el cursor está al final del espacio de nombres **Microsoft.AspNetCore.Mvc**, presiona Enter, y luego escribe el siguiente código:
  ```cs
      using ElectricStore.Data;
      using ElectricStore.Models;
      using Microsoft.AspNetCore.Http;
      using Newtonsoft.Json;
  ```
7. En el bloque de código **ShoppingCartController.cs**, localice el siguiente código:
  ```cs
      public IActionResult Index()
      {
           return View();
      }
  ```
8. Coloca el cursor antes del código localizado, pulsa Intro, pulsa la tecla de flecha arriba, escribe el siguiente código y luego pulsa Intro.
  ```cs
      private StoreContext _context;
      private List<Product> products;
      private SessionStateViewModel sessionModel;

      public ShoppingCartController(StoreContext context)
      {
          _context = context;
      }
  ```
9. En el bloque de código **ShoppingCartController.cs**, en el bloque de código de acción **Index**, seleccione el siguiente código:
  ```cs
      return View();
  ```
10. Reemplace el código seleccionado por el siguiente código:

  ```cs
      if (!string.IsNullOrEmpty(HttpContext.Session.GetString("CustomerFirstName")) && !string.IsNullOrEmpty(HttpContext.Session.GetString("CustomerProducts")))
      {
          List<int> productsListId = JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("CustomerProducts"));
          products = new List<Product>();
          foreach (var item in productsListId)
          {
              var product = _context.Products.SingleOrDefault(p => p.Id == item);
              products.Add(product);
          }
          sessionModel = new SessionStateViewModel
          {
              CustomerName = HttpContext.Session.GetString("CustomerFirstName"),
              SelectedProducts = products
          };
          return View(sessionModel);
      }
      return View();
  ```

#### Tarea 4: Ejecutar la aplicación

1. En la ventana de **Electric Store - Microsoft Visual Studio**, en el menú **FILE**, haga clic en **Save All**.

2. En la ventana **Almacén Eléctrico - Microsoft Visual Studio**, en el menú **DEBUG**, haga clic en **Iniciar sin depuración**.

3. En la barra de menú, haga clic en **Mi Cesta de la Compra**.

    >**Nota**: Examinar el contenido del navegador.

4. En la barra de menú, haga clic en **Agregar a la lista de compras**.

5. En la página **Agregar productos a la lista de compras**, en la lista **Lista de productos**, seleccione _&lt;Productos de su elección&gt;._

6. En la página **Agregar productos a la lista de compras**, en el cuadro **Nombre**, escriba _&lt;Un nombre de pila de su elección&gt;._

7. En la página **Agregar productos a la lista de compras**, en el recuadro **Apellido**, escriba _&lt;Un apellido de su elección&gt;._

8. En la página **Agregar productos a la lista de compras**, en el cuadro **Dirección**, escriba _&lt;Una dirección de su elección&gt;._

9. En la página **Agregar productos a la lista de compras**, en la casilla **Email**, escriba _&lt;Un correo electrónico de su elección&gt;._

10. En la página **Agregar productos a la lista de compras**, en el cuadro **Teléfono**, escriba _&lt;Un número de teléfono de su elección&gt;._ y luego haga clic en **Agregar a la lista de compras**.

11. En la barra de menú, haz clic en **Mi Cesta de la compra**.

    >**Nota**: Examine el contenido del navegador. El navegador muestra el contenido del archivo **ShoppingCart.cshtml**, renderizado por **_Layout.cshtml**, y el contenido en caché son los productos que usted seleccionó en la página **"Agregar productos a la lista de compras "**.

12. En la barra de menú, haga clic en **Agregar a la lista de compras**.

    >**Nota**: Examine el contenido del navegador. El navegador muestra su información personal almacenada en la memoria caché.

13. En la página **Agregar productos a la lista de compras**, en la lista **Lista de productos**, seleccione _&lt;Productos de su elección&gt;._ de nuevo, y luego haga clic en **Agregar a la lista de compras**.

14. En la barra de menú, haz clic en **Mi cesta de la compra**.

    >**Nota**: Examine el contenido del navegador. El producto que seleccionó en la segunda selección también aparece en la lista almacenada en caché de los productos que había seleccionado en el pasado.

15. En la barra de tareas, haga clic con el botón derecho del ratón en el icono **Borde de Microsoft** y luego haga clic en **Nueva ventana**.

16. En la segunda ventana de **Microsoft Edge**, en la barra de direcciones, escriba **http://localhost:[port]**, y luego presione Enter.

17. En la barra de menú, haz clic en **Mi Cesta de la compra**.

    >**Nota**: Examinar el contenido del navegador. La lista de productos no se muestra porque está vacía. La sesión se guarda sólo en el navegador original.

18. Cierra todas las ventanas de **Microsoft Edge**.

>**Resultados**: Después de completar este ejercicio, podrá gestionar el estado trabajando con las sesiones. 

### Ejercicio 3: Comunicación de dos vías 

#### Tarea 1: Añadir una clase de SignalR Hub llamada ChatHub

1. En la ventana **ElectricStore - Microsoft Visual Studio**, en el Explorador de soluciones, haga clic con el botón derecho en **ElectricStore**, apunte a **Add**, y luego haga clic en **New Folder**.

2. En el cuadro **Nueva Carpeta**, escriba **Hubes**, y luego presione Enter.

3. En la ventana **Almacén Eléctrico - Microsoft Visual Studio**, en el Explorador de soluciones, haga clic con el botón derecho del ratón en **Hubs**, señale a **Agregar**, y luego haga clic en **Clase**.

4. En el cuadro de diálogo **Agregar nuevo elemento - ElectricStore**, en el cuadro **Nombre**, escriba **ChatHub**, y luego haga clic en **Agregar**.

5. En la ventana del código **ChatHub.cs**, localiza el siguiente código:
  ```cs
       using System.Threading.Tasks;
  ```
6. Ponga el cursor al final del código localizado, presione Enter, y luego escriba el siguiente código:
  ```cs
       using Microsoft.AspNetCore.SignalR;
  ```

7. En la ventana del código **ChatHub.cs**, seleccione el siguiente código:
  ```cs
       public class ChatHub
  ```

8. Añada el siguiente código a la línea de código existente.
  ```cs
       : Hub
  ```

9. En la ventana del código **ChatHub.cs**, coloca el cursor dentro del bloque de código **ChatHub.cs**, y luego escribe el siguiente código:
  ```cs
       public async Task SendMessageAll(string user, string message)
       {
           await Clients.All.SendAsync("NewMessage", user, message);
       }
  ```

#### Tarea 2: Configurar SignalR en la clase de inicio

1. En la ventana **ElectricStore - Microsoft Visual Studio**, en el Explorador de soluciones, haga clic en **Startup.cs**.

2. En la ventana del código **Startup.cs**, localice el siguiente código:
  ```cs
       using Microsoft.Extensions.DependencyInjection;
  ```
3. Asegúrate de que el cursor está al final del espacio de nombres **Microsoft.Extensions.DependencyInjection**, presiona Enter, y luego escribe el siguiente código:
  ```cs
       using ElectricStore.Hubs;
  ```

4. En la ventana del código **Startup.cs**, localiza el siguiente código:

  ```cs
       services.AddSession(options =>
       {
           options.IdleTimeout = TimeSpan.FromSeconds(60);
       });
  ```


5. Asegúrate de que el cursor esté al final del código localizado, pulsa Enter dos veces, y luego escribe el siguiente código:
  ```cs
       services.AddSignalR();
  ```

6. En la ventana del código **Startup.cs**, localice el siguiente código:
  ```cs
       app.UseSession();
  ```

7. Asegúrate de que el cursor esté al final del código localizado, pulsa Enter dos veces, y luego escribe el siguiente código:
  ```cs
       app.UseSignalR(routes =>
       {
           routes.MapHub<ChatHub>("/chatHub");
       });
  ```

8. En la ventana **ElectricStore - Microsoft Visual Studio**, en Solution Explorer, haga clic en **package.json**.

9. En la ventana **package.json** code, seleccione el siguiente código:
  ```cs
       "popper.js": "1.14.4"
  ```

10. Reemplace el código seleccionado por el siguiente código:
  ```cs
       "popper.js": "1.14.4",
       "@aspnet/signalr": "1.0.0"
  ```

#### Tarea 3: Añadir una vista de chat

1. En la ventana **ElectricStore - Microsoft Visual Studio**, en el Solution Explorer, en **Controllers**, haga clic en **ShoppingCartController.cs**.

2. Asegúrate de que el cursor está al final del bloque de código de acción **Index**, pulsa Intro dos veces, y luego escribe el siguiente código:
  ```cs
       public IActionResult Chat()
       {
       
  ```
3. En el bloque de código de acción **Chat**, escriba el siguiente código:
  ```cs
       return View();
  ```
4. En la ventana del código **ShoppingCartController.cs**, haga clic con el botón derecho del ratón en el siguiente código y luego haga clic en **Add View**.
  ```cs
       public IActionResult Chat()
  ```

5. En el cuadro de diálogo **Añadir vista de MVC**, asegúrate de que el valor en el cuadro **Nombre de la vista** es **Chat**.

6. En el cuadro de diálogo **Agregar vista MVC**, asegúrese de que la plantilla **Vacío (sin modelo)** esté seleccionada.

7. En el cuadro de diálogo **Agregar vista MVC**, asegúrese de que la casilla de verificación **Crear como una vista parcial** está desactivada y la casilla de verificación **Utilizar una página de diseño** está seleccionada y, a continuación, haga clic en **Agregar**.

8. En la ventana de código **Chat.cshtml**, seleccione el siguiente código:
  ```cs
       <h2>Chat</h2>
  ```
9. Reemplazar el código seleccionado por el siguiente código:
  ```cs
       <h2 class="title">
           <span>Chat with</span>
           <span class="chat-title">Online Site Visitors</span>
       </h2>

       <div class="chat">
           <div class="row justify-content-center">
               <div class="col-2 bcf">
                   <div class="col-5">
                       Name: <input type="text" id="inputUserName" />
                   </div>
                   <div class="col-sm-5">
                       Message: <input type="text" id="inputMessage" />
                   </div>
                   <div class="col-sm-3">
                       <input class="btn btn-info" type="submit" id="sendMessageBtn" value="Send Message" />
                   </div>
               </div>
               <div class="col-2 bcs">
                   <ul id="messagesList"></ul>
               </div>
           </div>
       </div>
  ``` 
10. Coloque el cursor después del signo **>** (mayor que) de la última etiqueta **&lt;/div...**, presione Enter dos veces, y luego escriba el siguiente código: 
  ```cs
       @section Scripts {
           <script src="~/node_modules/@@aspnet/signalr/dist/browser/signalr.js"></script>
       }
  ```

11. En la ventana **ElectricStore - Microsoft Visual Studio**, en Solution Explorer, en **Views**, expandir **ShoppingCart**, y luego hacer clic en **Index.cshtml**.

12. En la ventana **Index.cshtml** código, localizó el siguiente código:

  ```cs
       else
       {
           <div class="title Secondary-heading">
               <p>Sorry, we don't have any information yet</p>
               <p>Please go to the <span class="span-col-s">Shopping List page</span></p>
               <p>and select the wanted products.</p>
           </div>
       }
  ```

13. Ponga el cursor al final del código localizado, presione Enter y luego escriba el siguiente código:
  ```cs
       <button type="button" id="btnChat" class="btn btn-success" onclick="location.href='@Url.Action("Chat", "ShoppingCart")'">Chat with Online Visitors</button>
  ```

#### Tarea 4: Escribir el código JavaScript para conectarse al servidor

1. En la ventana **ElectricStore - Microsoft Visual Studio**, en el Solution Explorer, haga clic con el botón derecho **wwwwroot**, apunte a **Add**, y luego haga clic en **New Folder**.

2. En el cuadro **Nueva Carpeta**, escriba **js**, y luego pulse Intro.

3. En la ventana **ElectricStore - Microsoft Visual Studio**, en el Solution Explorer, en **wwwwroot**, haga clic con el botón derecho **js**, señale a **Add**, y luego haga clic en **Existing Item**.

4. En el cuadro de diálogo **Add Existing Item - ElectricStore**, ve a **[Repository Root]\NAllfiles\Mod12\Labfiles\NElectricStoreJS**, selecciona el archivo **chat-hub.js**, y luego haz clic en **Add**.

5. En la ventana de **ElectricStore - Microsoft Visual Studio**, en Solution Explorer, en **Views**, en **ShoppingCart**, haz clic en **Chat.cshtml**.

6. En la ventana del código **Chat.cshtml**, seleccione el siguiente código:
  ```cs
       @section Scripts {
           <script src="~/node_modules/@@aspnet/signalr/dist/browser/signalr.js"></script>
       }
  ```

7. Reemplazar el código seleccionado por el siguiente código:
  ```cs
       @section Scripts {
           <script src="~/node_modules/@@aspnet/signalr/dist/browser/signalr.js"></script>
           <script src="~/js/chat-hub.js"></script>
       }
  ```

#### Tarea 5: Ejecutar la aplicación

1. En la ventana de **Electric Store - Microsoft Visual Studio**, en el menú **FILE**, haga clic en **Save All**.

2. En la ventana **Almacén Eléctrico - Microsoft Visual Studio**, en el menú **DEBUG**, haga clic en **Iniciar sin depuración**.

3. En la barra de menú, haga clic en **Mi Cesta de la Compra**.

5. En la página de **Mi Carro de Compras**, haga clic en **Chatear con los visitantes en línea**.

6. En la barra de tareas, haz clic con el botón derecho del ratón en el icono **Borde de Microsoft**, y luego haz clic en **Nueva ventana**.

7. En la segunda ventana de **Microsoft Edge**, en la barra de direcciones, escribe **http://localhost:[port]/ShoppingCart/Chat**, y luego presiona Enter.

8. En la segunda **Ventana de Microsoft Edge**, en la casilla **Nombre**, escriba _&lt;Un nombre de su elección&gt;._

9. En Microsoft Edge, en la casilla **Mensaje**, escriba _&lt;Un mensaje de su elección&gt;._ y luego presione **Enviar mensaje**.

    >**Nota**: En ambas ventanas de **Borde de Microsoft**, aparece el mensaje.

10. En la primera ventana de **Microsoft Edge**, en el cuadro **Nombre**, escriba _&lt;Un nombre de su elección&gt;._

11. En la primera ventana **Edge de Microsoft**, en el cuadro **Mensaje**, escriba _&lt;Un mensaje de su elección&gt;._ y luego haga clic en **Enviar mensaje**.

    >**Nota**: En ambas ventanas de **Edge de Microsoft**, el mensaje aparece.

12.  Cierre todas las ventanas de **Edge de Microsoft**.

13.  En la ventana **ElectricStore - Microsoft Visual Studio**, en el menú **FILE**, haz clic en **Salir**.

>**Resultados**: Después de completar este ejercicio, debería haber creado una tienda eléctrica en la que los usuarios puedan ver los detalles de los productos, pedir algunos también y chatear con los visitantes del sitio en línea.

