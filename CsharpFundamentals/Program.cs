using System;

namespace Iterations
{
	class Program
	{
		static void Main(string[] args)
		{			
 			while(true)
 			{
 				Console.WriteLine("Type your name: ");
 				var input = Console.ReadLine();
 				
 				if(!String.IsNullOrWhiteSpace(input))
 				{
 					Console.WriteLine("@Echo: " + input);
 					continue;
 				}
 				
 				break;
 			}
		}
	
