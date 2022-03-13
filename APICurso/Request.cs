using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APICurso.Application
{
    public class Request
    {
        public string url { get; } = "https://localhost:55685/";
        public void Limite(int id)
        {
            //ClienteModel result = new ClienteModel();
            try
            {
                string urlLimite = url + ("/limiteCliente?id={0}",id);

                
                WebRequest tRequest = WebRequest.Create(urlLimite);
                tRequest.Method = "GET";
                tRequest.Timeout = 30000;
                tRequest.Headers.Add("accept: application/json");
                tRequest.ContentType = "application/json";


                WebResponse reposta = tRequest.GetResponse();
                using (Stream stream = reposta.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    //result = JsonConvert.DeserializeObject<ClienteModel>(reader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                //return new PreLoginModel { errorMessage = ex.Message };
            }
            

        }
    }
}
