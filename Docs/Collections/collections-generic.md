# 🗂️ Coleções Genéricas (Collections Generic)

**Generics** são um jeito de escrever código reutilizável e seguro em relação a tipos. Em vez de criar uma classe, método ou coleção para cada tipo de dado (ex: `int`, `string`, `Client`), você cria um **modelo genérico, que aceita qualquer tipo — mas ainda mantém a segurança de tipos do C#** (ou seja, o compilador te protege de erros de tipo).

**Exemplo básico (antes e depois)**

**Sem Generics:**

```csharp
ArrayList lista = new ArrayList();
lista.Add("texto");
lista.Add(123); // compila, mas pode dar erro depois!
```

**Com Generics:**
```csharp
List<string> nomes = new List<string>();
nomes.Add("Paula");
// nomes.Add(123); ❌ erro de compilação
```

Com Generics, o tipo é definido em tempo de compilação, evitando erros de conversão e tornando o código mais rápido e seguro.

## Por que usar Generics

**Vantagens principais:**

- **Segurança de tipo** – o compilador impede que você adicione tipos errados.
- **Performance** – evita boxing/unboxing (conversão implícita de tipos).
- **Reuso de código** – você escreve um único modelo e usa com qualquer tipo.
- **Legibilidade e manutenção** – o código fica mais limpo e claro.

## Desvantagens ou limitações dos Genéricos

Embora generics sejam ótimos, há alguns pontos:

| Situação | Problema   |
|-------------------|--------------------------|
| Tipos diferentes demais | Se cada tipo genérico for muito diferente, o código pode ficar complexo de manter |
| Reflexão e serialização | Operações com reflexão (ex: typeof(T)) e serialização podem ser mais difíceis |
| Restrições excessivas | Usar muitas constraints torna o código rígido e menos reutilizável |
| Sobrecarga de métodos | Pode causar confusão entre versões genéricas e não genéricas |


Mas no geral, as vantagens superam as desvantagens.Evite apenas usar generics “só por usar” — eles têm propósito: reutilização e segurança de tipos.

## Tipos de coleção genérica mais usados

| Coleção | Descrição |
|---------|-----------|
| List<T> | Lista dinâmica indexada |
| Dictionary<TKey, TValue> | Mapa de chave-valor |
| HashSet<T> | Conjunto sem duplicatas |
| Queue<T> | Fila (FIFO) |
| Stack<T> | Pilha (LIFO) |
| LinkedList<T> | Lista encadeada |
| SortedList<TKey, TValue> | Lista ordenada por chave |
| ObservableCollection<T> | Lista que notifica mudanças (usada em UI) |
| ConcurrentDictionary<TKey, TValue> | Dicionário seguro para multithread |

## Exemplo práticos 

### List<T>

```csharp
List<string> names = new List<string>();
names.Add("Ana");
names.Add("Carlos");
names.Add("Beatriz");

Console.WriteLine($"First names {names[0]}");
Console.WriteLine($"Total number of names: {names.Count}");

// Iterando
foreach (var name in names)
{
    Console.WriteLine(name);
}

// Removendo
names.Remove("Carlos");
```

**Pense na `List<T>` como uma caixa elástica que cresce e guarda itens ordenadamente.**

### Dictionary<TKey, TValue>

```csharp
Dictionary<int, string> accounts = new Dictionary<int, string>();
accounts.Add(123, "Paula");
accounts.Add(456, "Marcos");

// Acessar valor pela chave
Console.WriteLine(accounts[123]);

// Verificar se existe
if (accounts.ContainsKey(999))
    Console.WriteLine("Account exists");
else
    Console.WriteLine("Accounts do not exist");
```

**Pense no `Dictionary` como um “mapa”: cada chave aponta para um valor.**

### HashSet<T> — Conjunto sem duplicatas

```csharp
HashSet<string> cpfs = new HashSet<string>();

cpfs.Add("12345678900");
cpfs.Add("98765432100");
cpfs.Add("12345678900"); // duplicata — será ignorada

Console.WriteLine($"Total number of CPF: {cpfs.Count}");

foreach (var cpf in cpfs)
{
    Console.WriteLine(cpf);
}

// Verifica se contém
if (cpfs.Contains("12345678900"))
    Console.WriteLine("CPF found!");
```

**Pense no `HashSet<T>` como uma “lista com filtro automático”: ele não deixa você guardar valores repetidos — como uma caixa que rejeita cópias.**

### Queue<T> — Fila (FIFO)

```csharp
Queue<string> queue = new Queue<string>();

queue.Enqueue("Client 1");
queue.Enqueue("Client 2");
queue.Enqueue("Client 3");

// Remove o primeiro da fila
var served = queue.Dequeue();
Console.WriteLine($"{served} was attended.");

// Olhar o próximo da fila sem remover
Console.WriteLine($"Next: {queue.Peek()}");
```

**Pense na `Queue<T>` como uma fila de banco:quem chega primeiro é atendido primeiro (First In, First Out).**

### Stack<T> — Pilha (LIFO)

```csharp
Stack<string> stack = new Stack<string>();

stack.Push("Dish 1");
stack.Push("Dish 2");
stack.Push("Dish 3");

// Remove o último elemento adicionado
var top = stack.Pop();
Console.WriteLine($"{top} it was removed from the top.");

// Ver o topo sem remover
Console.WriteLine($"Now the top is: {stack.Peek()}");
```

