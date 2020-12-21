# Módulo 4: Creación de clases e implementación de colecciones de tipo seguro

# Laboratorio: Adición de validación de datos y seguridad de tipos a la aplicación


Tiempo estimado:** 75 minutos **

## Pasos de preparación

Entregar el url de GitHub con la solución y un readme con las siguiente información:

1. **Nombres y apellidos:** José René Fuentes Cortez
2. **Fecha:** 15 de Octubre 2020.
3. **Resumen del Modulo 4:** Este módulo consta de cuatro ejercicios:
    -  En el primer ejercio nos ayuda a completar las estructuras **Teacher**. **Student** y **Grade** se implementarán como clases y estas llamarán al método **VerifyPassword** cuando el usuario inicia sesión.
    - En el ejercicio 2 hacemos la validación para que la clase **Grades** contenga la lógica de validación. Para ello creamos un proyecto paralelo que ejecuta pruebas unitarias por los diferentes métodos para estar seguros que todo marcha bien.
    - En el ejercicio 3 modificamos el código de la aplicación para que muestre a los estudiantes en orden alfabético, según los apellidos y luego los nombres.
    - En el ejercicio 4 hacemos que la aplicación permita a los maestros agregar y quitar estudiantes de sus clases y agregar calificaciones a los estudiantes.


4. **Dificultad o problemas presentados y como se resolvieron:** Ninguna.

**NOTA**: Si no hay descripcion de problemas o dificultades, y al yo descargar el código para realizar la comprobacion y el código no funcionar, el resultado de la califaciación del laboratorio será afectado.

---
---

## Configuración del Lab


