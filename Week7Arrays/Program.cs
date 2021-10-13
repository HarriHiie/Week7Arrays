using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] food = { "Võileib","peekon","muna","mahl" };
            
            food[3] = "viinerid";
            
            food[4] = "piim";
            
            Console.WriteLine("menüüs");

            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }
            Console.WriteLine("vali toit (sisesta 1-4");
            int userchoice = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"Oled valinud {food[userchoice]}");




            }
        }
    }

