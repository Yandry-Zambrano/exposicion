using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxyE
{
	//Proxy: Define una clase que crea, controla y authentica el acceso a un objeto real.
	class Proxy
	{
		Sujeto sujeto;

		public string Request()
		{
			// Un proxy virtual crea el objeto solamente en la primera llamada al método
			if (sujeto == null)
			{
				sujeto = new Sujeto();
			}
			return sujeto.Request();
		}
	}
}
