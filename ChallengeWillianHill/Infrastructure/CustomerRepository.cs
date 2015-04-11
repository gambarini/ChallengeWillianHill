using System;
using System.Web.Http;
using System.Collections.Generic;
using ChallengeWillianHill.Domain;

namespace ChallengeWillianHill.Infrastructure
{
	public class CustomerRepository
	{
		public virtual List<Customer> FindCustomers ()
		{
			return new List<Customer> ();
		}
	}

}

