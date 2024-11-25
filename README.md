# WorkFinderQU
Solucion al ejercicio planteado por la compañia Qu, se creo una solucion con dos proyecto una aplicacion de consola construida en .Net 8 y un proyecto de pruebas unitarias usando Xunit como framework
## WorkFinderQu Console Project
Lee una matrix y las palabras a buscar dentro de esa matriz dentro de la carpeta **Inputs** ![image](https://github.com/user-attachments/assets/42e82528-9188-419e-99c6-36f41309bf06) y usa un algoritmo de busqueda binaria para encontrar coincidencias, si no existe un prefijo dentro de las palabras a buscar se detiene y continua con la siguiente posicion dentro de un array bidimensional para minimizar el impacto en la busqueda.

Contiene tres clases:  
### ManageFiles.cs: 
lee los archivos de la ruta y retorna un array de strings con las lineas leidas  
### ValidateMatrix.cs:  
Valida que la estructura de la matrix este acorde a las reglas definidas y sea rectangular  
### WordFinder.cs:  
Encargada de la construccion del algoritmo de busqueda  
### Program.cs:  
realiza los llamados necesarios y retorna por consola las 10 palabras mas encontradas  

## WorkFinderQu.Test Project
Utiliza xUnit para construir el testeo de la clase **ValdiateMatrix** para el metodo **isValid** utilizando AAA  

![image](https://github.com/user-attachments/assets/a82da218-185a-4ad3-9e16-3fbdf84f2e7d)


# Requisitos Previos
.NET 8 SDK
Sistema operativo compatible con .NET (Windows, macOS, Linux).
