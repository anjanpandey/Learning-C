using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
	//class Anjan //give more general name
	//{
	//	string f_name = "Anjan";
	//	string l_name = "Pandey";
	//	int age = 22;
	//}

	class Program
	{
		static void Main(string[] args)
		{

			//Preseve current console text color
			ConsoleColor oldColor = Console.ForegroundColor;
			//Change console text color 
			colorChanger();

			Random randomObject = new Random();

			while (true)
			{
				string questionString = GetQuestionFromUser();

				int numberOfSecondsToSleep = randomObject.Next(5) + 1;

				if (questionString.Length != 0 || questionString.ToLower() != "quit")
				{
					Console.WriteLine("Thinking about your answer....");
					Thread.Sleep(numberOfSecondsToSleep * 1000);
				}
				 
				if (questionString.Length == 0)
				{
					Console.WriteLine("You need to type in the question first");
					continue; //don't run anything in that loop, go back to the beginning and start over 
				}

				//See if the user typed 'quit' as the question
				if (questionString.ToLower() == "quit")
				{
					break;
				}

				returnAnswer();
			}
			//cleaning up
			Console.ForegroundColor = oldColor;
		}

		static void colorChanger()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("M");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("agic 8 Ball by Anjan");
		}

		/// <summary>
		/// This method ask the question to the user and return it!
		/// </summary>
		/// <returns></returns>
		static string GetQuestionFromUser()
		{
			//This block of code will ask the user for a question
			// and store the question text in questionString variable 
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("Ask a question?:");
			Console.ForegroundColor = ConsoleColor.Gray;
			string questionString = Console.ReadLine();

			return questionString;

		}

		static void returnAnswer()
		{
			Random randomObject = new Random();
			//Console.WriteLine("{0}", randomObject.Next(10) + 1); 
			//Get a random# less than 4 but greater than 0
			int randomNumber = randomObject.Next(4);

			//Use random number to determine response 
			switch (randomNumber)
			{
				case 0:
					{
						Console.WriteLine("Yes!!!");
						break;
					}
				case 1:
					{
						Console.WriteLine("No!!!");
						break;
					}
				case 2:
					{
						Console.WriteLine("Oh No!!!");
						break;
					}
				case 3:
					{
						Console.WriteLine("OMG Yes!!!");
						break;
					}
			}

		}

	}
}