Asegúrese de haber clonado el directorio 20483C de GitHub. Contiene los segmentos de código para los laboratorios y demostraciones de este curso. (**https: //github.com/MicrosoftLearning/20483-Programming-in-C-Sharp/tree/master/Allfiles**)

## Ejercicio 1: Implementación de las estructuras de profesor, alumno y grado como clases

### Tarea 1: Convertir la estructura Grades en una clase

1. Haga clic en **Visual Studio 2019**.
2. En **Visual Studio**. en el menú **Archivo**. seleccione **Abrir** y luego haga clic en **Proyecto/Solución**.
3. En el cuadro de diálogo **Abrir proyecto**. busque **[Repository Root]\Allfiles\Mod04\Labfiles\Starter\Exercise 1**. haga clic en **GradesPrototype.sln** y luego haga clic en **Abrir**.
    > **Nota:** Si aparece algún cuadro de diálogo de advertencia de seguridad, desactive la casilla de verificación **Preguntarme por cada proyecto en esta solución** y luego haga clic en **Aceptar**.
4. En el menú **Ver**. haga clic en **Lista de tareas**.
5. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Ejercicio 1: Tarea 1a: Convertir calificación en una clase y definir constructores**.
6. En el editor de código, debajo del comentario, modifique la declaración **public struct Grade**. reemplazando **struct** con **class**.
    ```cs
    public class Grade
    ```
7. Haga clic al final del código **public string Comments { get; set; }**. presione Entrar dos veces y luego escriba el siguiente código:

    ```cs
    // Constructor to initialize the properties of a new Grade
    public Grade(int studentID, string assessmentDate, string subject, string
    assessment, string comments)
    {
        StudentID = studentID;
        AssessmentDate = assessmentDate;
        SubjectName = subject;
        Assessment = assessment;
        Comments = comments;
    }

    // Default constructor
    public Grade()
    {
        StudentID = 0;
        AssessmentDate = DateTime.Now.ToString("d");
        SubjectName = "Math";
        Assessment = "A";
        Comments = String.Empty;
    }
    ```

### Tarea 2: Convertir las estructuras de Estudiantes y Profesores en clases

1. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 1: Task 2a: Convert Student into a class, make the password property write-only, add the VerifyPassword method, and define constructors*.
2. En el editor de código, debajo del comentario, modifique la declaración **public struct Student**. reemplazando **struct** con **class**.
    ```cs
    public class Student
    ```
3. Elimine la siguiente línea de código de la clase **Student**.
    ```cs
    public string Password {get; set;}
    ```
4. Presione Entrar y luego escriba el siguiente código:
    ```cs
    private string _password = Guid.NewGuid().ToString(); // Generate a random password by default

    public string Password
    {
        set
        {
            _password = value;
        }
    }

    public bool VerifyPassword(string pass)
    {
        return (String.Compare(pass, _password) == 0);
    }
    ```
    > **Nota **Una aplicación no debería poder leer passwords; solo configúrelos y verifique que la password sea correcta.
5. Haga clic al final del código **public string LastName { get; set; }**. presione Entrar dos veces y luego escriba el siguiente código:
    ```cs
    // Constructor to initialize the properties of a new Student
    public Student(int studentID, string userName, string password, string   firstName,   string lastName, int teacherID)
    {
       StudentID = studentID;
       UserName = userName;
       Password = password;
       FirstName = firstName;
       LastName = lastName;
       TeacherID = teacherID;
    }

    // Default constructor
    public Student()
    {
       StudentID = 0;
       UserName = String.Empty;
       Password = String.Empty;
       FirstName = String.Empty;
       LastName = String.Empty;
       TeacherID = 0;
    }
    ```
6. En la ventana **Lista de tareas**. haga doble clic en tarea **TODO: Exercise 1: Task 2b: Convert Teacher into a class, make the password property write-only, add the VerifyPassword method, and define constructors**.
7. En el editor de código, debajo del comentario, modifique la declaración **public struct Teacher**. reemplazando **struct**con **class**.
    ```cs
    public class Teacher
    ```
8. Elimine la siguiente línea de código:
   ```cs
    public string Password {get; set;},
    ```
9. Presione Entrar y luego escriba el siguiente código:
    ```cs
    private string _password = Guid.NewGuid().ToString(); // Generate a random password by default

    public string Password
    {
        set
        {
            _password = value;
        }
    }

    public bool VerifyPassword(string pass)
    {
        return (String.Compare(pass, _password) == 0);
    }
    ```
10. Haga clic al final del código **public string Class {get; set;}**. presione Entrar dos veces y luego escriba el siguiente código:
    ```cs
    // Constructor to initialize the properties of a new Teacher
    public Teacher(int teacherID, string userName, string password, string firstName, string lastName, string className)
    {
        TeacherID = teacherID;
        UserName = userName;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        Class = className;
    }

    // Default constructor
    public Teacher()
    {
        TeacherID = 0;
        UserName = String.Empty;
        Password = String.Empty;
        FirstName = String.Empty;
        LastName = String.Empty;
        Class = String.Empty;
    }
    ```

### Tarea 3: Utilice el método VerifyPassword para verificar la password cuando un usuario inicia sesión

1. En la ventana **Lista de tareas**. haga doble clic en tarea **TODO: Exercise 1: Task 3a: Use the VerifyPassword method of the Teacher class to verify the teacher’s password**.
2. En el editor de código, debajo del comentario, en el código de la variable del profesor, modifique el código **String.Compare (t.Password, password.Password) == 0** para que se vea como el siguiente código:
    ```cs
    t.VerifyPassword(password.Password)
    ```
3. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 1: Task 3b: Check whether teacher is null before examining the UserName property**.
4. En el editor de código, en la línea debajo del comentario, modifique la condición de declaración **if** de **!String.IsNullOrEmpty(teacher.UserName)** para que se parezca al siguiente código:
    ```cs
    teacher != null && !String.IsNullOrEmpty(teacher.UserName)
    ```
5. En la ventana **Lista de tareas**. haga doble clic en **TODO: Exercise 1: Task 3c: Use the VerifyPassword method of the Student class to verify the student’s password**.
6. En el editor de código, debajo del comentario, en el código de la variable de estudiante, modifique el código **String.Compare (s.Password, password.Password) == 0** para que se vea como el siguiente código:
    ```cs
    s.VerifyPassword(password.Password)
    ```
7. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 1: Task 3d: Check whether student is null before examining the UserName property**.
8. En el editor de código, en la línea debajo del comentario, modifique la condición de declaración **if** de **! String.IsNullOrEmpty (student.UserName)** para que se parezca al siguiente código:
    ```cs
    student != null && !String.IsNullOrEmpty(student.UserName)
    ```

### Tarea 4: compila y ejecuta la aplicación y verifica que un profesor o un alumno aún pueda iniciar sesión

1. En el menú **Crear**. haga clic en **Crear solución**.
2. En el menú **Depurar**. haga clic en **Iniciar sin depurar**.
3. En el cuadro de texto **Nombre de usuario**. escriba **vallee**.


- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-1-StudentPage.jpg "The Students page")

