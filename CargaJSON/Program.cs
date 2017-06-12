using System;
using System.Diagnostics;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace CargaJSON
{
    class MainClass
    {
        //MockService mockService;

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //MockService mockService = new MockService();
            FetchData();
        }

		public static void FetchData()
		{
			Debug.WriteLine("Fetching data...");
			//Debug.WriteLine("5");
            MockService mockService = new MockService();
            var lista = new List<Horario>();
            var jsonRes = mockService.PostToAPI(null, "", "horario.json", true);
			//Debug.WriteLine("6");
			//Debug.WriteLine(jsonRes);
			//Debug.WriteLine("7");

            Debug.WriteLine("vamos bien");
            try
            {
                if (jsonRes != null)
                {
                    for (int i = 1; i <= 6; i++)
                    {
                        Debug.WriteLine("Día " + i);
                        for (int j = 1; j <= 10; j++)
                        {
                            if (jsonRes[Convert.ToString(i)]["hora" + j] != null)
                            {
                                var aux = (JObject)jsonRes[Convert.ToString(i)]["hora" + j];
                                //Debug.WriteLine(aux);
                                var _horario = Horario.ProcesaListaJson3(aux);
                                lista.Add(_horario);
                            }
                        }

                        Debug.WriteLine("-----------------------------------------------------");
                    }
                    //var aux = (JObject)jsonRes["1"]["hora1"];
                    //var aux2 = (JObject)aux;
                    //Debug.WriteLine(aux);
                    //var _horario = Horario.ProcesaListaJson3(aux);
                }
            } catch (Exception e) {
                Debug.Write(e.Message);
            }


            foreach (var item in lista)
            {
                Console.WriteLine(item.Asignatura);
            }
            Console.ReadKey();

        }
    }
}
