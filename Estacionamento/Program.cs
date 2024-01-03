// See https://aka.ms/new-console-template for more information
using Estacionamento;
using static System.Runtime.InteropServices.JavaScript.JSType;

float valorInicial;
float valorHora;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial: ");

valorInicial = float.Parse(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora: ");

valorHora = float.Parse(Console.ReadLine());

Estacionamento
