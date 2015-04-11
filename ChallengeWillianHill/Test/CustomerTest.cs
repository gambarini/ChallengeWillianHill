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

		[Test]
		public void GetCustomerTest(){

			string csv = "1,1,6,50,250\n2,1,3,5,0\n1,1,3,20,0\n2,1,6,200,1000";

			var controller = new CustomerControler(new MockCustomerRepository(csv));
			ControllerRequest.CreateRequest(controller);

			var customers = controller.Get ();

			Assert.AreEqual (2, customers.Count);
			Assert.AreEqual (1, customers[0]);
			Assert.AreEqual (2, customers[0]);


		}
	}
}

