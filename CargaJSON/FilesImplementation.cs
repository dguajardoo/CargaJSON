using System;
using System.IO;
using System.Diagnostics;

namespace CargaJSON
{
    public class FilesImplementation
    {
		public FilesImplementation()
		{
		}

        public string LoadFile(string fileName)
		{
			string content = "";
            //Debug.WriteLine(fileName);
            //Debug.WriteLine("1");
            string appPath = Environment.CurrentDirectory;
            //Debug.WriteLine(appPath);

			try
			{
                using (FileStream fs = new FileStream("/Users/dguaj/Projects/CargaJSON/CargaJSON/" + fileName, FileMode.Open, FileAccess.Read))
				{
					using (StreamReader sr = new StreamReader(fs))
					{
						while (!sr.EndOfStream)
						{
                            content += sr.ReadLine();
							//Console.WriteLine(sr.ReadLine());
						}
					}
				}
                return content;
			}
			catch (System.Exception ex)
			{
				Console.WriteLine("Error al leer archivo '" + fileName + "': " + ex);
				return null;

			}
		}
    }
}
