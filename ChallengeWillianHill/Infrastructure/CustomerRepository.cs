using System;
using System.Web.Http;
using System.Collections.Generic;
using ChallengeWillianHill.Domain;
using System.Linq;

namespace ChallengeWillianHill.Infrastructure
{
	public class CustomerRepository
	{
		protected string _csvSettled = string.Empty;

		public virtual List<Customer> FindCustomers ()
		{
			return _csvSettled.Split ('\n').Select (line => {
				var columns = line.Split (',');

				return new Customer {
					Id = Convert.ToInt32 (columns [0])
				};
			}).ToList ();

		}
	}

}

