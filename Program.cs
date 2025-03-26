int adultos, adultosAlc, crianca;
double carne, acompanhamento, cerveja, refrigerante, agua;

Console.WriteLine("---------- Bem vindo ao Churrasco da Família Cunha! ----------\n");

Console.Write("Digite a quantidade de adultos que consomem bebidas alcoólicas....: ");
while (!int.TryParse(Console.ReadLine()!, out adultosAlc) || adultosAlc < 0) 
{
    Console.Write("Quantidade de adultos invalido! Digite a quantidade correta em números (não negativo): ");
}

Console.WriteLine("");

Console.Write("Digite a quantidade de adultos que não consomem bebidas alcoólicas: ");
while (!int.TryParse(Console.ReadLine()!, out adultos) || adultos < 0) 
{
    Console.Write("Quantidade de adultos invalido! Digite a quantidade correta em números (não negativo): ");
}

Console.WriteLine("");

Console.Write("Digite a quantidade de crianças...................................: ");
while (!int.TryParse(Console.ReadLine()!, out crianca) || crianca < 0) 
{
    Console.Write("Quantidade de criança invalido! Digite a quantidade correta em números (não negativo): ");
}

Console.Clear();

carne = ((adultos + adultosAlc) * 0.4) + (crianca * 0.2);
acompanhamento = ((adultos + adultosAlc) * 0.2) + (crianca * 0.2);
cerveja = (adultosAlc * 2);
refrigerante = (adultos * 0.5) + (crianca * 0.5);
agua = ((adultos + adultosAlc) * 0.4) + (crianca * 0.4);

Console.WriteLine("---------- Bem vindo ao Churrasco da Família Cunha! ----------\n");

Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......: {adultosAlc}");

Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...: {adultos}");

Console.WriteLine($"Crianças........................................: {crianca}\n");

Console.WriteLine($"Carne.............: {carne:F1}kg");
Console.WriteLine($"Acompanhamentos...: {acompanhamento:F1}kg");
Console.WriteLine($"Cerveja...........: {cerveja:F1}l");
Console.WriteLine($"Refrigerante......: {refrigerante:F1}l");
Console.WriteLine($"Água..............: {agua:F1}l");