4. En el cuadro de texto **Password**. escriba **password** y luego haga clic en **Iniciar sesión**.
5. Verifique que aparezca la pantalla de bienvenida, mostrando la lista de estudiantes.
6. Haga clic en **Cerrar sesión**.
7. En el cuadro de texto **Nombre de usuario**. elimine el contenido existente, escriba **grubere** y luego haga clic en **Iniciar sesión**.

- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-2-grubere.jpg "Eric Grubere Students page")

8. Verifique que aparezca la pantalla de bienvenida, mostrando la lista de materias y calificaciones.
9. Haga clic en **Cerrar sesión**.
10. Cierre la aplicación.
11. En el menú **Archivo**. haga clic en **Cerrar solución**.

 > **Resultados:** Después de completar este ejercicio, las estructuras **Teacher**. **Student** y **Grade **se implementarán como clases y se llamará al método **VerifyPassword **cuando se el usuario inicia sesión.

## Ejercicio 2: Agregar validación de datos a la clase de calificación

### Tarea 1: Crea una lista de nombres de materias válidos

1. En **Visual Studio**. en el menú **Archivo**. seleccione **Abrir** y luego haga clic en **Proyecto/Solución**.
2. En el cuadro de diálogo **Abrir proyecto**. busque **[Repository Root]\Allfiles\Mod04\Labfiles\Starter\Exercise 2**. haga clic en **GradesPrototype.sln** y luego haga clic en **Abrir**.
    > **Nota:** Si aparece algún cuadro de diálogo de advertencia de seguridad, desactive la casilla de verificación **Preguntarme por cada proyecto en esta solución** y luego haga clic en **Aceptar**.
3. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 2: Task 1a: Define a List collection for holding the names of valid subjects**.
    En el editor de código, en la línea en blanco debajo del comentario, escriba el siguiente código:
    ```cs
    public static List<string> Subjects;
    ```
4. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 2: Task 1b: Populate the list of valid subjects with sample data**.
5. En el editor de código, en la línea en blanco debajo del comentario, escriba el siguiente código:
    ```cs
    Subjects = new List<string>() { "Math", "English", "History", "Geography",  "Science" };
    ```

### Tarea 2: Agregar lógica de validación a la clase de grado para verificar los datos ingresados ​​por el usuario

1. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 2: Task 2a: Add validation to the AssessmentDate property**.
2. En el editor de código debajo del comentario, elimine el **public string AssessmentDate { get; set; }** código y, a continuación, escriba el siguiente código:
    ```cs
    private string _assessmentDate;

    public string AssessmentDate
    {
        get
        {
            return _assessmentDate;
        }

        set
        {
            DateTime assessmentDate;

            // Verify that the user has provided a valid date
            if (DateTime.TryParse(value, out assessmentDate))
            {
                // Check that the date is no later than the current date
                if (assessmentDate > DateTime.Now)
                {
                    // Throw an ArgumentOutOfRangeException if the date is after the current date
                    throw new ArgumentOutOfRangeException("AssessmentDate", "Assessment date must be on or before the current date");
                }

                // If the date is valid, then save it in the appropriate format
                _assessmentDate = assessmentDate.ToString("d");
            }
            else
            {
                // If the date is not in a valid format then throw an ArgumentException
                throw new ArgumentException("AssessmentDate", "Assessment date is not recognized");
            }
        }
    }
    ```
3. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 2: Task 2b: Add validation to the SubjectName property**.
4. En el editor de código, debajo del comentario, elimine el código **public string SubjectName { get; set; }**  y, a continuación, escriba el siguiente código:
    ```cs
    private string _subjectName;

    public string SubjectName
    {
        get
        {
            return _subjectName;
        }

        set
        {
            // Check that the specified subject is valid
            if (DataSource.Subjects.Contains(value))
            {
                // If the subject is valid store the subject name
                _subjectName = value;
            }
            else
            {
                // If the subject is not valid then throw an ArgumentException
                throw new ArgumentException("SubjectName", "Subject is not recognized");
            }
        }
    }
    ```
5. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 2: Task 2c: Add validation to the Assessment property**.
6. En el editor de código, elimine el código **public string Assessment { get; set; }** y, a continuación, escriba el siguiente código:
    ```cs
    private string _assessment;

    public string Assessment
    {
        get
        {
            return _assessment;
        }

        set
        {
            // Verify that the grade is in the range A+ to E-
            // Use a regular expression: a single character in the range A-E at the start of the string followed by an optional + or – at the end of the string
            Match matchGrade = Regex.Match(value, @"[A-E][+-]?$");

            if (matchGrade.Success)
            {
                _assessment = value;
            }
            else
            {
                // If the grade is not valid then throw an ArgumentOutOfRangeException
                throw new ArgumentOutOfRangeException("Assessment", "Assessment grade must be in the range of A+ to E-");
            }
        }
    }
    ```

