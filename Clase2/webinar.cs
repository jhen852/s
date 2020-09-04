/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 04/09/2020
 * Time: 10:42 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Clase2
{
	/// <summary>
	/// Description of webinar.
	/// </summary>
	public class webinar
	{
		private string titulo;
		private string tipo;
		private string fecha;
		private string horaIni;
		private string horaFin;
		private double costo;
		private int nroParticipantes;
    	/*
    	 un Contructor inicializa los valores de los atributos 
    	 */
		public webinar(){
			titulo="Tratamiento covid";
			tipo="Seminario";
			fecha="10/09/2020";
			horaIni="19:00";
			horaFin="21:00";
			costo=30;
			nroParticipantes=1500;
		}
		public webinar(string t, string p , string f, string hi, string hfm ,double cost, int px){
			titulo=t;
			tipo=p;
			fecha=f;
			horaIni=hi;
			horaFin=hfm;
			costo=cost;
			nroParticipantes=px;	
		}
    		public webinar(string n){
			titulo=n;
			tipo="";
			fecha="";
			horaIni="";
			horaFin="";
			costo=0;
			nroParticipantes=0;	
		}
    	
    	~webinar(){
    		Console.WriteLine("Libera memoria");
    	}
    	
    	public void mostrar(){
    		Console.WriteLine("Titulo :"+titulo);
    		Console.WriteLine("Tipo : "+tipo);
    		Console.WriteLine("Fecha :"+fecha);
    		Console.WriteLine("hora de inicio :"+horaIni);
    		Console.WriteLine("hora fin :"+horaFin);
    		Console.WriteLine("Costo :" +costo);
    		Console.WriteLine("Nro De Participantes"+nroParticipantes);
    	}
    	
    	/*
    	 	getter y setter
    	 
    	*/
    	p
	}
}