**Pense na `Stack<T>` como uma pilha de pratos: o último que entra é o primeiro que sai (Last In, First Out).**

### LinkedList<T> — Lista encadeada

```csharp
LinkedList<string> names = new LinkedList<string>();

var first = names.AddFirst("Ana");
var last = names.AddLast("Carlos");
nomes.AddAfter(first, "Beatriz");

foreach (var name in names)
{
    Console.WriteLine(name);
}
```
**Pense na `LinkedList<T>` como uma corrente: cada elo (nó) sabe quem vem antes e quem vem depois, facilitando inserções e remoções no meio.**

### SortedList<TKey, TValue> — Lista ordenada por chave

```csharp
SortedList<int, string> clients = new SortedList<int, string>();

clients.Add(3, "Carlos");
clients.Add(1, "Ana");
clients.Add(2, "Beatriz");

// Os itens são automaticamente ordenados pela chave
foreach (var c in clients)
{
    Console.WriteLine($"{c.Key}: {c.Value}");
}
```

**Pense na `SortedList<TKey, TValue>` como um “dicionário organizado”: tudo fica automaticamente em ordem crescente da chave.**

### ObservableCollection<T> — Lista que notifica mudanças (UI)

```csharp
using System.Collections.ObjectModel;

ObservableCollection<string> products = new ObservableCollection<string>();

products.CollectionChanged += (s, e) =>
{
    Console.WriteLine($"Change detected: {e.Action}");
};

products.Add("Teclado");
products.Add("Mouse");
products.Remove("Teclado");
```

**Pense na `ObservableCollection<T>` como uma lista “falante”: ela avisa quando algo muda, ideal para interfaces gráficas (UI, WPF, MAUI).**

### ConcurrentDictionary<TKey, TValue> — Dicionário seguro para multithread

```csharp
using System.Collections.Concurrent;

ConcurrentDictionary<int, string> users = new ConcurrentDictionary<int, string>();

users.TryAdd(1, "Ana");
users.TryAdd(2, "Carlos");

// Atualiza ou adiciona de forma segura
users.AddOrUpdate(1, "Beatriz", (key, oldValue) => "Beatriz");

// Acesso concorrente seguro
Parallel.ForEach(users, user =>
{
    Console.WriteLine($"{user.Key}: {user.Value}");
});
```
**Pense no `ConcurrentDictionary` como um “dicionário com segurança de trânsito”: várias threads podem ler e escrever sem bater umas nas outras.**

## Criando sua própria classe Genérica

Você também pode criar suas próprias classes genéricas.

```csharp
public class Box<T>
{
    public T Content { get; set; }

    public void ShowContent()
    {
        Console.WriteLine($"Content: {Content}");
    }
}
```

E usar assim:

```csharp
var textBox = new Box<string> { Content = "Hello!" };
var numberBox = new Box<int> { Content = 42 };

textBox.ShowContent(); // Conteúdo: Hello!
numberBox.ShowContent(); // Conteúdo: 42
```

## Métodos Genéricos

Você também pode criar métodos que funcionam com qualquer tipo.

```csharp
public void Show<T>(T value)
{
    Console.WriteLine($"Value: {value}");
}
```

Uso:

```csharp
Show<int>(10);
Show<string>("Generic text");
```

O compilador infere o tipo automaticamente:

```csharp
Mostrar("Text"); // <string> é deduzido
```
## Interface Genérica

Da mesma forma, interfaces também podem ser genéricas:

```csharp
public interface IRepositoy<T>
{
    void Add(T item);
    T GetById(int id);
}
```

E depois você implementa:
```csharp
public class RepositoryClient : IRepository<Client>
{
    public void Add(Client item) { ... }
    public Client GetById(int id) => ...;
}
```

## Restrições de tipo (Constraints)

Às vezes você quer limitar quais tipos podem ser usados com T.

```csharp
public class Repository<T> where T : BaseEntity
{
    public void Save(T entity)
    {
        Console.WriteLine($"Saving {entity.Id}");
    }
}
```

### Tipos de restrição possíveis:

| Restrição | Significado |
|---------|-----------|
| where T : class |	Somente tipos referência |
| where T : struct | Somente tipos valor |
| where T : new() |	Precisa ter construtor público sem parâmetros |
| where T : BaseClass |	Precisa herdar de BaseClass |
| where T : IInterface | Precisa implementar IInterface |

## Comparando Generics e não-Generics

| Aspecto |	ArrayList (antigo) |	List<T> (Genérico) |
|---------|-----------|-----------|
| Tipo dos itens | object (qualquer tipo) |	definido em <T> |
| Segurança de tipo | baixa | alta |
| Conversão (casting) |	necessária | desnecessária |
| Performance |	menor (boxing/unboxing) | maior |
| Uso recomendado |	❌ legado |	✅ atual |

## Resumo conceitual

- **Generics** = tipo genérico (reutilizável e seguro).
- `T` é um parâmetro de tipo, substituído por um tipo real.
- C# possui coleções **genéricas modernas (List<T>, Dictionary<,>, etc).**
- Você pode criar classes, interfaces e métodos genéricos.
- Pode aplicar **restrições (constraints)** para controlar o tipo aceito.
- Vantagem: reuso, segurança, performance.
- Cuidado: complexidade desnecessária, uso sem propósito.

## Referências
[Microsoft - Generics](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/generics/)