# Introdução à Programação Orientada a Objetos (POO)

## O que é um Paradigma de Programação?

Um **paradigma de programação** é um modelo ou estilo fundamental de organização do pensamento computacional e da construção de soluções por meio de código. Ele define como os problemas são abordados, estruturados e resolvidos. Segundo Sebesta (2010), um paradigma é “um conjunto de conceitos fundamentais que governam a construção de linguagens e programas”. Os principais paradigmas incluem o imperativo (ex: C), o funcional (ex: Haskell), o lógico (ex: Prolog) e o orientado a objetos.

## O que é POO e suas Vantagens

A **Programação Orientada a Objetos (POO)** é um paradigma centrado na modelagem do mundo real por meio de "objetos", que encapsulam **dados** (atributos) e **comportamentos** (métodos). Essa modelagem é feita por **classes**, que são moldes a partir dos quais objetos são instanciados.

* **Vantagens da POO**:
  - **Modularidade**: o código pode ser dividido em unidades independentes (classes).
  - **Reutilização**: classes e métodos podem ser reaproveitados em diferentes contextos.
  - **Facilidade de manutenção**: alterações em uma classe tendem a ser localizadas e seguras.
  - **Abstração**: oculta detalhes internos e foca no essencial.
  - **Encapsulamento**: protege o estado interno dos objetos, expondo apenas o necessário.

Em resumo, a POO é um paradigma de  programação baseado em objetos, que permite  criar programas mais eficientes, modulares e  fáceis de manter. Ao utilizar a POO, é  possível modelar problemas complexos de forma  mais simples e abstrata, além de possibilitar  a reutilização de código em diferentes  projetos. 

## Classe e Objeto: Diferença Essencial

Uma **classe** é um tipo abstrato que descreve um conjunto de objetos com estrutura e comportamento similares. É um projeto, um molde. Já um **objeto** é uma instância concreta da classe, um elemento real com valores próprios.

> Exemplo: a classe `Carro` define que todos os carros têm cor, modelo e podem acelerar. Um objeto `meuCarro` é uma instância da classe, com cor vermelha e modelo Fusca.

**Classe**: É o conjunto de todos os objetos que seguem a mesma estrutura:
$$
Classe = \{Obj_1, Obj_2, Obj_3, \dots, Obj_N\}
$$
**Objeto**: Membro individual desse conjunto:
$$
Obj \in Classe
$$


## Unicidade, Identidade e Imutabilidade

Todo **objeto é único** — mesmo que dois objetos tenham os mesmos valores de atributos, eles são instâncias distintas na memória, com identidades separadas.

> Isso é conhecido como **identidade** do objeto: dois objetos são diferentes mesmo com os mesmos dados internos.

Essa distinção existe porque cada instância é alocada em um **endereço de memória diferente**. O acesso é feito por **referência** (em linguagens como Java e C#), e não diretamente aos dados.

**Imutabilidade** (quando adotada) refere-se à criação de objetos cujos atributos não podem ser alterados após a criação. É uma prática comum em linguagens como Java (com `final`) ou C# (com `readonly`) para maior segurança e previsibilidade.

## Como os Objetos São Armazenados em Memória?

Em linguagens orientadas a objetos, como Java e C#, ao criar um objeto com `new`, aloca-se memória no **heap**. A variável que referencia o objeto (por exemplo, `Pessoa p = new Pessoa();`) armazena um **ponteiro (ou referência)** para esse espaço de memória. Cada `new` cria uma instância distinta, mesmo com valores iguais.

- Atributos **de instância**: memória separada por objeto.
- Atributos **de classe (static)**: memória compartilhada entre todas as instâncias.

