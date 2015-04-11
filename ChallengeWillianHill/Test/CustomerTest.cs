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

			string csvSettled = "1,1,6,50,250\n2,1,3,5,0\n1,1,3,50,0\n2,1,6,200,0\n3,1,6,200,20\n3,1,6,200,30";


			var controller = new CustomerController(new MockCustomerRepository(csvSettled));
			ControllerRequest.CreateRequest(controller);

			var customers = controller.Get ();

			Assert.AreEqual (3, customers.Count);
			Assert.AreEqual (1, customers[0].Id);
			Assert.AreEqual (2, customers[1].Id);
			Assert.AreEqual (3, customers[2].Id);
			Assert.AreEqual (50.0m, customers[0].WinRate);
			Assert.AreEqual (0.0m, customers[1].WinRate);
			Assert.AreEqual (100.0m, customers[2].WinRate);
			Assert.AreEqual (50.0m, customers[0].AverageBet);
			Assert.AreEqual (102.5m, customers[1].AverageBet);
			Assert.AreEqual (200.0m, customers[2].AverageBet);


		}
	}
}

