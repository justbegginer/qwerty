using System;

namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10];
            massive(mass);

        }
        public static void massive(int[] mass )
        {
            Random random = new Random();
            for(int i=0;i<mass.Length;i++)
            {
               int x = random.Next(1, 20);
                mass[i] = x;
            }
            realization(mass);
        }
        public static void realization(int[] mass)
        {           
            int x = 0;
            usersfalse(x, out x,mass);           
            int y = 0;
            usersfalse(y, out y,mass);
            int z = mass[x] + mass[y];
            Console.WriteLine(z);
            Console.ReadLine();
        }
        public static void usersfalse(int x,out int z,int[] mass)
        {
            try
            {
                Console.WriteLine("Введите номер массива");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Номер массива соответствует числу  " + mass[x]);
            }
            catch(Exception)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("error 404");
                Console.ResetColor();
                string[] return0 = new string[0];
                Main(return0);
            }
            z = x;
        }
        public static void usersfalsemass(int[] mass,int u)
        {
            //try
            //{
            //    Console.WriteLine("Номер массива соответствует числу  " + mass[u]);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("error 403");
            //    string[] return0 = new string[0];
            //    Main(return0);
            //}
        }
        

    }

}
