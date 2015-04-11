using System;
using System.Web.Http;
using System.Collections.Generic;
using ChallengeWillianHill.Domain;
using System.IO;

namespace ChallengeWillianHill.Infrastructure
{
	public class BetRepository
	{
		protected string _csvUnSettled = string.Empty;

		public BetRepository ()
		{
			_csvUnSettled = File.ReadAllText ("csv/Unsettled.csv");	
		}

		public List<Bet> GetUnsettledBets ()
		{
			return new List<Bet> ();
		}
	}

}

