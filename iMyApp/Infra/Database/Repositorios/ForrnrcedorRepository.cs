using Negocio.Entidades;
using Negocio.Repository;


namespace Database.Repositorios
{
    internal class ForrnrcedorRepository : IForncedorRepository
    {
        public List<Fornecedor> ObterTodos()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            // Generate 50 fornecedores with sample data
            for (int i = 1; i <= 50; i++)
            {
                Fornecedor fornecedor = new Fornecedor
                {
                    Id = i,
                    Nome = $"Fornecedor {i}",
                    Telefone = $"123456789{i}",
                    Uf = "SP",
                    Cidade = "São Paulo"
                };

                fornecedores.Add(fornecedor);
            }

        }
    }
}
