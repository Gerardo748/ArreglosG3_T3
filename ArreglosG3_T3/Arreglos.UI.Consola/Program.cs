using Arreglos.Logica;

Console.WriteLine("Hello, World!");

MiArreglo oMyArreglo = new MiArreglo(10);
oMyArreglo.Llenar(1,100);

//oMyArreglo.ToString();
Console.WriteLine(oMyArreglo);
Console.WriteLine("\narreglo desordenado");
Console.WriteLine(oMyArreglo);
Console.ReadKey();
