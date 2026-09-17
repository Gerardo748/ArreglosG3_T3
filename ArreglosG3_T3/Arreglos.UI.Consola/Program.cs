using Arreglos.Logica;

Console.WriteLine("Arreglos");
MiArreglo oMyarreglo = new(10);
oMyarreglo.Llenar(1, 10);
oMyarreglo.ToString();
Console.WriteLine("\nArreglo desordenado");
Console.WriteLine(oMyarreglo.ToString());
Console.WriteLine("\nArreglo ordenado");
oMyarreglo.Ordenar();
Console.WriteLine(oMyarreglo.ToString());
Console.ReadKey();
