
using System; 

public class exemple10
{
	static public void Main()

	{   
		  //array1  und array2 deklarieren und initialisieren

		double[] array1 = new double [10] { 20, 73, 2, 56, 28, 30.4, 33.1, 23, 45, 19};
		double[] array2 = new double [10];
		double  max = 0, max2 = 0;


		 Console.WriteLine(" \n\t Dies Programm vergleich CO2-Ausstoßin zweier Inselstaate, und zwar karibischer St. Kitts und Nevis und pazifischer Niue \n\n");

		Console.WriteLine("  Geben Sie bitte CO2-Ausstoß in den letzten 10 Jahren in karibischer St. Kitts und Nevis. \n");


		for ( int i = 0; i < 10; i++)
		{

		
			array1[i] = Convert.ToDouble(Console.ReadLine());
		
				if ( i == 0)
					{
						max = array1[i];	
						
					}
					else
					{
 
						if( array1[i] >  max)  max = array1[i]; 
						
					}


		}

						// datenanzeige ,,,, l'affichage des donnees,,,,
			for (int  i = 0; i < 10; i++)
			{
				Console.Write( array1[i] + " - \t");
			}
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

			Console.WriteLine(" \n\nGeben Sie bitte CO2-Ausstoß in den letzten 10 Jahren in pazifischer Niue");


			for ( int i = 0; i < 10; i++)
		{

		
			array2[i] = Convert.ToDouble(Console.ReadLine());
		
				if ( i == 0)
					{
						max2 = array2[i];	//min = array1[i];	sum = array1[i];
						
					}
					else
					{
						if( array2[i] >  max2)  max2 = array2[i]; 
					}
						
					}
		
						// datenanzeige ,,,, l'affichage des donnees,,,,
			for (int  i = 0; i < 10; i++)
			{
				Console.Write( array2[i] + " - \t");
			}

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
				if(max > max2)
				{
					Console.WriteLine("\nkaribischer St. Kitts und Nevis beträgt den größten jährlichen CO2-Ausstoß : {0}", max);
				}
				
				if(max < max2) 		{ Console.WriteLine("\npazifischer Niue beträgt den größten jährlichen CO2-Ausstoß : {0}", max2);}

				if( max == max2)	{ Console.WriteLine("\npazifischer Niue und karibischer St. Kitts und Nevis  beträgt den gleichen jährlichen CO2-Ausstoß   : {0}", max2);}
				
				




			//Console.WriteLine(" Max karibischer St. Kitts und Nevis ist: {0} ", + max);
			//Console.WriteLine(" Max pazifischer Niue ist: {0} ", + max2);
			


		Console.WriteLine("");
		Console.WriteLine(" Drücken Sie bitte ein Taste, um das Console zu schliessen");

		Console.ReadKey();
 	
		}
		}