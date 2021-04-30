using System;

namespace ejercicio12
{
    class ejercicio12
    {
        private string[] nombres; 
        
                private float[] sueldos; 
        public void Cargar()
        {
            nombres = new string[5];
            sueldos = new float[5];
            for (int f = 0; f< nombres.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado "+(f+1)+": ");
                nombres[f] = Console.ReadLine();
                Console.Write("Ingrese el sueldo "+(f+1)+": ");
                string linea;
                linea = Console.ReadLine();
                sueldos[f] = float.Parse(linea);
            }
        }
        public void salariomayor()
        {
            float mayor;
            int pos;
            mayor = sueldos[0];
            pos = 0;
            for (int f = 1; f< nombres.Length; f++)
            {
                if (sueldos[f] > mayor)
                {
                    mayor = sueldos[f];
                    pos = f;
                }
            }
            Console.WriteLine("El empleado con sueldo mayor es :" + nombres[pos]);
            Console.WriteLine("Tiene un sueldo de: " + mayor);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            ejercicio12 xd = new ejercicio12();
            xd.Cargar();
            xd.salariomayor();

            
        }
    }
}