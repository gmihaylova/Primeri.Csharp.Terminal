﻿using System;

namespace Modul03
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double a = 0, b = 0, c = 0;
			Console.Write (">a = "); a = Convert.ToDouble( Console.ReadLine () );
			Console.Write (">b = "); b = Convert.ToDouble( Console.ReadLine () );
			Console.Write (">c = "); c = Convert.ToDouble( Console.ReadLine () );

			string _format = "#0.00 m3";
			Console.WriteLine ("\n\n>a * b * c = " + (a * b * c).ToString( _format ));

		}
	}
}
