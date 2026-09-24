using Arreglos.Logica;

        Console.WriteLine("Arreglos\n");
//--------------------------------------------------------------
//MiArreglo oMyArreglo = new(5);
//oMyArreglo.Agregar(3);
//oMyArreglo.Agregar(5);
//oMyArreglo.Agregar(7);

//oMyArreglo.Insertar(2, 0);

//Console.WriteLine(oMyArreglo);

//Console.WriteLine("----------------------------------------------------------");
//oMyArreglo.Eliminar(1);
//Console.WriteLine(oMyArreglo);
//try
//{
//    for(int i = 0; i < oMyArreglo.N; i++)
//    {
//       oMyArreglo.Agregar(i*6);
//    }
//    oMyArreglo.Agregar(6);
//    Console.WriteLine(oMyArreglo);

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);

//}

//Console.ReadKey();
//  ------------------------------------------------------------

MiArreglo oMyarreglo = new(100);
oMyarreglo.Llenar();
oMyarreglo.ToString();

Console.WriteLine("\nArreglo desordenado");
Console.WriteLine(oMyarreglo.ToString());

Console.WriteLine("\nArreglo ordenado");
oMyarreglo.Ordenar();
Console.WriteLine(oMyarreglo.ToString());

Console.WriteLine("\nArreglo ordenado ascendente");
oMyarreglo.Ordenar();
Console.WriteLine(oMyarreglo.ToString());


Console.WriteLine("\nArreglo ordenado descendente");
oMyarreglo.Ordenar(false);
Console.WriteLine(oMyarreglo.ToString());
Console.ReadKey();
