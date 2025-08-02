int resultado;  // Declaração sem inicialização

CalcularQuadrado(5, out resultado);
Console.WriteLine($"O quadrado é: {resultado}");

static void CalcularQuadrado(int numero, out int quadrado)
{
    quadrado = numero * numero;
}
