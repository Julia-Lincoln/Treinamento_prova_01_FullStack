namespace treinamento.Domain
{
    public class TesteDomain
    {
        public int Id { get; set; }

        public string Nome { get;  set; }

        public decimal Nota { get;  set; }

        private const decimal NOTA_APROVACAO = 7.0m;

        public TesteDomain(string nome, decimal nota)

        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome é obrigatório");

            if (nota < 0 || nota > 10)
                throw new ArgumentException("Nota inválida");

            Nome = nome;
            Nota = nota;

        }
        public bool Aprovado()
        {
            return Nota >= NOTA_APROVACAO;
        }
    }
}
