using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double nota1;
        double nota2;
        double nota3;
        double nota4;
        double soma;
        double media;
        
        nota1 = inputValue();
        nota2 = inputValue();
        nota3 = inputValue();
        nota4 = inputValue();
        soma = nota1 + nota2 + nota3 + nota4;
        media = soma / 4;
        if (media >= 6)
        {
            Console.WriteLine("Aluno APROVADO com a Nota " + media);
        }
        else
        {
            Console.WriteLine("Aluno REPROVADO com a Nota " + media);
        }
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
