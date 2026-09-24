using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos.Logica
{
    public class MiArreglo
    {
        //campos o atributos
        private int _tope;
        private int[] _arreglo;
        //constructor
        public MiArreglo(int n)
        {
            N = n;
            _arreglo = new int[n];
            _tope = 0;
        }
        //propiedades
        public int N { get; }

        public bool EstaLeno => _tope == N;
        public bool EstaVacio => _tope == 0;
        //metodos
        public void Llenar()
        { 
            Llenar(1, 100);
        }
        //metodo llenar con parametros
        public void Llenar(int minimo, int maximo)
        {
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = random.Next(minimo, maximo);

            }
            _tope = N;
        }
        //metodo ordenenar (Burbuja)
        public void Ordenar()
        { 
            Ordenar(true);
        }
        public void Ordenar(bool ascendente)
        {

            for (int i = 0; i < _tope - 1; i++)
            {
                for (int j = i + 1; j < _tope; j++)
                {
                    if (ascendente)
                    {
                        if (_arreglo[i] > _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                    else
                    {
                        if (_arreglo[i] < _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }

                }
            }
        }

        //metodo Caambiar
        public void Cambiar(ref int a, ref int b)
        {
            int auxiliar = a;
            a = b;
            b = auxiliar;
        }
        //Metodoagregar
        public void Agregar(int numero)
        {
            if (EstaLeno)
            {
                throw new Exception("El arreglo esta lleno");
            }
            _arreglo[_tope] = numero;
            _tope++;

        }
        //Metodod insertar
                public void Insertar(int numero, int posicion)
        {
            if (EstaLeno)
            {
                   throw new Exception("El arreglo esta lleno");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion > _tope)
            {
             posicion = _tope;
            }
            for(int i = _tope; i > posicion; i--)
            {
               _arreglo[i] = _arreglo[i - 1];
            }
            _arreglo[posicion] = numero;
            _tope++;
        }
        //Metodo eliminar
        public void Eliminar(int posicion)
        {
            if (EstaVacio)
            {
                throw new Exception("El arreglo esta vacio");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion > _tope)
            {
                posicion = _tope;
            }
            for (int i = posicion; i < _tope - 1; i++)
            {
                _arreglo[i] = _arreglo[i + 1];
            }
            _tope--;
        }
        //metodo ToString
        public override string ToString()
        {
            if (EstaVacio)
            {
                Console.WriteLine("El arreglo esta vacio");
            }
            int contador = 0;
            string salida = string.Empty;
            for (int i = 0; i < _tope; i++)
            {
                salida += $"{_arreglo[i]}\t ";
                contador++;
                if (contador > 9)
                {
                    contador = 0;
                    //salida = salida + "\n";
                    salida += "\n";
                }

            }
            return salida;
        }


    }
}