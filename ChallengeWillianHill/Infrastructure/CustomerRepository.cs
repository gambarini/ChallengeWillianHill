using System;
using System.Web.Http;
using System.Collections.Generic;
using ChallengeWillianHill.Domain;
using System.Linq;
using System.IO;

namespace ChallengeWillianHill.Infrastructure
{
	public class CustomerRepository
	{
		protected string _csvSettled = string.Empty;

		public CustomerRepository ()
		{
			_csvSettled = File.ReadAllText ("csv/Settled.csv");	
		}

		public virtual List<Customer> FindCustomers ()
		{
			return _csvSettled.Split ('\n').Select (line => {
				var columns = line.Split (',');

				return new Bet {
					CustomerId = Convert.ToInt32 (columns [0]),
					Settled = true,
					Prize = Convert.ToInt32 (columns [4]),
					Stake = Convert.ToInt32 (columns [3])
				};
			}).GroupBy (b => b.CustomerId).Select (group => {

				var wonBet = group.Count (bet => bet.Prize > 0); 
				var totalBet = group.ToList().Count;
				decimal rate = ((decimal)wonBet / (decimal)totalBet);

				decimal average = Convert.ToDecimal(group.Average(bet => bet.Stake));

				return new Customer {
					Id = group.Key,
					WinRate = rate * 100,
					AverageBet = average
				};
			}).ToList ();

		}
	}

}

