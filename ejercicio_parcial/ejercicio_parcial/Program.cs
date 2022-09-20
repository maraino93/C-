using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_parcial
{
    internal class Program
    {   //diseñar un algoritmo que permita cargar marca de temperatura y humedad de una semana
        //al finalizar los ingresos informar:

        //a) cantidad de diaz en que la temperatura se mantuvo entre 10 y 12 inclusive y si la humedad fue mayor al 60%

        //b) temperatura promedio
        static void Main(string[] args)
        {
            float[] temp = new float[7];
            double[] humed = new double[7];
            double cont = 0;
            int suma = 0;
            float tempPromedio = 0;


            Console.WriteLine("ingrese las temperaturas y humedad de una semana: ");
            
            for (int i = 0; i < 7; i++)//igualo al recorrido de los vectores
            {
                //ingreso de datos
                Console.Write("ingrese la temperatura: ");
                temp[i] = float.Parse(Console.ReadLine());//ingreso temperatura
                Console.Write("ingrese la humedad: ");
                humed[i] = double.Parse(Console.ReadLine());//ingreso humedad
                if (temp[i] >= 10 && temp[i] <= 12 && humed[i] > 60)//pregunto si la temperatura es maypr a 10 y menor a 12 inclusive, y si humedad es mayor a 60
                {
                    cont++;//cuento la cantidad
                }
                suma++;//cuento todas las pasadas hata las que no se cumple
                tempPromedio = tempPromedio + temp[i];//sumo todas las temperaturas de cada posicion

            }
            tempPromedio = tempPromedio / suma;//saco el promedio de la temperatura

            Console.WriteLine("la temperatura que se matuvieron entre 10 y 12 grados y su humedad mayor a 60 son: " + cont);//saco por pantalla la cantidad que se cumple
            Console.WriteLine("el promedio de las temperaturas se matuvo en: " + tempPromedio);//promedio de temperatura
            Console.ReadKey();
        }
    }
}