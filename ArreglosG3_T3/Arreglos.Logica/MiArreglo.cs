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
        //Constructor
        public MiArreglo(int n) {
            N = n;
            _arreglo = new int[N];
            _tope = 0;
        }
        //propiedades
        public int N { get; }
        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;

        //Metodos
        public void Llenar(int minimo, int maximo)
        {
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = random.Next(minimo, maximo);     
            }
            _tope = N;
        }
        //Metodo ordenar
        public void Ordenar()
        {
            for (int i = 0; i < _tope - 1; i++)
            {
                for (int j = i+; j < _tope; j++)
                {
                    if(_arreglo[i] > _arreglo[j])
                    {
                        Cambiar(ref _arreglo [i], ref _arreglo[j]);
                    }
                }
            } 
        }
        //Metodo cambiar
        public void Cambiar(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
        //Metodo ToString

        public override string ToString()
        {
            if (EstaVacio)
            {
                Console.WriteLine("El arreglo esta vacio");
            }
                int contador = 0;
                string salida = string.Empty;
            for(int i = 0; i < _tope; i++)
            {
                salida += $"{_arreglo[i]}\t";
                contador++;
                if (contador > 9)
                {
                    salida += "\n";
                    contador = 0;
                }

                contador = 0;
                //salida = salida "\n";
                salida += "\n";
                {
            
            }   
            return salida;
        }

    }
}
}