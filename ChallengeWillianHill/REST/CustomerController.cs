using System;
using System.Web.Http;
using System.Collections.Generic;
using ChallengeWillianHill.Domain;
using ChallengeWillianHill.Infrastructure;

namespace ChallengeWillianHill.REST
{
	[RoutePrefix("Customer")]
	public class CustomerController : ApiController
	{
		CustomerRepository _repository;

		public CustomerController ()
		{
			_repository = new CustomerRepository ();	
		}

		public CustomerController (CustomerRepository repository)
		{
			this._repository = repository;
		}

		[Route()]
		[HttpGet]
		public List<Customer> Get(){

			List<Customer> customers = _repository.FindCustomers ();

			return customers;

		}


	}
}

