using System;

namespace degisken
{
     class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("");

            
            string str20 = "20";
            int int20 = 20;
            string yenideğer = str20 + int20.ToString();
            Console.WriteLine(yenideğer);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);
            
            int int22 = int20 + int.Parse(str20);            
            string datetime = DateTime.Now.ToString("dd.mm.yyyy");
            Console.WriteLine(datetime);
            string hour = DateTime.Now.ToString("hh.mm");
            Console.WriteLine(hour);

        }

    }
}