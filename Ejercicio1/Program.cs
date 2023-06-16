using System;
using System.Collections.Generic;
using System.IO;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = Directory.GetCurrentDirectory();
            Console.WriteLine(dir);
            string ruta = dir+ "//..//..//..//data.txt";
            List<Rect> Datos = new List<Rect>();
            try
            {
                using (var sr = new StreamReader(ruta))
                {
                    string[] texto = sr.ReadToEnd().Split("\n");
                    for(int i=0; i < texto.Length; i++)
                    {
                      if(texto[i]!="")
                        {
                      Rect nuevo = new Rect(texto[i]);
                      Datos.Add(nuevo);
                        }
                    }
                }
             
        }
            catch (IOException e)
            {
                Console.WriteLine("Errores en el archivo");
                Console.WriteLine(e.Message);
            }

            //Suma de Areas
            int sum_area = 0;
            foreach( Rect cuadro in Datos)
            {
                sum_area += cuadro.Area();
            }
            //Diferencia de Areas
            int dif_area = 0;
            foreach (Rect cuadro1 in Datos)
            {
                foreach (Rect cuadro2 in Datos)
                {
                        dif_area += cuadro1.Area_Dif(cuadro2);
                }
            }

            // Resultado
            int area_total = sum_area - dif_area;
            Console.WriteLine("Area Total = "+ area_total);

        }




    }
}
