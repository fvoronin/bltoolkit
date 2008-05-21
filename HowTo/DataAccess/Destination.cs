using System;
using System.Collections.Generic;

using NUnit.Framework;

using BLToolkit.DataAccess;

namespace HowTo.DataAccess
{
	[TestFixture]
	public class Destination
	{
		public abstract class PersonAcessor : DataAccessor
		{
			public abstract void SelectAll([/*[a]*/Destination/*[/a]*/] IList<Person> list);
		}

		[Test]
		public void Test()
		{
			PersonAcessor pa = DataAccessor.CreateInstance<PersonAcessor>();

			List<Person> list = new List<Person>();

			pa.SelectAll(list);

			Assert.AreNotEqual(0, list.Count);
		}
	}
}