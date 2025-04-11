using treinamento.Domain;

namespace treinamento.Repositories
{
    public class TesteRepositories : ITesteRepositories
    {
        private readonly AppDbContext _context;

        public TesteRepositories(AppDbContext context)
        {
            _context = context;
        }
        public void Atualizar(int id, TesteDomain aluno)
        {
            var a = ObterPorID(id);
            a.Nota = aluno.Nota;
            a.Nome = aluno.Nome;
            _context.SaveChanges();
        }

        public List<TesteDomain> ObterAlunos()
        {
            return _context.Alunos.ToList();
        }

        public TesteDomain ObterPorID(int id)
        {
            var aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);

            if (aluno == null)
            {
                throw new Exception("Aluno não encontrado");
            }
            return aluno;
        }

        public void Remover(int id)
        {
            var aluno = ObterPorID(id);
            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
        }

        public void Salvar(TesteDomain aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }
    }
}
