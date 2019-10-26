using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.API_s
{
    class Correio__API
    {
        public dynamic Buscar(string cep)
        {
            // Cria objeto responsável por conversar com uma API
            System.Net.WebClient rest = new System.Net.WebClient();
            rest.Encoding = Encoding.UTF8;

            // Chama API do correio, concatenando o cep
            string resposta = rest.DownloadString("https://viacep.com.br/ws/" + cep + "/json");

            // Transforma a resposta do correio em DTO
            dynamic r = Newtonsoft.Json.JsonConvert.DeserializeObject(resposta);
            return r;

           // return r.logradouro + " - " + r.bairro + " - " + r.localidade;
        }
    }
}
