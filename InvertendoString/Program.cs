using System;

string texto;

Console.WriteLine("Digite um texto ou palavra:");
texto = Console.ReadLine();

Console.WriteLine("Texto Normal: " + texto);

string textoInvertido = new string(texto.Reverse().ToArray());

Console.WriteLine("Texto Invertido: " + textoInvertido);