
namespace Aplicativo03
{
    internal class Aluno
    {
        // Campos
         string nome;
         double nota1;
         double nota2;
         double nota3;
        // Construtor
        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }
        // Métodos
        public double NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }
        public bool Aprovado()
        {
            return NotaFinal() >= 60.0;
        }
        public double PontosFaltando()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }   
        public void ExibirDados()
        {
            Console.WriteLine($"Aluno: {nome}\n" +
                $"Nota Final: {NotaFinal():F2}\n" +
                $"Situação: {(Aprovado() ? "Aprovado" : "Reprovado")}");
            if (!Aprovado())
            {
                Console.WriteLine($"Pontos faltando: {PontosFaltando():F2}");
            }
        }

    }
}
