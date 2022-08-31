static void p1001(){
    // EX 1000
    //Console.Write("Hello World!\n");

    int a, b, x;

    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());

    x = a + b;

    Console.Write("X = {0}\n", x);
    //Console.Write("O valor da soma é = {0}\n", x);
}

static void p1002(){

    Console.Write("OK");
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
            
            default:    Console.Write("\nOpção Inválida\n");    break;
        }

    }while( prog != 0 );
    //p1001();
    //p1002();