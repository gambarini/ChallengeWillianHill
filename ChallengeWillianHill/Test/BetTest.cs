using System;
using NUnit.Framework;
using ChallengeWillianHill.REST;
using ChallengeWillianHill.Helper;

namespace ChallengeWillianHill.Test
{
	[TestFixture]
	public class BetTest
	{
		public BetTest ()
		{
		}

		[Test]
		public void UnsettleBetTest(){

			string csvUnSettled = "1,11,4,50,500\n3,11,6,50,400\n4,11,7,300,1200";
			var controller = new BetController(new MockBetRepository(csvUnSettled));
			ControllerRequest.CreateRequest(controller);

			var bets = controller.Get ();

			Assert.AreEqual (3, bets.Count);
			Assert.AreEqual (1, bets[0].CustomerId);
			Assert.AreEqual (3, bets[1].CustomerId);
			Assert.AreEqual (4, bets[2].CustomerId);
			Assert.AreEqual (500, bets[0].Prize);
			Assert.AreEqual (400, bets[1].Prize);
			Assert.AreEqual (1200, bets[2].Prize);
			Assert.AreEqual (50, bets[0].Stake);
			Assert.AreEqual (50, bets[1].Stake);
			Assert.AreEqual (300, bets[2].Stake);

		}
	}
}

