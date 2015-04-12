using System;
using System.Web.Http;
using System.Collections.Generic;
using ChallengeWillianHill.Domain;
using System.IO;
using System.Linq;

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
			return _csvUnSettled.Split ('\n').Select (line => {
				var columns = line.Split (',');

				return new Bet {
					CustomerId = Convert.ToInt32 (columns [0]),
					Settled = false,
					Prize = Convert.ToInt32 (columns [4]),
					Stake = Convert.ToInt32 (columns [3])
				};
			}).ToList ();
		}
	}

}

