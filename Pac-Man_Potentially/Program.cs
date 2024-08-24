using Pac_Man_Potentially;
using System;
using System.Diagnostics;
using System.Text; 

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ASCII Art";
            string title = @"
 ____                                     ______    __    ___             
/\  _`\                                  /\__  _\__/\ \__/\_ \            
\ \ \L\_\ __      ___     ___   __  __   \/_/\ \/\_\ \ ,_\//\ \      __   
 \ \  _\/'__`\  /' _ `\  /'___\/\ \/\ \     \ \ \/\ \ \ \/ \ \ \   /'__`\ 
  \ \ \/\ \L\.\_/\ \/\ \/\ \__/\ \ \_\ \     \ \ \ \ \ \ \_ \_\ \_/\  __/ 
   \ \_\ \__/.\_\ \_\ \_\ \____\\/`____ \     \ \_\ \_\ \__\/\____\ \____\
    \/_/\/__/\/_/\/_/\/_/\/____/ `/___/> \     \/_/\/_/\/__/\/____/\/____/
                                    /\___/                                
                                    \/__/                                 
                                                                 ";

            Console.WriteLine(title);
            Console.WriteLine("Press Enter to Play PacMan!");

            MainMenuKeyReader();
           


            
        }


        public static void MainMenuKeyReader()
        {
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
            }
        }
    }
}

