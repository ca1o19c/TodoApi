namespace _03_ExercicioEscola
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            a.nome = "Caio";
            a.nota1 = 8.9;
            a.nota2 = 9.7;

            a.Mensagem();
        }
    }
}
