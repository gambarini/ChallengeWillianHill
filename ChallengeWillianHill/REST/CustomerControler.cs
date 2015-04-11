using System;
using System.Web.Http;
using System.Collections.Generic;
using ChallengeWillianHill.Domain;
using ChallengeWillianHill.Infrastructure;

namespace ChallengeWillianHill.REST
{
	[RoutePrefix("Customer")]
	public class CustomerControler : ApiController
	{
		CustomerRepository _repository;

		public CustomerControler ()
		{
			_repository = new CustomerRepository ();	
		}

		public CustomerControler (CustomerRepository repository)
		{
			this._repository = repository;
		}

		public List<Customer> Get(){

			List<Customer> customers = _repository.FindCustomers ();

			return customers;

		}


	}
}

