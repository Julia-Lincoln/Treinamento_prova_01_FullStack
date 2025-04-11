using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using treinamento.Domain;

namespace treinamento.Repositories
{
    public interface ITesteRepositories
    {
        void Salvar(TesteDomain aluno);

        List<TesteDomain> ObterAlunos();

        TesteDomain ObterPorID(int id);

        void Atualizar(int id, TesteDomain aluno);

        void Remover(int id);

    }
}
