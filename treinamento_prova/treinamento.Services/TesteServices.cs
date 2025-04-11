using treinamento.Domain;
using treinamento.Repositories;

namespace treinamento.Services
{
    public class TesteServices : ITesteServices
    {
        private readonly ITesteRepositories _repository;

        public TesteServices(ITesteRepositories testeRepositories)
        {
            _repository = testeRepositories;
        }

        public void Atualizar(int id, decimal nota, string nome)
        {
            var aluno = new TesteDomain(nome, nota);
            _repository.Atualizar(id, aluno);

        }

        public TesteDomain ObterPorId(int id)
        {
            return _repository.ObterPorID(id);
        }

        public List<TesteDomain> ObterTodos()
        {
            return _repository.ObterAlunos();
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public void Salvar(decimal nota, string nome)
        {
            var aluno = new TesteDomain(nome, nota);
            _repository.Salvar(aluno);
        }
    }
}
