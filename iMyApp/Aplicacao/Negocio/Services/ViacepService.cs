using Negocio.Entidades;
using RestSharp;

namespace Negocio.Services
{
    public class ViacepService
    {
        private const string VIACEP_URL = "https://viacep.com.br/ws/";
        /// <summary>O método ObterEnderecoPorCep() é público e retorna um objeto Endereco
        ///    O método recebe um parâmetro cep, que é o CEP do endereço a ser consultado
        /// <example>Exemplo:
        /// <code>
        ///    string cep = textBox1.Text;
        ///    Endereco endereco = ViacepService.ObterEnderecoPorCep(cep);
        ///    label1.Text = endereco.ToString();
        /// </code>
        /// </example>
        /// <param name="cep"></param>
        /// <returns>retorna classe endereço</returns>
        /// </summary>
        public Endereco ObterEnderecoPorCep(string cep)
        {
            // O método cria um cliente RestSharp para a API do ViaCEP.
            // A URL da API é definida na constante VIACEP_URL.
            var client = new RestClient(VIACEP_URL);

            // O método cria uma solicitação HTTP para a API.
            // A solicitação é configurada para usar o método GET e o CEP como parâmetro.
            var request = new RestRequest($"{VIACEP_URL}{cep}/json",Method.Get);

            // O método envia a solicitação à API.
            var response = client.Get<Endereco>(request);

            return response!;
        }
    }
}
