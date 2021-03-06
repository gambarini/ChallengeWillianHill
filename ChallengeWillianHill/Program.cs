﻿using System;
using Microsoft.Owin.Hosting;

namespace ChallengeWillianHill
{
	class MainClass
	{
		const string HttpLocalHost = "http://localhost:9000";

		public static void Main (string[] args)
		{
			using (WebApp.Start<Startup> (HttpLocalHost))
			{
				System.Console.WriteLine("Listening on " + HttpLocalHost);
				System.Console.WriteLine("Press [enter] to quit...");
				System.Console.ReadLine();
			}
		}
	}
}
