static void p1001(){
    // Problema 1001

    int a, b, x;

    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());

    x = a + b;

    Console.Write("X = {0}\n", x);
    //Console.Write("O valor da soma é = {0}\n", x);
}

static void p1002(){
    //  PROGRAMA 1002

    double area, raio;

    raio = Convert.ToDouble(Console.ReadLine());

    area = 3.14159 * Math.Pow(raio, 2.0);
    //area = 3.14159 * (raio * raio);
    
    Console.Write("A={0}\n", area.ToString("0.0000"));
}

static void p1003(){
    //  PROGAMA 1003
    int a, b, soma;

    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());

    soma = a + b;

    Console.Write("SOMA = {0}\n", soma);
        
}

static void p1005(){
    //  PROGRAMA 1005
    double a, b, media;

    a = Convert.ToDouble(Console.ReadLine());
    b = Convert.ToDouble(Console.ReadLine());

    media = ( a * 3.5 + b * 7.5 ) / ( 3.5 + 7.5 );

    Console.Write("MEDIA = {0}\n", media.ToString("0.00000"));
}

static void p1010(){

    //  PROGRAMA 1010

    string linha1, linha2;
    int cod1;

    // 12 5 5,30 
    linha1 = Console.ReadLine();    
    
    //  ler a linha 1
    string[] valor = linha1.Split(" ");         //valor[0] = 12     valor[1] = 5    valor[2] = 5,30   
    cod1 = Convert.ToInt32(valor[0]);

}

//  INICIO DO PROGRAMA

    
    int prog;
    Console.Clear();
    do{
        
        Console.Write("\nGerenciador de programas:\n");
        Console.Write("\n\t| 0 para sair |\nDigite o programa desejado: ");
        prog = Convert.ToInt32(Console.ReadLine());
        if ( prog == 0 ){
            Console.Write("\nObrigado por utilizar nossos programas.\n");
            break;
        }

        switch ( prog ){
            case 1001:  p1001();    break;
            case 1002:  p1002();    break;
            case 1003:  p1003();    break;
            case 1005:  p1005();    break;
            
            default:    Console.Write("\nOpção Inválida\n");    break;
        }

    }while( prog != 0 );