### Tarea 3: Agregar una prueba unitaria para verificar que las validaciones definidas para la clase de grado funcionan como se esperaba

1. En el menú **Archivo**. seleccione **Agregar** y luego haga clic en **Nuevo proyecto**.
2. En el cuadro de diálogo **Agregar nuevo proyecto**. en la lista de plantillas **Instaladas**. expanda **Visual C\#**. haga clic en **Prueba** y luego en **Plantillas **lista, haga clic en **Unit Test Project (.NET Framework)**.
   > **Nota:** En la ventana **Agregar nuevo proyecto**. asegúrese de que**.NET Framework 4.7 **esté seleccionado en la barra superior.
3. En el cuadro de texto **Nombre**. escriba **GradesTest** y luego haga clic en **Aceptar**.
4. En **Explorador de soluciones**. haga clic con el botón derecho en **GradesTest**. haga clic en **Agregar** y luego haga clic en **Referencia**.
5. En el cuadro de diálogo **Reference Manager – GradesTest**. expanda **Proyectos** y luego haga clic en **Solución**.
6. Seleccione la casilla de verificación **GradesPrototype** y luego haga clic en **Aceptar**.
7. En el editor de código, en la clase **UnitTest1**. elimine todo el código existente y luego escriba el siguiente código:
    ```cs
    [TestInitialize]
    public void Init()
    {
    // Create the data source (needed to populate the Subjects collection)
    GradesPrototype.Data.DataSource.CreateData();
    }

    [TestMethod]
    public void TestValidGrade()
    {
        GradesPrototype.Data.Grade grade = new GradesPrototype.Data.Grade(1, "01/01/2012", "Math", "A-", "Very good");
        Assert.AreEqual(grade.AssessmentDate, "01/01/2012");
        Assert.AreEqual(grade.SubjectName, "Math");
        Assert.AreEqual(grade.Assessment, "A-");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestBadDate()
    {
        // Attempt to create a grade with a date in the future
        GradesPrototype.Data.Grade grade = new GradesPrototype.Data.Grade(1, "1/1/2023", "Math", "A-", "Very good");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestDateNotRecognized ()
    {
        // Attempt to create a grade with an unrecognized date
        GradesPrototype.Data.Grade grade = new GradesPrototype.Data.Grade(1, "13/13/2012", "Math", "A-", "Very good");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestBadAssessment()
    {
        // Attempt to create a grade with an assessment outside the range A+ to E-
        GradesPrototype.Data.Grade grade = new GradesPrototype.Data.Grade(1, "1/1/2012", "Math", "F-", "Terrible");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestBadSubject()
    {
        // Attempt to create a grade with an unrecognized subject
        GradesPrototype.Data.Grade grade = new GradesPrototype.Data.Grade(1, "1/1/2012", "French", "B-", "OK");
    }
    ```
8. En el menú **Crear**. haga clic en **Crear solución**.
9. En el menú **Prueba**. seleccione **Ejecutar** y luego haga clic en **Todas las pruebas**.
10. En la ventana **Explorador de pruebas**. verifique que se hayan aprobado todas las pruebas.

- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-3-Pruebas.jpg "Ejecutando las pruebas unitarias de los métodos !!")

11. Cierre **Explorador de pruebas**.
12. En el menú **Archivo**. haga clic en **Cerrar solución**.

> **Resultados:** Después de completar este ejercicio, la clase de **Grades** contendrá la lógica de validación.

## Ejercicio 3: Visualización de estudiantes en orden de nombre

### Tarea 1: Ejecuta la aplicación y verifica que los estudiantes no se muestren en ningún orden específico cuando inician sesión como profesor

1. En **Visual Studio**. en el menú **Archivo**. seleccione **Abrir** y luego haga clic en **Proyecto/Solución**.
2. En el cuadro de diálogo **Abrir proyecto**. busque **[Repository Root]\Allfiles\Mod04\Labfiles\Starter\Exercise 3**. haga clic en **GradesPrototype.sln**. y luego haga clic en **Open**.
    > **Nota:** Si aparece algún cuadro de diálogo de advertencia de seguridad, desactive la casilla de verificación **Preguntarme por cada proyecto en esta solución** y luego haga clic en **Aceptar**.
