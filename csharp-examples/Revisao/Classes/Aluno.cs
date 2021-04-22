namespace Revisao.Classes
{
    public struct Aluno
    {
        private string nome;
        private decimal nota;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public decimal Nota { get => nota; set => nota = value; }
    }
}