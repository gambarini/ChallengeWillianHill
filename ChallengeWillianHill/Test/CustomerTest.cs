using System;
using NUnit.Framework;
using ChallengeWillianHill.Helper;
using ChallengeWillianHill.REST;

namespace ChallengeWillianHill.Test
{
	[TestFixture]
	public class CustomerTest
	{
		public CustomerTest ()
		{
		}

		public void GetCustomerTest(){


			var controller = new CustomerControler();
			ControllerRequest.CreateRequest(controller);

			var customers = controller.Get ();

			Assert.AreEqual (0, customers);

		}
	}
}

