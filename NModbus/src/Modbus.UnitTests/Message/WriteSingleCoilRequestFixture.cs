using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Modbus.Message;

namespace Modbus.UnitTests.Message
{
	[TestFixture]
	public class WriteSingleCoilRequestFixture
	{
		[Test]
		public void NewWriteSingleCoilRequest()
		{
			WriteSingleCoilRequest request = new WriteSingleCoilRequest(11, 5, true);
			Assert.AreEqual(11, request.SlaveAddress);
			Assert.AreEqual(5, request.StartAddress);
			Assert.AreEqual(1, request.Data.Count);
			Assert.AreEqual(Modbus.CoilOn, request.Data[0]);
		}
	}
}
