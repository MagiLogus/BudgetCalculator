// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário. 

// Algoritimo 
// Entrada: salário recebido / total gasto
// Proscessamento: salário recebido - total gasto

//Entrada 

Console.WriteLine(@$"
--------------------------------
|       Programa para          |
|    calcular seu orçamento    |
|                              |
--------------------------------
");

Console.WriteLine($"Digite seu sálario:");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite seu gasto total:");
float totalGasto = float.Parse(Console.ReadLine());

// Processamento 
float saldo = salario - totalGasto;

// Saida
if(salario>=totalGasto)
{
Console.WriteLine($"Gastos dentro do orçamento !");
}
else
{
Console.WriteLine($"Orçamento estourado !");   
}

Console.WriteLine($"Seu saldo é de: {saldo} Reais"); 
