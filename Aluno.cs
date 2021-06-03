namespace Revisão
{
    public struct Aluno
    {
        public string Nome { get; set; }
        public decimal Nota { get; set; }
        public Aluno(string nome, decimal nota)
        {
            this.Nome = nome;
            this.Nota = nota;
        }
    }
}