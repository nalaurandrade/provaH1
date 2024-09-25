using avaliacao.Models;

namespace avaliacao.Services
{
    public class CartinhaRepository : ICartinhaRepository
    {
        private static List<DadosCartinha> dadosCartinhasList = new List<DadosCartinha>();
        public CartinhaRepository() { }
        public void Inserir(DadosCartinha novaCartinha)
        {
            dadosCartinhasList.Add(novaCartinha);
        }
        public DadosCartinha obterCartinhasPorNome(string nome)
        {
            return dadosCartinhasList.FirstOrDefault();
        }
        public List<DadosCartinha> DadosCartinhas()
        {
            return dadosCartinhasList;
        }
    }
}
