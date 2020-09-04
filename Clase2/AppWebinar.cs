/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 04/09/2020
 * Time: 11:00 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Clase2
{
	/// <summary>
	/// Description of AppWebinar.
	/// </summary>
	public class AppWebinar
	{
		public static void Main(string[]arg){
			
		webinar a =new webinar();
		webinar b=new webinar("Python","Conferencia","21/09/2020","08:00","12:00",50,3000);
		webinar c=new webinar("c++");
		
		Console.WriteLine("============Objeto 1============");
		a.mostrar();
		Console.WriteLine("============Objeto 2============");
		b.mostrar();
		Console.WriteLine("============Objeto 3============");
		c.mostrar();
		Console.ReadKey(true);
	}
	}
		
}
