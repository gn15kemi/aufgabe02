using System; 

public class exemple10
{
	static public void Main()

	{    	//  Aufgabe 2.7

		// 7.Arrays 
		Console.WriteLine( " Willkommen Leute!!! \n\n");

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

//first question

	/*string[] numbers =  { "Dorothea Wierer", "Tiril Eckhoff", "Denise Herrmnn", "Hanna Oeberg", "Marte Olsbu Roiseland",
"Franziska Preuss", "Ingrid Landmark Tandrevold", "Julia Simon", "Justine Braisaz",  "Lisa Vttozzi"};
	 
	 foreach ( string i in numbers)  // Namen ausgeben mit foreach Anweisung

	 {  
	 	Console.WriteLine ( " {0}", i);
	 }		*/

// end of first question

string[] numbers =  { "Dorothea Wierer", "Tiril Eckhoff", "Denise Herrmnn", "Hanna Oeberg", "Marte Olsbu Roiseland",
"Franziska Preuss", "Ingrid Landmark Tandrevold", "Julia Simon", "Justine Braisaz",  "Lisa Vttozzi"};
	 

	 Console.WriteLine(" Die Namen der 10 Erstplazierten des Weltcups sind: \n");

	 		int count = 0;
	 foreach ( string i in numbers)  // Namen ausgeben mit foreach Anweisung

	 {  
	 	

	 	count++;


   
	 	Console.WriteLine ( " \t{0} - {1}",count , i);
	 }

		/*foreach( int i in list)

		{
			Console.WriteLine( " Enter names of participant ");



		}*/
	}


}