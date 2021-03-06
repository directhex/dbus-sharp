using System;
using NUnit.Framework;
using DBus;

namespace DBus.Tests
{
	[TestFixture]
	public class BusTests
	{
		/// <summary>
		/// Tests that re-opening a bus with the same address works (in other words that closing a connection works)
		/// </summary>
		[Test]
		public void ReopenedBusIsConnected()
		{
			var address = Environment.GetEnvironmentVariable("DBUS_SESSION_BUS_ADDRESS");
			var bus = Bus.Open(address);
			Assert.IsTrue(bus.IsConnected);
			bus.Close();
			bus = Bus.Open(address);
			Assert.IsTrue(bus.IsConnected);
		}
	}
}
