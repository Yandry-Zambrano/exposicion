using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxyE
{
	class Program
	{
		static void Main(string[] args)
		{
			Proxy proxy = new Proxy();
			Console.WriteLine(proxy.Request());

			Console.Read();
		}
	}
}
