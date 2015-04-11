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

			string csvUnSettled = "";
			var controller = new BetController(new MockBetRepository(csvUnSettled));
			ControllerRequest.CreateRequest(controller);

			var bets = controller.Get ();

			Assert.AreEqual (0, bets.Count);

		}
	}
}

