using System;
using System.Web.Http;
using System.Collections.Generic;
using ChallengeWillianHill.DTO;

namespace ChallengeWillianHill.REST
{
	[RoutePrefix("Customer")]
	public class CustomerControler : ApiController
	{
		
		public CustomerControler ()
		{
		}

		public List<Customer> Get(){

			return new List<Customer> ();

		}


	}
}

