using System;
using System.Net.Sockets;

namespace MulticastTtl
{
	class Program
	{
		static void Main(string[] args)
		{
			// var addressFamily = AddressFamily.InterNetwork;
			var addressFamily = AddressFamily.InterNetworkV6;

			var socket = new Socket(addressFamily, SocketType.Dgram, ProtocolType.Udp);

			socket.SetSocketOption(addressFamily == AddressFamily.InterNetwork ? SocketOptionLevel.IP : SocketOptionLevel.IPv6, SocketOptionName.MulticastTimeToLive, 32);
		}
	}
}
