using avaliacao.Models;

namespace avaliacao.Services
{
    public class ICartinhaRepository
    {
        public List<DadosCartinha> obterTodosDados();
        public DadosCartinha obterDadosPorNome(string nome);
        public void Inserir(DadosCartinha novaCartinha);
    }
}