3. En el menú **Crear**. haga clic en **Crear solución**.
4. En el menú **Depurar**. haga clic en **Iniciar sin depurar**.
5. En el cuadro de texto **Nombre de usuario**. escriba **vallee**.
6. En el cuadro de texto **password**. escriba **password** y luego haga clic en **Iniciar sesión**.
7. Verifique que los estudiantes no se muestren en ningún orden específico.


- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-4-vallee.jpg "Estudiantes sin Orden !!")


8. Cierre la aplicación.

## Tarea 2: Implementar la interfaz IComparable\<Student \> para permitir la comparación de estudiantes

1. En la ventana **Lista de tareas**. haga doble clic en **TODO: Exercise 3: Task 2a: Specify that the Student class implements the IComparable\<Student\> interface**.
2. En el editor de código, haga clic en al final de la declaración **public class Student** y, a continuación, escriba el siguiente código:
    ```cs
    : IComparable<Student>
    ```
3. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 3: Task 2b: Compare Student objects based on their LastName and FirstName properties**.
4. En el editor de código, en la línea en blanco debajo del comentario, escriba el siguiente código:
    ```cs
    // Compare Student objects based on their LastName and FirstName properties
    public int CompareTo(Student other)
    {
        // Concatenate the LastName and FirstName of this student
        string thisStudentsFullName = LastName + FirstName;

        // Concatenate the LastName and FirstName of the "other" student
        string otherStudentsFullName = other.LastName + other.FirstName;

        // Use String.Compare to compare the concatenated names and return the result
        return(String.Compare(thisStudentsFullName, otherStudentsFullName));
    }
    ```

## Tarea 3: Cambiar la colección ArrayList de Estudiantes a una colección List\<Student \>

1. En la ventana **Lista de tareas**. haga doble clic en **TODO: Exercise 3: Task 3a: Change the Students collection into a List\<Student\>**.
2. En el editor de código, debajo del comentario, modifique el código **Public static ArrayList Students;** para que se vea como el siguiente código:
    ```cs
    public static List<Student> Students;
    ```
3. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 3: Task 3b: Populate the List\<Student\> collection**.
4. En el editor de código, debajo del comentario, modifique el código **Students = new ArrayList ()** para que se parezca al siguiente código:
    ```cs
    Students = new List<Student>()
    ```

## Tarea 4: Ordenar los datos en la colección de Estudiantes

1. En la ventana **Lista de tareas**. haga doble clic en **TODO: Exercise 3: Task 4a: Sort the data in the Students collection**.
2. En el editor de código, haga clic al final de la línea de comentarios, presione Entrar y luego escriba el siguiente código:
    ```cs
    DataSource.Students.Sort();
    ```

## Tarea 5: Verificar que se obtienen los Estudiantes y se muestren en el orden de su nombre y apellido

1. En el menú **Crear**. haga clic en **Crear solución**.
2. En el menú **Depurar**. haga clic en **Iniciar sin depurar**.
3. En el cuadro de texto **Nombre de usuario**. escriba **vallee**.
4. En el cuadro de texto **password**. escriba **password** y luego haga clic en **Iniciar sesión**.
5. Verifique que los estudiantes se muestren en orden alfabético, según sus apellidos.

- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-5-StudentOrdered.jpg "Estudiantes ordenados por su apellidos !!")

6. Cierre la sesión y luego cierre la aplicación.
7. En el menú **Archivo**. haga clic en **Cerrar solución**.

> **Resultados:** Después de completar este ejercicio, la aplicación mostrará a los estudiantes en orden alfabético, según los apellidos y luego los nombres.

# Ejercicio 4: Permitir que los profesores modifiquen los datos de clases y calificaciones

## Tarea 1: Cambiar las colecciones de profesores y calificaciones para que sean colecciones de listas genéricas

1. En **Visual Studio**. en el menú **Archivo**. seleccione **Abrir** y luego haga clic en **Proyecto/Solución**.
2. En el cuadro de diálogo **Abrir proyecto**. vaya a **[Repository Root]\Allfiles\Mod04\Labfiles\Starter\Exercise 4**. haga clic en **GradesPrototype.sln** y luego haga clic en **Abrir**.
    > **Nota:** Si aparece algún cuadro de diálogo de advertencia de seguridad, desactive la casilla de verificación **Preguntarme por cada proyecto en esta solución** y luego haga clic en **Aceptar**.
