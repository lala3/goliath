using NUnit.Framework;

namespace Goliath.Tests
{
	[TestFixture]
	public class Empty
	{
		[Test]
		public virtual void Pass()
		{
			Assert.AreEqual (1, 2);
		}
	}
}