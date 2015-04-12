using System;
using System.Web.Http;
using System.Collections.Generic;
using ChallengeWillianHill.Domain;
using System.Linq;

namespace ChallengeWillianHill.Domain
{
	public class Bet
	{
		public int CustomerId { get; set;}
		public bool Settled { get; set;}
		public int Prize { get; set;}
		public int Stake { get; set;}
		public int Event { get; set;}
	}


}

