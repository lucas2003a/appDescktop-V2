# Arrays
Los "arrays" o "arreglos" son tipo de estructura de datos, una colección de elementos del mismo tipo que se caracteriza 
por acceder a cada uno de ellos indicando su posición dentro del array, a esto se le conoce como **índices**.

Para inicializar un array, tenemos dos formas:
- Forma 1:
    ```csharp
        //string        => El tipo de dato de los elementos del array
        //[]            => Indica que es un array
        //courses       => Nombre del array
        //new string[5] => Indica la cantidad de elementos que contendrá el array
	
        string[] courses = new string[5];

        //Agregando elementos
        courses[0] = "HTML";
        courses[1] = "CSS";
        courses[2] = "JavaScript";
        courses[3] = "Python";
        courses[4] = "PHP";
        //courses[5] = "C#"; //Esto lanzará una excepción 
        //ya que al inicializar el array indicamos que solo contendría 5 elementos
    ```

- Forma 2:
    
    ```csharp
        string[] courses = {"HTML", "CSS", "JavaScript", "Python", "PHP"};

        //Agregando elementos
        courses[0] = "HTML";
        courses[1] = "CSS";
        courses[2] = "JavaScript";
        courses[3] = "Python";
        courses[4] = "PHP";
        //courses[5] = "C#"; //Esto lanzará una excepción 
        //ya que la posición de ese elemento, en el array no existe
    ``` 
    ```csharp
        //Resultado: ["HTML","CSS","JavaScript","Python","PHP"];
    ```  

## Recorrido de un array con el bucle For
```csharp
    string[] courses =
    {
        "HTML", 
        "CSS", 
        "JavaScript", 
        "Python", 
        "PHP"
    };

    LiCourses.Items.Clear();

    //El primer indice de un array inicia en 0, por lo tanto nuestro contador también.
    //Para que el bucle se ejecute para todos los elementos del array menos 1 usamos array.Length
    //courses.Length = 5

    for (int i = 0; i < courses.Length; i++)
    {
        LiCourses.Items.Add(courses[i]);
    }
```