# QUESTION 159

### DRAG DROP
You are developing an ASP.NET Core web application in Microsoft Visual Studio. The project uses a file named package.json in reusable packages.
You must automate the build process to use a script minification strategy. Script minification must happen in parallel.
You need to ensure you can share and distribute packages and run the minification strategy.
Which tools should you use? To answer, drag the appropriate tools to the correct scenarios. Each tool may be used once, more than once, or not at all. You may need to drag the split bar between panes or scroll to view content.
NOTE: Each correct selection is worth one point.

Respuesta:

### Primero tenemos que crear un proyecto
1. Primero, crearemos una carpeta llamada proyecto a servidor como raíz de nuestro proyecto a medida que avanzamos en este tutorial. Para ello tenemos que ejecutar el comando npm init desde dentro del directorio del ejercicio:

![alt text](images/Fig-0.jpg "Mostrando el directorio del proyecto")


2. Tenemos que ejecutar el comando npm para crear el proyecto siguiente:

```
  $ npm init
```
![alt text](images/Fig-1.jpg "Mostrando la creación del proyecto en el directorio del proyecto")

El comando npm init crea un archivo package.json para su proyecto que almacena información sobre el proyecto, como las dependencias utilizadas en el proyecto (Gulp es un ejemplo de una dependencia).

3. Una vez que se crea el archivo package.json, podemos instalar Gulp en el proyecto usando el siguiente comando:

```
  $ npm install gulp --save-dev
```

![alt text](images/Fig-2.jpg "Mostrando la creación del proyecto en el directorio del proyecto")


4. Creamos el archivo **gulpfile.js** en la raíz del directorio del proyecto:


![alt text](images/Fig-3.jpg "Mostrando la creación del archivo 'gulpfile.js' en el directorio del proyecto")


5. Escribir una tarea Gulp. Para ello:

- Definimos una variable: **var gulp = require('gulp');**
- Creamos una tarea: 

```
    gulp.task('nombre-de-la-tarea', function() {
    // algún código aquí
    });
```
- Probando la tarea, creamos la tarea 'hola':

```
    gulp.task('hola', function() {
     console.log('Hola Rene, ¿cómo estás?');
    });
```

![alt text](images/Fig-4.jpg "Creación de una tarea en el archivo 'gulpfile.js' en el directorio del proyecto")


- Ejecutando la tarea 'hola':

```
    gulp hola
```

![alt text](images/Fig-5.jpg "Ejecución de la tarea creada en el archivo 'gulpfile.js' en el directorio del proyecto")


6. Podemos usar gulp-sass para crear una tarea que sea destinada a compilar Sass en CSS, llamémoslo sass.

```
    gulp.task('sass', function(){
    return gulp.src('source-files')
        .pipe(sass()) // Using gulp-sass
        .pipe(gulp.dest('destination'))
    });
```

### Respuesta

#### Target 1: npm
#### Target 2: Gulp