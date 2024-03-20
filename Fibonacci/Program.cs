using System;


{
    int primeiroNumero = 0;
    int segundoNumero = 1;
    int proximoNumero = 0;
    int termo;

    Console.WriteLine("Digite número de termos para Sequência de Fibonacci:");
    termo = Convert.ToInt32(Console.ReadLine());

        
    Console.Write("{0},{1}", primeiroNumero, segundoNumero);
    
    for (int i = 2; i < termo; i++)
    {
        proximoNumero = primeiroNumero + segundoNumero;
        

        Console.Write(",{0}", proximoNumero);

        primeiroNumero = segundoNumero;
        segundoNumero = proximoNumero;

    }

  
}