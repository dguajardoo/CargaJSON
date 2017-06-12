using System;
using System.Diagnostics;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CargaJSON
{
    public class Horario
    {
		[JsonProperty(PropertyName = "hora")]
		public int Id { get; set; }

		[JsonProperty(PropertyName = "horadesde")]
		public string HoraDesde { get; set; }

		[JsonProperty(PropertyName = "horahasta")]
		public string HoraHasta { get; set; }

		[JsonProperty(PropertyName = "asignatura")]
		public string Asignatura { get; set; }

		[JsonProperty(PropertyName = "curso")]
		public string Curso { get; set; }

		[JsonProperty(PropertyName = "sala")]
		public string Sala { get; set; }
		//public string Icono { get; private set; }

		/*
        public Horario(int id, string horadesde, string horahasta, string asignatura, string curso, string sala)
        {
            this.Id = id;
            this.HoraDesde = horadesde;
            this.HoraHasta = horahasta;
            this.Asignatura = asignatura;
            this.Curso = curso;
            this.Sala = sala;
            //this.Icono = icono;
        }
        */

		public override string ToString()
		{
			return Asignatura;
		}

		public static List<Horario> ProcesaListaJson(IList<JToken> jArray)
		{
			if (jArray == null)
				return null;

			var lista = new List<Horario>();

			var array = new Array[6];
			var count = 0;
			foreach (JToken result in jArray)
			{
				try
				{
					var aux = result;
					Debug.WriteLine("aux: " + aux);
					//ProcesaListaJson2(aux);
					//Horario o = JsonConvert.DeserializeObject<Horario>((result.ToString(Formatting.None)));
					//Debug.WriteLine(o.HoraDesde);
					//lista.Add(o);

				}
				catch (Exception e)
				{
					Debug.WriteLine("Horario::ProcesaListaJson:Error: " + e);
				}
			}

			return lista;
		}

		public static List<Horario> ProcesaListaJson2(IList<JToken> jArray)
		{
			if (jArray == null)
				return null;

			var lista = new List<Horario>();

			var array = new Array[6];
			var count = 0;
			foreach (JToken result in jArray)
			{
				try
				{
					var aux = result;
					Debug.WriteLine("aux: " + aux);
					//ProcesaListaJson2(aux);
					//Horario o = JsonConvert.DeserializeObject<Horario>((result.ToString(Formatting.None)));
					//Debug.WriteLine(o.HoraDesde);
					//lista.Add(o);

				}
				catch (Exception e)
				{
					Debug.WriteLine("Horario::ProcesaListaJson:Error: " + e);
				}
			}

			return lista;
		}


		public static Horario ProcesaListaJson3(JToken jArray)
		{
			if (jArray == null)
				return null;

			//var lista = new List<Horario>();
			//var item = new Horario();
            var aux2 = jArray.ToObject<Horario>();

			var array = new Array[6];
			var count = 0;
			try
			{
				//var aux = jArray;
				//Debug.WriteLine("aux: " + aux);
				
				//array[count] = aux2;
				Debug.WriteLine(aux2.Asignatura);
				Debug.WriteLine(aux2.Curso);
				Debug.WriteLine(aux2.HoraDesde);
				Debug.WriteLine(aux2.HoraHasta);
				Debug.WriteLine(aux2.Id);
				Debug.WriteLine(aux2.Sala);
				count++;
				//Horario o = JsonConvert.DeserializeObject<Horario>((result.ToString(Formatting.None)));
				//Debug.WriteLine(o.HoraDesde);
				//lista.Add(o);


			}
			catch (Exception e)
			{
				Debug.WriteLine("Horario::ProcesaListaJson:Error: " + e);
			}

			return aux2;
		}
    }
}
