using System;
using NUnit.Framework;
using ChallengeWillianHill.Helper;
using ChallengeWillianHill.REST;
using ChallengeWillianHill.Infrastructure;

namespace ChallengeWillianHill.Test
{
	[TestFixture]
	public class CustomerTest
	{
		public CustomerTest ()
		{
		}

		public void GetCustomerTest(){



			var controller = new CustomerControler(new MockCustomerRepository());
			ControllerRequest.CreateRequest(controller);

			var customers = controller.Get ();

			Assert.AreEqual (0, customers);

		}
	}
}

