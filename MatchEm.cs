using System;

namespace _DiceGame
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			
			Console.SetWindowSize(80, 23);
			Console.SetBufferSize(80, 23);
			Random alea = new Random();

			string name;
			double bet;
			// se que esta parte en teoria no neceista ser modificada pero tengo la costumbre de
			// incializar las variables que lo neceistan al declararlas.
			int dieCroupier = 0; 
			int dieGambler = 0;

			Console.WriteLine("MATCH'EM");
			Console.WriteLine("--------");
			Console.WriteLine();

			Console.WriteLine("Welcome to the casino!!!\n");
			Console.Write("Now gambler, please tell me your name: ");
			Console.ForegroundColor = ConsoleColor.Green;
			name = Console.ReadLine();
			Console.ResetColor();
			Console.WriteLine();

			Console.Write("Well " + name + " show me your money! Put your bet. How many euros: ");
			Console.ForegroundColor = ConsoleColor.Green;
			bet = Convert.ToDouble(Console.ReadLine());
			Console.ResetColor();
			Console.WriteLine();

			if (bet <= 0)
			{

				// si la apuesta es inferior o igual a zero nos echan del local
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("COME ON " + name + ". Are your serious? Are you trying to cheat?");
				Console.WriteLine("Zero or negative bets are NEVER ALLOWED. You're expelled!!!");
				Console.ResetColor();

			}

			else {
				
				Console.Write(name + " press any key and I'll throw my die... ");
				Console.ReadKey(true); // hide the key
				Console.WriteLine("\n");
				dieCroupier = alea.Next(1, 7);

				Console.Write("\tMy DIE: ");
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine(dieCroupier);
				Console.ResetColor();
				Console.WriteLine();


				/* TODO 2 Complete this block */
				if (dieCroupier == 6)       // si el juego no ha acabado al haber sacado un 6
				{
					
					Console.WriteLine("Ohhh, such a bad luck {0} !, you lost. I got a SIX. This means I take everything ", name);
					Console.WriteLine("You lost your bet. You lose {0} euros", bet);
				}

				else {
					
					Console.Write(name + " press any key to throw your die... ");
					Console.ReadKey(true); // hide the key
					Console.WriteLine("\n");
					dieGambler = alea.Next(1, 7);

					Console.Write("\t{0} DIE: ", name);
					Console.ForegroundColor = ConsoleColor.Magenta;
					Console.WriteLine(dieGambler);
					Console.ResetColor();
					Console.WriteLine();


					if (dieCroupier == 1 && dieGambler == 1)        // snake eyes
					{

						// SNAKE EYES
						Console.WriteLine("CONGRATULATIONS {0}. The result is Snake Eyes", name);
						Console.WriteLine("You win FOUR times your bet. You win {0} euros", bet * 4);
					}

					else if (dieGambler % 2 == 0 && dieCroupier % 2 == 0 || dieGambler % 2 != 0 && dieCroupier % 2 != 0)
					{

						// si los dos son pares o los dos son inpares...
						Console.WriteLine("CONGRATULATIONS {0}. Both dices MATCH IN PARITY ", name);
						Console.WriteLine("You win TWO times your bet. You win {0} euros", bet * 2);

					}
					else 
					{

						// Cualquier otro resultado
						Console.WriteLine("CONGRATULATIONS for NOTHING {0} , you LOSE. ", name);
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("YOU LOSE and you lose {0} euros, WHAT A SHAME!", bet);
						Console.ResetColor();

					}
				}
			} // end of outer else

			Console.SetCursorPosition(0, Console.WindowHeight-1);
			Console.Write("Press any key to exit... ");
			Console.ReadKey();
			Environment.Exit(0);
		}
	}
}
