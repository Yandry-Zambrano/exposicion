using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxyE
{
	//Sujeto: Define el objeto real representado por el Proxy.
	class Sujeto :ISujeto
	{
		public string Request()
		{
			return "Llamando al Subject.Request()";
		}
	}
}
