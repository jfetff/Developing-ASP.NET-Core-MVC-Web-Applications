# QUESTION 163

**Note:** This question is part of a series of questions that present the same scenario. Each question in the series contains a unique solution that might meet the stated goals. Some questions sets might have more than one correct solution, while others might not have a correct solution.

After you answer a question in this section, you will NOT be able to return to it. As a result, these questions will not appear in the review screen.

You are developing an ASP.NET Core MVC web application. The landing page of the application contains over 100 small JPEG images, including many images that have embedded text.

Mobile device users report performance issues when loading the landing page. You debug the application and determine that the number of HTTP requests is causing the issue.
You need to improve the performance of the landing page.

Solution: Update the web server to use HTTP/2.

Does the solution meet the goal?




## Respuesta: SI

El número de solicitudes http debe ser el mismo. Sin embargo, solo usarán una conexión TCP, lo que mejorará el rendimiento.
El Objetivo es mejorar el rendimiento de cargar la página de inicio, lo cual se logrará la página al usar HTTP/2, por lo que la respuesta correcta debe ser SÍ.
https://blog.cloudflare.com/introducing-http2/



### Respuesta Correcta

#### **SI**



### References :

- https://blog.cloudflare.com/introducing-http2/



