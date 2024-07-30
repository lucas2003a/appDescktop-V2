# Funciones
Las funciones se pueden definir como bloques de c�digo que realizan tareas espec�ficas dentro de una aplicaci�n, generalmente en respuesta a eventos como la carga de un formulario o el clic en un bot�n. <br>
El uso de funciones en el desarrollo de aplicaciones permite separar la l�gica en unidades m�s peque�as y manejables. Esto no solo facilita el mantenimiento y la depuraci�n del c�digo, sino que tambi�n promueve la reutilizaci�n del c�digo y mejora la legibilidad.<br>

A las funciones asociadas a una clase u objeto se les dice **M�TODOS**. 
Un m�todo es esencialmente una funci�n que opera sobre los datos de la instancia de la clase (o sobre la propia clase, en el caso de m�todos est�ticos), y est� definido dentro de una clase.

Existen dos tipos de funciones:
- Funciones sin retorno (void)
	```csharp
		public class Persona()
		{
			//Este m�todo solo imprime un saludo en la consola
			//No tiene un retorno, por eso es void
			public void Saludar()
			{
				Console.WriteLine("Hola mundo");
			}
		}
	```
- Funciones con retorno
	```csharp
		public class Persona()
		{
	
			public Persona()
			{
				//Llamada al m�todo saludar y captura de su valor de retorno
				string saludo = Saludar();
				Console.WriteLine(saludo);
			}

			public string Saludar()
			{
				string saludo = "Hola mundo";
				return saludo; //Valor de retorno del tipo string
			}
		}
	```

## Estructura de una funci�n
![Estructura de una funci�n](../res/img/structure_functions.jpg)

## Par�metros y argumentos en una funci�n
En la programaci�n, **par�metros** y **argumentos** son dos conceptos muy importantes, y aunque parezcan muy similares,
la clave para diferenciarlos est� en su implementaci�n en las funciones.

- **Los par�metros**:
    Son variables definidas en la creaci�n del m�todo o funci�n.
	Act�an como referencia a un valor cuando la funci�n es llamada.
	```csharp
		public void Saludar(string name)
		{
			//name es un par�metro del m�todo Saludar()
			Console.WriteLine($"Hola {name}");
		}
	```
- **Los argunentos**:
    Son los valores enviado al invocar o llamar una funci�n, estos valores se asignan a los par�metros definidos en la funci�n.
	```csharp
		public class Persona()
		{
			public Persona()
			{
				string nameText = "Juan" //nameText es un argumento
				Saludar(nameText)        //nameText es enviado como argumento al m�todo Saludar()
			}

			public void Saludar(string name)
			{
				//name es un par�metro del m�todo Saludar()
				Console.WriteLine($"Hola {name}");
			}
		}
	```