using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxyE
{
	//ISujeto: una interfaz común para los objetos reales 
         //(subjecto ) y el proxy, esta interfaz define los metodos del
        //objeto real que el cliente podrá acceder a taves del proxy.
	interface ISujeto
	{
		string Request();
	}
}
