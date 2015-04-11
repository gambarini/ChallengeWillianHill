using System;
using NUnit.Framework;
using ChallengeWillianHill.REST;
using ChallengeWillianHill.Infrastructure;

namespace ChallengeWillianHill.Test
{
	public class MockBetRepository : BetRepository
	{
		public MockBetRepository (string cvsUnsettle)
		{
			_csvUnSettled = cvsUnsettle;
		}
	}

}