3. En la ventana **Lista de tareas**. haga doble clic en **TODO: Exercise 4: Task 1a: Change the Teachers collection into a generic List**.
4. En el editor de código, debajo del comentario, modifique el código **public static ArrayList Teachers;** para que se vea como el siguiente código:
    ```cs
    public static List<Grade> Grades;
    ```
5. En la ventana **Lista de tareas**. haga doble clic en **TODO: Exercise 4: Task 1b: Change the Grades collection into a generic List**.
6. En el editor de código, debajo del comentario, modifique el código **public static ArrayList Grades;** para que se parezca al siguiente código:
    ```cs
    public static List<Grade> Grades;
    ```
7. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 4: Task 1c: Populate the Teachers collection**.
8. En el editor de código, debajo del comentario, modifique el código **Teachers = new ArrayList ()** para que se parezca al siguiente código:
    ```cs
    Teachers = new List<Teacher>()
    ```
9. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 4: Task 1d: Populate the Grades collection**.
10. En el editor de código, debajo del comentario, modifique el código **Grades = new ArrayList ()** para que se parezca al siguiente código:
    ```cs
    Grades = new List<Grade>()
    ```

## Tarea 2: Agregar los métodos EnrollInClass y RemoveFromClass para la clase del profesor

1. En la ventana **Lista de tareas**. haga doble clic en **TODO: Exercise 4: Task 2a: Enroll a student in the class for this teacher**.
2. En el editor de código, haga clic en la línea en blanco debajo del comentario y luego escriba el siguiente código:
    ```cs
    public void EnrollInClass(Student student)
    {
        // Verify that the student is not already enrolled in another class
        if (student.TeacherID == 0)
        {
            // Set the TeacherID property of the student
            student.TeacherID = TeacherID;
         }
         else
         {
            // If the student is already assigned to a class, throw an  ArgumentException
            throw new ArgumentException("Student", "Student is already assigned to a class");
         }
    }
    ```
3. En la ventana **Lista de tareas**. haga doble clic en **TODO: Exercise 4: Task 2b: Remove a student from the class for this teacher**.
4. En el editor de código, haga clic en al final de la línea de comentarios, presione Entrar y luego escriba el siguiente código:
    ```cs
    // Remove a student from the class for this teacher
    public void RemoveFromClass(Student student)
    {
       // Verify that the student is actually assigned to the class for this teacher
       if (student.TeacherID == TeacherID)
       {
           // Reset the TeacherID property of the student
           student.TeacherID = 0;
       }
       else
       {
           // If the student is not assigned to the class for this teacher, throw an ArgumentException
           throw new ArgumentException("Student", "Student is not assigned to this class");
       }
    }
    ```
5. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 4: Task 2c: Add a grade to a student (the grade is already populated)**.
6. En el editor de código, haga clic en al final de la línea de comentarios, presione Entrar y luego escriba el siguiente código:
    ```cs
    // Add a grade to a student (the grade is already populated)
    public void AddGrade(Grade grade)
    {
       // Verify that the grade does not belong to another student – the StudentID  should be zero
       if (grade.StudentID == 0)
       {
          // Add the grade to the student’s record
          grade.StudentID = StudentID;
        }
        else
        {
            // If the grade belongs to a different student, throw an ArgumentException
            throw new ArgumentException("Grade", "Grade belongs to a different  student");
        }
    }
    ```

## Tarea 3: agregar código para inscribir a un alumno en la clase de un profesor

1. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 4: Task 3a: Enroll a student in the teacher’s class**.
2. En el editor de código, debajo del comentario, haga clic en la línea en blanco del método **Student_Click** y luego escriba el siguiente código:
    ```cs
    try
    {
        // Determine which student the user clicked
        // the StudentID is held in the Tag property of the Button that the user    clicked
        Button studentClicked = sender as Button;
        int studentID = (int)studentClicked.Tag;

        // Find this student in the Students collection
        Student student = (from s in DataSource.Students
                           where s.StudentID == studentID
                           select s).First();

        // Prompt the user to confirm that they wish to add this student to their class
        string message = String.Format("Add {0} {1} to your class?", student.FirstName,  student.LastName);
        MessageBoxResult reply = MessageBox.Show(message, "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);

        // If the user confirms, add the student to their class
        if (reply == MessageBoxResult.Yes)
        {
            // Get the ID of the currently logged-on teacher
            int teacherID = SessionContext.CurrentTeacher.TeacherID;

            // Assign the student to this teacher’s class
            SessionContext.CurrentTeacher.EnrollInClass(student);

            // Refresh the display – the new assigned student should disappear from     the list of unassigned students
            Refresh();
         }
    }
    catch (Exception ex)
    {
          MessageBox.Show(ex.Message, "Error enrolling student", MessageBoxButton.OK, MessageBoxImage.Error);
    }
    ```
3. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 4: Task 3b: Refresh the display of unassigned students**.
4. En el editor de código, debajo del comentario, haga clic en la línea en blanco del método **Refresh** y luego escriba el siguiente código:
    ```cs
    // Find all unassigned students - they have a TeacherID of 0
    var unassignedStudents = from s in DataSource.Students
                             where s.TeacherID == 0
                             select s;

    // If there are no unassigned students, then display the "No unassigned students" message
    // and hide the list of unassigned students
    if (unassignedStudents.Count() == 0)
    {
        txtMessage.Visibility = Visibility.Visible;
        list.Visibility = Visibility.Collapsed;
    }
    else
    {
         // If there are unassigned students, hide the "No unassigned students" message
         // and display the list of unassigned students
         txtMessage.Visibility = Visibility.Collapsed;
         list.Visibility = Visibility.Visible;

          // Bind the ItemControl on the dialog to the list of unassigned students
          // The names of the students will appear in the ItemsControl on the dialog
          list.ItemsSource = unassignedStudents;
    }
    ```
5. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 4: Task 3c: Enroll a student in the teacher’s class**.
6. En el editor de código, debajo del comentario, haga clic en la línea en blanco en el método **EnrollStudent_Click** y luego escriba el siguiente código:
    ```cs
    // Use the AssignStudentDialog to display unassigned students and add them to the teacher’s class
    // All of the work is performed in the code behind the dialog
    AssignStudentDialog asd = new AssignStudentDialog();
    asd.ShowDialog();

    // Refresh the display to show any newly enrolled students
    Refresh();
    ```

## Tarea 4: Agregar código para permitir que un profesor elimine al alumno de la clase asignada

1. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 4: Task 4a: Enable a teacher to remove a student from a class**.
2. En el editor de código, debajo del comentario, haga clic en la línea en blanco en el método **Remove_Click** y luego escriba el siguiente código:
    ```cs
    // If the user is not a teacher, do nothing (the button should not appear anyway)
    if (SessionContext.UserRole != Role.Teacher)
    {
       return;
    }

    try
    {
        // If the user is a teacher, ask the user to confirm that this student should be removed from their class
        string message = String.Format("Remove {0} {1}", SessionContext.CurrentStudent.FirstName, SessionContext.CurrentStudent.LastName);
        MessageBoxResult reply = MessageBox.Show(message, "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);

        // If the user confirms, then call the RemoveFromClass method of the current teacher to remove this student from their class
        if (reply == MessageBoxResult.Yes)
        {
            SessionContext.CurrentTeacher.RemoveFromClass(SessionContext.CurrentStudent);

            // Go back to the previous page – the student is no longer a member of the class for the current teacher
            if (Back != null)
            {
                 Back(sender, e);
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Error removing student from class", MessageBoxButton.OK, MessageBoxImage.Error);
    }
    ```

## Tarea 5: Agregar código para permitir que un maestro agregue una calificación a un estudiante

1. En la ventana **Lista de tareas**. haga doble clic en la tarea **TODO: Exercise 4: Task 5a: Enable a teacher to add a grade to a student**.
2. En el editor de código, debajo del comentario, haga clic en la línea en blanco en el método **AddGrade_Click** y luego escriba el siguiente código:

```cs
    // If the user is not a teacher, do nothing (the button should not appear anyway)
    if (SessionContext.UserRole != Role.Teacher)
    {
        return;
    }

    try
    {
        // Use the GradeDialog to get the details of the assessment grade
        GradeDialog gd = new GradeDialog();

        // Display the form and get the details of the new grade
        if (gd.ShowDialog().Value)
        {
            // When the user closes the form, retrieve the details of the assessment    grade from the form
            // and use them to create a new Grade object
            Grade newGrade = new Grade();
            newGrade.AssessmentDate = gd.assessmentDate.SelectedDate.Value.ToString ("d");
            newGrade.SubjectName = gd.subject.SelectedValue.ToString();
            newGrade.Assessment = gd.assessmentGrade.Text;
            newGrade.Comments = gd.comments.Text;

            // Save the grade to the list of grades
            DataSource.Grades.Add(newGrade);

            // Add the grade to the current student
            SessionContext.CurrentStudent.AddGrade(newGrade);

            // Refresh the display so that the new grade appears
            Refresh();
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Error adding assessment grade", MessageBoxButton.OK, MessageBoxImage.Error);
    }
```

