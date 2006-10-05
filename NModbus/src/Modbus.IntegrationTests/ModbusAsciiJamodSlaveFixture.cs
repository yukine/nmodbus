using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Modbus.Device;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Modbus.IntegrationTests
{
	[TestFixture]
	public class ModbusAsciiJamodSlaveFixture : ModbusMasterFixture
	{		
		private string program = String.Format("SerialSlave {0} ASCII", SlaveSerialPortName);

		[TestFixtureSetUp]
		public override void Init()
		{
			base.Init();

			SetupMasterSerialPort();
			Master = ModbusSerialMaster.CreateAscii(MasterSerialPort);

			StartJamodSlave(program);			
		}

		[TestFixtureTearDown]
		public void TestFixtureTearDown()
		{
			Jamod.Kill();
			Jamod.CloseMainWindow();
			Jamod.Close();			
		}
		
		[Test]
		public override void ReadCoils()
		{
			base.ReadCoils();
		}
	}
}