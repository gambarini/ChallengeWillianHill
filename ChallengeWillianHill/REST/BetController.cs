using System;
using System.Web.Http;
using ChallengeWillianHill.Infrastructure;
using System.Collections.Generic;
using ChallengeWillianHill.Domain;

namespace ChallengeWillianHill.REST
{
	[RoutePrefix("Bet")]
	public class BetController : ApiController
	{
		BetRepository _repository;

		public BetController ()
		{
			_repository = new BetRepository ();
		}

		public BetController (BetRepository repository)
		{
			this._repository = repository;
			
		}

		[Route("Unsettle")]
		[HttpGet]
		public List<Bet> Get(){
			return _repository.GetUnsettledBets ();
		}
	}
}

