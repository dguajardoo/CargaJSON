using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace CargaJSON
{
    public class MockService
    {
        public MockService()
        {
        }

		public JObject PostToAPI(Dictionary<string, string> pars, string service_url, string file, bool autenticar = true)
		{
			//Debug.WriteLine("1");
			//if (service_url.CompareTo(STSUri.AsistenciaUri) == 0)
			//{
			//var jsonString = @"{}";
			//Debug.WriteLine("2");
            FilesImplementation fi = new FilesImplementation();
            var jsonString =   fi.LoadFile(file);
            //Debug.WriteLine(jsonString);

			//Debug.WriteLine("3");
			var json = JObject.Parse(jsonString);
			//Debug.WriteLine("4");
			return json;
			//}
			//Debug.WriteLine("servicio nulo");
			//return await Task.Run(() => (JObject)null);
		}
    }
}
