using System;

namespace PracticaPrograIII
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] name = { "Valeria", "Ana", "Luis", "Carlos"};
            int[] age = { 26, 20, 12, 15 };

            int length = name.Length;
            int length1 = age.Length;

            Console.WriteLine(" ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(name[i]+"  "+age[i]);
            }

            Console.WriteLine("")

            Console.WriteLine(" ");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(name[i] + "  " + age[i]);
            }

            Console.ReadKey();
            */

            int temp;
            int[] edad = new int[4];
            string[] nombre = new string[4];
            for (int i = 0; i < edad.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre["+i +"]");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Igresa la edad:");
                edad[i] = Convert.ToInt32(Console.ReadLine());
            }
            string seudo;
            //METODO BURBUJA
            for (int i = 0; i < (edad.Length - 1); i++)
            {
                for (int j = 0; j < (edad.Length - 1); j++)
                {
                    if (edad[j] > edad[j + 1])
                    {
                        temp = edad[j];
                        seudo = nombre[j];
                        edad[j] = edad[j + 1];
                        nombre[j] = nombre[j + 1];
                        edad[j + 1] = temp;
                        nombre[j + 1] = seudo;

                    }
                }

            }

            
            
            Console.WriteLine("orden: ");
            for (int p = 0; p < edad.Length; p++)
            {
                Console.WriteLine(nombre[p] +": "+edad[p]);
            }



            /*
            for (int i = 0; i < (nombre.Length - 1); i++)
            {
                for (int j = 0; j < (edad.Length - 1); j++)
                {
                    if (edad[j] > edad[j + 1])
                    {
                        temp = edad[j];
                        seudo = nombre[j];
                        edad[j] = edad[j + 1];
                        nombre[j] = nombre[j + 1];
                        edad[j + 1] = temp;
                        nombre[j + 1] = seudo;

                    }
                }

            }*/

            
            Array.Sort(nombre);
            Console.WriteLine("orden:");
            Console.WriteLine(" ");
            for (int z = 0; z < nombre.Length; z++)
            {
                Console.WriteLine(nombre[z] + ":" + edad[z]);
            }



            int[] edadMenor = new int[4];
            int num, max = edadMenor[0];
            //Array.Sort(nombre);
            Array.Sort(edad);
            Console.WriteLine("orden:");
            Console.WriteLine(" ");
            for (int x = 0; x < edad.Length; x++)
            {
                //Console.WriteLine(nombre[x] + ":" + edad[x]);
               // num = edad;
               // edadMenor[x] = num;
            }
            

            Console.ReadLine();

        } 
    }
}
