# 📦 Gerenciamento de Memória e Modelagem de Tipos

Este tema agrupa os conceitos mais importantes sobre como o C# gerencia memória, como os tipos são representados e armazenados, e como eles se comportam em relação à mutabilidade e igualdade.

## 1️⃣ Stack vs Heap

- **Stack:** memória rápida, guarda tipos valor e variáveis locais. Cada chamada de método cria um frame na stack, que é destruído ao sair do método. **Exemplos de tipos:** `int`, `decimal`, `struct`.
- **Heap:** memória para objetos de referência e registros complexos. Objetos vivem na heap até que não existam mais referências → Garbage Collector (GC) remove. **Exemplos:** `class`, `record class`, `string`, `array`.

Exemplo:
```csharp
int x = 10;                      // armazenado na stack
var client = new Client("Ana"); // referência na stack, objeto na heap
```

## 2️⃣ Boxing e Unboxing

- **Boxing:** converte um tipo de valor para tipo de referência (int → object).
- **Unboxing:** o inverso (object → int).

Exemplo:
```csharp
int numero = 42;
object caixa = numero;       // boxing
int extraido = (int)caixa;   // unboxing
```

**Observação: boxing/unboxing cria cópias e pode impactar performance.**

## 3️⃣ Mutabilidade e Imutabilidade

- **Mutável:** o estado pode mudar após criação.
  ```csharp
  var currentAccount = new CurrentAccount(...);
  currentAccount.Balance += 500m; // altera estado
  ```
- **Imutável:** o estado não muda após criação.
  ```csharp
  public record Transaction(decimal value, string transactionType);
  var t = new Transaction(100m, "Depósito");
  // t.Value = 200m; // ❌ não permitido
  ```

**Por que imutabilidade importa:**
- Evita efeitos colaterais.
- Facilita depuração e testes.
- Mais seguro em cenários multithread.

## 4️⃣ Tipos em C#

| Tipo          | Categoria   | Igualdade     | Mutável? | Alocação | Usar quando... |
|---------------|-------------|---------------|----------|----------|----------------|
| class         | Referência  | Por referência| Sim      | Heap     | Estado evolui (ex: CurrentAccount) |
| record class  | Referência  | Por valor     | Pode ser | Heap     | Dados com comparação por valor (ex: DTO) |
| struct        | Valor       | Por valor     | Sim      | Stack    | Estruturas pequenas e performáticas |
| record struct | Valor       | Por valor     | Pode ser | Stack    | Estruturas imutáveis pequenas |
| enum          | Valor       | Por nome/índice | Não    | Stack    | Categorias fixas (ex: TransactionType) |

## 5️⃣ Igualdade: por valor x por referência

Exemplo com class (referência):
```csharp
var c1 = new CurrentAccount(1, "Ana", 1000m);
var c2 = new CurrentAccount(1, "Ana", 1000m);
Console.WriteLine(c1 == c2); // false (instâncias diferentes)
```

Exemplo com record (valor):
```csharp
public record Client(int Id, string Name);
var a = new Client(1, "Ana");
var b = new Client(1, "Ana");
Console.WriteLine(a == b); // true (mesmos valores)
```

## 6️⃣ Boas práticas de uso

- Use record para dados que representam “o que algo é” e merecem comparação por valor.
- Use class para entidades com estado que evolui (ex: saldo).
- Use struct/record struct para estruturas pequenas e sem necessidade de herança.
- Use enum para categorias fixas e previsíveis (ex: tipos de transação).

Exemplo de record class com propriedade mutável:
```csharp
public record class CurrentAccount
{
    public int Number { get; init; }
    public string Holder { get; init; }
    public decimal Balance { get; set; } // mutável
}
```