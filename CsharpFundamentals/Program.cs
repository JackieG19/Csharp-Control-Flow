using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;
            
            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                    
                case Season.Autumn:
                    Console.WriteLine("It's perfect to go to beach.");
                    break;
                    
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
        }
    }
}
