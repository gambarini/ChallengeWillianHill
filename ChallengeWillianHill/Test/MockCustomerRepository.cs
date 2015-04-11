using System;
using NUnit.Framework;
using ChallengeWillianHill.Helper;
using ChallengeWillianHill.REST;
using ChallengeWillianHill.Infrastructure;
using System.Collections.Generic;
using ChallengeWillianHill.Domain;

namespace ChallengeWillianHill.Test
{
	public class MockCustomerRepository : CustomerRepository
	{
		public override List<Customer> FindCustomers ()
		{
			return new List<Customer> ();
		}
	}

}

