//  Aula 01
//  int = Inteiro
//  Criando uma variável
/*
    int     = inteiro   32bits
    float   = real  32bits
    double  = real  64bits
    decimal = real  92bits

*/
double salario;

//  Escreve na tela
Console.Write("Digite o seu salário: ");


//  String = Letras ou palavras
//  Console.ReadLine() = Ler a informação do usuario 
salario = Convert.ToDouble(Console.ReadLine());

Console.Write("Valor em R$ = {0}",salario.ToString("0.00"));
//  salario.ToString("0.00") = Definir padrão de exibição