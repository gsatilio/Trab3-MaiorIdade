//3 - faça um algoritmo que leia a idade de uma pessoa e informe se ela é maior ou menor de idade
int idade;

Console.WriteLine("Por favor, informe a sua idade.");

idade = int.Parse(Console.ReadLine());

if(idade >= 18)
{
    Console.WriteLine("Parabens, voce eh maior de idade!");
}
else
{
    Console.WriteLine("Que pena, voce eh menor de idade!");
}

Console.ReadKey();