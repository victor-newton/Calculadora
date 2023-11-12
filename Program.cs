
using System.Diagnostics;
using System.Runtime.CompilerServices;

Console.Clear();
MenuPrincipal();

void Soma (){
    Console.Clear();

    Console.WriteLine($"Digite o Valor 1:");
    int valor1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Digite o Valor 2:");
    int valor2 = int.Parse(Console.ReadLine()!);

    int resultado = valor1 + valor2;

    Console.WriteLine($"O resultado da soma de {valor1} + {valor2} é {resultado}");

    Console.Write("\nDigite qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();
    
}

void Subtracao(){
    Console.Clear();

    Console.WriteLine($"Digite o Valor 1:");
    int valor1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Digite o Valor 2:");
    int valor2 = int.Parse(Console.ReadLine()!);

    int resultado = valor1 - valor2;

    Console.WriteLine($"O resultado da subtração de {valor1} - {valor2} é {resultado}");

    Console.Write("\nDigite qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();
}

void Multiplicacao (){
    Console.Clear();

    Console.WriteLine($"Digite o Valor 1:");
    int valor1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Digite o Valor 2:");
    int valor2 = int.Parse(Console.ReadLine()!);

    int resultado = valor1 * valor2;

    Console.WriteLine($"O resultado da multiplicação de {valor1} * {valor2} é {resultado}");

    Console.Write("\nDigite qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();
}

void Divisao (){
    Console.Clear();

    Console.WriteLine($"Digite o Dividendo:");
    int valor1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Digite o Divisor:");
    int valor2 = int.Parse(Console.ReadLine()!);

    int resultado = valor1 / valor2;

    Console.WriteLine($"O quociente de {valor1} / {valor2} é {resultado}");

    Console.Write("\nDigite qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();
}

void RestoDivisao(){
    Console.WriteLine($"Digite o Dividendo:");
    int valor1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Digite o Divisor:");
    int valor2 = int.Parse(Console.ReadLine()!);

    int resultado = valor1 % valor2;

    Console.WriteLine($"O resto da divisao de {valor1} / {valor2} é {resultado}");

    Console.Write("\nDigite qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();
}

void Potenciacao(){
    Console.Clear();
    Console.Write($"Digite a base: ");
    int valor1 = int.Parse(Console.ReadLine()!);
    Console.Write($"Digite o expoente: ");
    int valor2 = int.Parse(Console.ReadLine()!);

    if (valor2 == 0){
        Console.WriteLine($"A potencia {valor1} elevado a {valor2} é 1");

        Console.Write("\nDigite qualquer tecla para voltar ao menu principal...");
        Console.ReadKey();
        Console.Clear();
        MenuPrincipal();
    }
    else if (valor2 == 1) {
        Console.WriteLine($"A potencia {valor1} elevado a {valor2} é {valor1}");
        Console.Write("\nDigite qualquer tecla para voltar ao menu principal...");
        Console.ReadKey();
        Console.Clear();
        MenuPrincipal();
    }
    else {
        int resultado = valor1;

        int i=0;
        
        do{
            resultado = resultado * valor1;
            i++;
        }
        while(i <= valor2-2);
        
        Console.WriteLine($"A potencia {valor1} elevado a {valor2} é {resultado}");
        Console.Write("\nDigite qualquer tecla para voltar ao menu principal...");
        Console.ReadKey();
        Console.Clear();
        MenuPrincipal();
    }


}

void MenuPrincipal (){
    Console.WriteLine($"**************");
    Console.WriteLine($"CALCULADORA");
    Console.WriteLine($"**************\n");

    Console.WriteLine($"1 - Soma");
    Console.WriteLine($"2 - Subtracao");
    Console.WriteLine($"3 - Multiplicacao");
    Console.WriteLine($"4 - Divisao");
    Console.WriteLine($"5 - Resto divisão");
    Console.WriteLine($"6 - Potência");

    Console.Write($"\nSelecione a opção desejada:");
    int opcao = int.Parse(Console.ReadLine()!);

    switch(opcao){
        case 1: Soma();
        break;  
        case 2: Subtracao();
        break;
        case 3: Multiplicacao();
        break;
        case 4: Divisao ();
        break;
        case 5: RestoDivisao();
        break;
        case 6: Potenciacao();
        break;
        case 0: MenuPrincipal();
        break;
    }

}