## Tarea 6: Ejecuta la aplicación y verifica que los estudiantes se puedan agregar y quitar de las clases, y que las calificaciones se puedan agregar a los estudiantes

1. En el menú **Crear**. haga clic en **Crear solución**.
2. En el menú **Depurar**. haga clic en **Iniciar sin depurar**.
3. En el cuadro de texto **Nombre de usuario**. escriba **vallee**.
4. En el cuadro de texto **password**. escriba **password** y luego haga clic en **Iniciar sesión**.
5. Haga clic en **New Student**.

- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-6-AddStudent.jpg "Agregando a un nuevo estudiante !!")

6. En el cuadro de texto **Nombre**. escriba **Darren**.
7. En el cuadro de texto **Apellido**. escriba **Parker**.
8. En el cuadro de texto **Password**. escriba **password** y luego haga clic en **Aceptar**.
9. Haga clic en **Enroll Student**.
10. Verifique que aparezca el cuadro de diálogo **Asignar estudiante** y que **Darren Parker** esté en la lista.

- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-7-Darren.jpg "Agregando a un nuevo estudiante !!")

11. Haga clic en **Darren Parker**.

12. Verifique que aparezca el cuadro de mensaje **Confirmar** y luego haga clic en **Sí**.

- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-8-Confirmation.jpg "Caja de dialogo de confirmación !!")

13. En el cuadro de diálogo **Asignar alumno**. verifique que **Darren Parker** desaparezca y que se muestre el texto **No hay alumnos sin asignar**.

- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-9-Unassigned.jpg "Caja de dialogo de no hay alumnos para assignar !!")

14. Haga clic en **Cerrar**.
15. Verifique que **Darren Parker** se agregue a la lista de estudiantes.

- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-10-DarrenAgregado.jpg "Nuevo estudiante agregado !!")

16. Haga clic en el estudiante **Kevin Liu**.

- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-11-Kevin.jpg "Mostrando el estudiante Kevin !!")

17. Haga clic en **Eliminar alumno**.
18. Verifique que aparezca el cuadro de mensaje **Confirmar** y luego haga clic en **Sí**.
19. Verifique que **Kevin Liu** se elimine de la lista de estudiantes.

- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-12-KevinBorrado.jpg "Estudiante borrado !!")

20. Haga clic en el estudiante **Darren Parker**.
21. Haga clic en **Agregar calificación**.


- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-13-AddGrade.jpg "Agregar calificación a un estudiante !!")


22. Verifique que aparezca el cuadro de diálogo **Detalles de nueva calificación**.
23. Verifique que el cuadro de texto **Fecha** contenga la fecha actual.
24. En la lista **Asunto**. haga clic en **Inglés**.
25. En el cuadro de texto **Evaluación**. escriba **B**.
26. En el cuadro de texto **Comentarios**. escriba **Bueno** y luego haga clic en **Aceptar**.

- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-14-NewGrade.jpg "Nueva calificación a un estudiante !!")

27. Verifique que la información de las calificaciones aparezca en la boleta de calificaciones.

- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-15-ReportCard.jpg "Nueva calificación a un estudiante !!")

28. Haga clic en **Cerrar sesión**.
29. En el cuadro de texto **Nombre de usuario**. escriba **parkerd**.
30. Haga clic en **Iniciar sesión**.
31. Verifique que se muestre la pantalla **Bienvenido Darren Parker** que muestra el boleta de calificaciones y la calificación agregada anteriormente.
- El resultado visual del ejercicio anterior se muestra en la siguiente imagen:

 ![alt text](./Images/Fig-16-DarrenReportCard.jpg "Verificación de calificación para un estudiante !!")

32. Haga clic en **Cerrar sesión**.
33. Cierre la aplicación.
34. En **Visual Studio**. en el menú **Archivo**. haga clic en **Cerrar solución**.

> **Resultados:** Después de completar este ejercicio, la aplicación permitirá a los maestros agregar y quitar estudiantes de sus clases y agregar calificaciones a los estudiantes.