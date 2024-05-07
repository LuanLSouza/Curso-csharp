
using Fundamentos.Models;

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 10;
arrayInteiros[2] = 5;   

foreach (int item in arrayInteiros)
{
    Console.WriteLine(item);
} 

// Calculadora calc = new Calculadora();

// (int, int) LerNumeros()
// {
//     Console.WriteLine("Digite o primeiro número:");
//     int num1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Digite o segundo número:");
//     int num2 = Convert.ToInt32(Console.ReadLine());
//     return (num1, num2);
//  }

// string opcao;
// int numero1 = 0;
// int numero2 = 0;
// bool exibirMenu = true;

// while(exibirMenu)
// {   
//     Console.WriteLine("\n");
//     Console.WriteLine("Selecione uma opção:");
//     Console.WriteLine("1 - Soma");
//     Console.WriteLine("2 - Subtração");
//     Console.WriteLine("3 - Multiplição");
//     Console.WriteLine("4 - Divisão");
//     Console.WriteLine("5 - Potência");
//     Console.WriteLine("6 - Raiz Quadrada");
//     Console.WriteLine("7 - Seno");
//     Console.WriteLine("8 - Cosseno");
//     Console.WriteLine("9 - Tangente");
//     Console.WriteLine("10 - Sair");

//     opcao = Console.ReadLine() ?? "";

//     switch(opcao)
//     {
//         case "1":
//             (numero1, numero2) = LerNumeros();
//             calc.Somar(numero1, numero2);    
//             break;

//         case "2":
//             (numero1, numero2) = LerNumeros();
//             calc.Subtrair(numero1, numero2);   
//             break;
        
//         case "3":
//             (numero1, numero2) = LerNumeros();
//             calc.Mutiplicar(numero1, numero2);   
//             break;

//         case "4":
//             (numero1, numero2) = LerNumeros();
//             calc.Dividir(numero1, numero2);   
//             break;
        
//         case "5":
//             (numero1, numero2) = LerNumeros();
//             calc.Potencia(numero1, numero2);   
//             break;
        
//         case "6":
//             Console.WriteLine("Digite o número:");
//             numero1 = Convert.ToInt32(Console.ReadLine());
//             calc.RaizQuadrada(numero1);   
//             break;
        
//         case "7":
//             Console.WriteLine("Digite o ângulo:");
//             numero1 = Convert.ToInt32(Console.ReadLine());
//             calc.Seno(numero1);   
//             break;
        
//         case "8":
//             Console.WriteLine("Digite o ângulo:");
//             numero1 = Convert.ToInt32(Console.ReadLine());
//             calc.Coseno(numero1);   
//             break;
        
//         case "9":
//             Console.WriteLine("Digite o ângulo:");
//             numero1 = Convert.ToInt32(Console.ReadLine());
//             calc.Tangente(numero1);   
//             break;

//         case "10":
//             Console.WriteLine("Encerrando\n");
//             exibirMenu = false;
//             break;

//         default:
//             Console.WriteLine("Opção inválida\n");
//             break; 
//     }
// }

// int numero = 0;
// int soma = 0;
// do
// {
//     Console.WriteLine("Digite um número: (0 para sair)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma = soma + numero;

// }while(numero != 0);

// Console.WriteLine($"A soma dos números é: {soma}");

// //While
// int numero = 5;
// int contador = 0;
// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// }

//For
// int numero = 5;

// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }
//Calculadora calc = new Calculadora();

// calc.Somar(20, 30);
// calc.Dividir(10, 2);
// calc.Mutiplicar(5, 5);
// calc.Subtrair(10, 5);
// calc.Potencia(2, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

// int numero = 10;
// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o número..."); 
// numero++;
// Console.WriteLine(numero);





// Console.WriteLine("Digite uma letra");
// string ?letra = Console.ReadLine();

// switch (letra.ToLower())
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Consoante");
//         break;
// }




// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool estoqueDisponivel = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade a comprar: {quantidadeCompra}");
// Console.WriteLine($"Estoque disponível: {estoqueDisponivel}");

// if (estoqueDisponivel && quantidadeCompra > 0)
// {
//     Console.WriteLine("Compra realizada com sucesso!");
// }
// else
// {
//     Console.WriteLine("Quantidade insuficiente em estoque.");
// }





// DateTime dataAtual = DateTime.Now;

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

// int a = 10;
// double pi = 3.1415;
// decimal preco = 1.80m;

// Console.WriteLine(a);
// Console.WriteLine(pi);
// Console.WriteLine(preco);
// // Pessoa p = new Pessoa();
// // p.Nome = "João";
// // p.Idade = 20;
// // p.Apresentar(); // Olá! Me chamo João e tenho 20 anos.

