﻿Retangulo re1 = new Retangulo();
Retangulo re2 = new Retangulo(5);
Retangulo re3 = new Retangulo(4, 6);

Console.WriteLine($"Retangulo 1 Area: {re1.CalcularArea()} e Perimetro: {re1.CalcularPerimetro()}");
Console.WriteLine($"Retangulo 2 Area: {re2.CalcularArea()} e Perimetro: {re2.CalcularPerimetro()}");
Console.WriteLine($"Retangulo 3 Area: {re3.CalcularArea()} e Perimetro: {re3.CalcularPerimetro()}");


re3.Redimensionar(2);
Console.WriteLine($"Retângulo 3 Redimensionado: Área = {re3.CalcularArea()}, Perímetro = {re3.CalcularPerimetro()}");

re2.Redimensionar(10, 15);
Console.WriteLine($"Retângulo 2 Redimensionado: Área = {re2.CalcularArea()}, Perimetro = {re2.CalcularPerimetro()}");

