## Definição de um Construtor

Um construtor é um método especial de uma classe em C# que é automaticamente chamado quando uma instância da classe é criada usando o operador `new`. Ele tem o mesmo nome da classe e é responsável por inicializar os atributos ou propriedades do objeto, garantindo que ele esteja em um estado válido logo após sua criação.

### Características principais:

- **Nome**: O construtor deve ter exatamente o mesmo nome da classe.
- **Sem tipo de retorno**: Diferentemente de outros métodos, um construtor não possui um tipo de retorno, nem mesmo `void`.
- **Execução**: É executado automaticamente no momento da instanciação do objeto.
- **Modificadores de acesso**: Pode ter modificadores como `public`, `private`, `protected`, ou `internal`. O mais comum é `public` para permitir a criação de objetos fora de sua classe.
- **Objetivo**: Garantir que o objeto seja inicializado com valores válidos ou execute configurações necessárias.

**Exemplo:**

```c#
class Carro 
{
    public string Modelo;
    public int Ano;

    // Construtor
    public Carro() 
    {
		Modelo = "Desconhecido";
    	Ano = 2023;
    }
}
```

No exemplo acima, o construtor `Carro()` inicializa o objeto com valores  padrão para `Modelo` e `Ano`.

---

## Criação de um Construtor

Um construtor é criado como um método dentro da classe, com o mesmo nome da classe e sem tipo de retorno. Ele pode ou não receber parâmetros, dependendo da necessidade.

**Sintaxe básica:**

```c#
[modificador] NomeDaClasse([parâmetros]) {
    // Código de inicialização
}
```

**Exemplo:**

```c#
class Carro {
    public string Modelo;
    public int Ano;

    // Construtor sem parâmetros
    public Carro() {
        Modelo = "Fusca";
        Ano = 1970;
    }
}
```

**Instanciação:**

```c#
// Chama o construtor
Carro meuCarro = new Carro(); 

// Saída: Modelo: Fusca, Ano: 1970
Console.WriteLine($"Modelo: {meuCarro.Modelo}, Ano: {meuCarro.Ano}");
```

Aqui, o construtor `Carro()` é chamado automaticamente ao criar um objeto com `new Carro()`, inicializando os campos com valores definidos.

---

## Assinatura de um Construtor - Mudar de local

A assinatura de um construtor (ou de qualquer método) é a combinação de seu nome e sua lista de parâmetros (incluindo o tipo e a ordem dos parâmetros). A assinatura é usada pelo compilador para identificar de forma única um construtor ou método dentro de uma classe.

### Componentes da assinatura:

- **Nome** do construtor: Igual ao nome da classe.
- **Parâmetros**: Tipos, ordem e número de parâmetros (se houver).

**Exemplo:**

```c#
class Carro {
    public string Modelo;
    public int Ano;

    // Construtor com parâmetros
    public Carro(string modelo, int ano) {
        Modelo = modelo;
        Ano = ano;
    }
}
```

**Assinatura:** `Carro(string, int)`

A assinatura permite que o compilador diferencie construtores quando há sobrecarga (múltiplos construtores com diferentes parâmetros na mesma classe).

### Onde a assinatura é usada?

- **Identificação única**: O compilador usa a assinatura para determinar qual construtor chamar com base nos argumentos fornecidos durante a instanciação.
- **Sobrecarga**: Permite definir vários construtores com diferentes parâmetros, desde que suas assinaturas sejam únicas.

---

## Construtor Padrão (Sem Parâmetros)

Se uma classe não define explicitamente nenhum construtor, o C# fornece automaticamente um construtor padrão (ou construtor implícito) sem parâmetros. Esse construtor inicializa todos os campos e propriedades da classe com seus valores padrão, conforme definido pela linguagem.

### Características do construtor padrão:

- **Automático**: Criado pelo compilador se nenhum construtor for definido.
- **Sem parâmetros**: Não aceita argumentos.
- **Inicialização padrão**: Define valores padrão para os campos (ex.: `null` para tipos de referência, `0` para inteiros, etc.).

**Exemplo:**

```c#
class Carro {
    public string Modelo; // null
    public int Ano;       // 0
    public bool Disponivel; // false
}

Carro meuCarro = new Carro();
Console.WriteLine($"Modelo: {meuCarro.Modelo}, Ano: {meuCarro.Ano}, Disponível: {meuCarro.Disponivel}");
// Saída: Modelo: null, Ano: 0, Disponível: False
```

**Nota**: Se você definir pelo menos um construtor na classe, o construtor padrão **não** será fornecido automaticamente pelo compilador.

A tabela abaixo lista os valores padrão para os principais tipos em C#.

| **Tipo**                                      | **Valor Padrão**                                             |
| --------------------------------------------- | ------------------------------------------------------------ |
| Tipos de referência (`string`, classes, etc.) | `null`                                                       |
| Inteiros (`int`, `short`, `long`, etc.)       | `0`                                                          |
| Ponto flutuante (`float`, `double`)           | `0.0`                                                        |
| `bool`                                        | `false`                                                      |
| `char`                                        | `'\0'` (caractere nulo, U+0000)                              |
| `enum`                                        | `(E)0`, onde `E` é o tipo do enum                            |
| `struct`                                      | Todos os campos de valor inicializados com seus valores padrão; campos de referência inicializados com `null` |
| Tipos anuláveis (`int?`, `double?`, etc.)     | `null` (propriedade `HasValue` é `false`)                    |

Consultar a documentação para mais detalhes.

[Valores padrão de tipos integrados | Microsoft Learn](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/default-values)

---

