using System;
using System.Net.Sockets;

namespace NetPackAlpha
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            //Variablen Deklaration
            ushort bChoice;
			
            //Abfrage des gewünschten Pakettypuses
            Console.WriteLine("Mind that until now nothing is working!");
            Console.Write("Please choose from the given options: \n 1) Ping \n 2) ARP \n 3)...\n");
            bChoice = Convert.ToUInt16(Console.ReadLine());

            switch (bChoice)
            {
                case 1:
                    Console.WriteLine("What is the destinationIp?");
                    //Missing Code
                    break;
                case 2:
                    //Missing Code
                    break;
            }
        }
	}
}
