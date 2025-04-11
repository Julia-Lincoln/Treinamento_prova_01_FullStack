using treinamento.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treinamento.Services
{
    public interface ITesteServices
    {
        void Atualizar(int id, decimal nota, string nome);

        void Salvar(decimal nota, string nome);

        void Remover(int id);

        List<TesteDomain> ObterTodos();

        TesteDomain ObterPorId(int id);
    }
}
