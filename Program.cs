string opcao = "", nome = "";
decimal saldo = 0, chequeEspecial = 0; 
bool iscontacriada = false;

const string TITULO = "---- MongaBank - Seu dinheiro rende mais! ----";

const string MENU = @"Selecione uma opção abaixo:

0 - Abrir Conta Corrente
1 - Saldo
2 - Saque
3 - Depósito
4 - Encerrar conta e sair

Opção:";

Console.Clear();

while (true)
{
    Console.WriteLine(TITULO);
    Console.Write(MENU);

    opcao = Console.ReadLine()!.Trim().Substring(0,1);
    Console.WriteLine($"Opção informada: {opcao}");

if (opcao == "0")
{
    Console.Clear();
    Console.WriteLine(TITULO);
    Console.Write("Nome: ");
    nome = Console.ReadLine()!;

    Console.Write("Depósito inicial: ");
    saldo = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Cheque especial: ");
    chequeEspecial = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine($"Bem Vindo, {nome}.");
    Console.WriteLine($"Seu saldo é de {saldo:C2}.");
    Console.WriteLine($"Seu Limite de cheque especial é de {chequeEspecial:C2}. \n");
    iscontacriada = true;
}
else if (iscontacriada == false)
{
    Console.WriteLine("A abertura da conta é obrigatortoria!");
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadKey(true);
continue;
}


else
{
 Console.Clear();
 Console.WriteLine(TITULO);
 Console.WriteLine($"CLIENTE: {nome}");
        
    if (opcao == "1"){
    Console.WriteLine ($"seu saldo é de: {saldo:C2}");
    Console.WriteLine ($"Limite de cheque especial: {chequeEspecial:C2}");
    }
    
else if (opcao == "2")
    {
        Console.Write("Informe um valor para saque: ");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());  
    
    bool valorEhValido = valorSaque > 0;
    bool LimiteSuficiente = saldo + chequeEspecial >= valorSaque;
    bool estaUsandoLimite = valorSaque > saldo;
    
    if(!valorEhValido)
        {
            Console.WriteLine("-> Não foi possível realizar sua operação ");
        }

        else if(!LimiteSuficiente)
        {
            Console.WriteLine("-> Seu limite atual não permite esta operação!");
        }


else
{
    if (!estaUsandoLimite)
 {
Console.WriteLine("-> Você está utilizando seu cheque especial");
}
        
saldo -= valorSaque;
Console.WriteLine("Saque efetuado com sucesso.");
Console.WriteLine($"-> Seu saldo é de {saldo:C2}");
        }

}


else if (opcao == "3")
    {
        Console.Write("Informe um valor para depósito: ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        bool valorEhValido = valorDeposito > 0;
        if(!valorEhValido)
            {
                Console.WriteLine("-> Não foi possível realizar sua operação. Tente novamente");
            }
    else
            {
                saldo += valorDeposito;
                Console.WriteLine("Depósito efetuado com sucesso.");
            Console.WriteLine($"-> Seu saldo é de {saldo:C2}");
            }
    }






else if (opcao == "4")
    {
        Console.WriteLine("Obrigado por utilizar nossos serviços");
Console.WriteLine($"-> Valor a receber: {saldo:C2}");
        break;
    }
else
    {
          Console.WriteLine("Opção Invalida!!");

    }

}
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadKey(true);

}


