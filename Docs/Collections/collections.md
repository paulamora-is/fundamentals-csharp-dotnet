# 🗂️ Coleções

**Coleções (collections)** são estruturas de dados que permitem armazenar, organizar e manipular conjuntos de elementos na memória. O .NET oferece diversos tipos de coleções, agrupadas por propósito e comportamento.

## 1️⃣ **Coleções não genéricas**:
**Namespace:** `System.Collections`

Essas coleções foram introduzidas antes do C# ter suporte a **tipos genéricos.**  
Elas armazenam elementos como `object`, o que significa que você pode **guardar qualquer tipo, mas perde a segurança de tipo** e precisa fazer casting manual.

- `ArrayList` - lista dinâmica que armazena objetos sem tipo definido.  
- `Hashtable` - dicionário baseado em chave e valor.  
- `Queue` (não genérica) - fila (FIFO).  
- `Stack` (não genérica) - pilha (LIFO).  
- **Limitações:** conversões de tipo (`boxing`/`unboxing`), menor performance e ausência de tipagem forte.

[Saiba Mais]()

## 2️⃣ **Coleções genéricas**
**Namespace:** `System.Collections.Generic`

Introduzidas no .NET 2.0, permitem **definir o tipo de elemento armazenado (`<T>`)**, garantindo segurança de tipo, melhor performance e eliminação de castings.

- **Conceito de genéricos:** `T`, `TKey`, `TValue`  
- **List<T>** - lista dinâmica e ordenada.  
- **Dictionary<TKey, TValue>** - pares chave-valor com busca rápida.  
- **HashSet<T>** - coleção que não permite duplicatas.  
- **Queue<T>** - fila (FIFO).  
- **Stack<T>** - pilha (LIFO).  
- **Interfaces genéricas:**
  - `IEnumerable<T>` - iteração básica.
  - `ICollection<T>` - operações de coleção (adicionar, remover, contar).
  - `IList<T>` - acesso por índice.
  - `IDictionary<TKey, TValue>`- operações baseadas em chave.
- **Benefícios:**
  - Tipagem forte (sem casts).
  - Performance melhor (sem boxing/unboxing).
  - Reuso e flexibilidade com genéricos.

  [Saiba Mais](collections-generic.md)

## 3️⃣ **Coleções concorrentes**
**Namespace:** `System.Collections.Concurrent`

Projetadas para ambientes **multithread**, onde várias threads podem acessar ou modificar a coleção simultaneamente.  
Elas já tratam sincronização interna, evitando erros de concorrência.

- **Motivação:** segurança em acesso concorrente.
- **Principais tipos:**
  - `ConcurrentBag<T>` — coleção não ordenada e thread-safe.
  - `ConcurrentQueue<T>` — fila thread-safe (FIFO).
  - `ConcurrentStack<T>` — pilha thread-safe (LIFO).
  - `ConcurrentDictionary<TKey, TValue>` — dicionário thread-safe.
- **Uso prático:** aplicações assíncronas, sistemas de log, filas de processamento e APIs paralelas.

 [Saiba Mais]()

## 4️⃣ **Coleções imutáveis**
**Namespace:** `System.Collections.Immutable`

Essas coleções **não podem ser modificadas** após a criação.  
Qualquer operação que "altere" a coleção cria uma nova versão, preservando a anterior.

- **Imutabilidade:** segurança, previsibilidade e paralelismo seguro.
- **Principais tipos:**
  - `ImmutableList<T>`
  - `ImmutableDictionary<TKey, TValue>`
  - `ImmutableHashSet<T>`
  - `ImmutableQueue<T>`
  - `ImmutableStack<T>`
- **Benefícios:**
  - Segurança em concorrência.
  - Histórico imutável (ideal para undo/redo, eventos, logs).
  - Facilita programação funcional.
- **Desvantagem:** pode gerar mais alocação de memória (novo objeto a cada modificação).

 [Saiba Mais]()

## 5️⃣ **Interfaces de coleção**
Essas interfaces definem o **comportamento comum entre diferentes coleções.** 
Compreender essas interfaces é essencial para escrever código desacoplado e polimórfico.

- `IEnumerable` / `IEnumerable<T>` — permite iteração com `foreach`.
- `ICollection` / `ICollection<T>` — fornece tamanho e métodos básicos.
- `IList<T>` — acesso por índice e ordenação.
- `IDictionary<TKey, TValue>` — operações com pares chave-valor.
- **Importância:** permitem programar “para a interface”, não para a implementação.

 [Saiba Mais]()

## 6️⃣ **LINQ aplicado a coleções**
**Namespace:** `System.Linq`

**LINQ (Language Integrated Query)** permite fazer consultas declarativas em coleções, simplificando filtros, agrupamentos e projeções de dados.

- **Filtros:** `Where()`
- **Projeção:** `Select()`
- **Ordenação:** `OrderBy()`, `ThenBy()`
- **Agrupamento:** `GroupBy()`
- **Agregações:** `Sum()`, `Count()`, `Average()`, `Max()`, `Min()`
- **Paginação:** `Skip()` e `Take()`
- **Conversões:** `ToList()`, `ToDictionary()`, `ToArray()`
- **Consultas compostas:** encadeamento de métodos LINQ
- **Uso prático:** buscar transações por período, gerar extratos, calcular totais.

 [Saiba Mais]()

## 7️⃣ **Coleções especializadas**
**Namespace:** `System.Collections.Specialized`

Coleções otimizadas para cenários específicos.

- `NameValueCollection` — pares de nome e valor (útil para headers ou query strings).
- `StringCollection` — lista otimizada para strings.
- `BitVector32` — manipulação eficiente de bits.
- `HybridDictionary` — alterna entre `ListDictionary` e `Hashtable` conforme o tamanho dos dados.

 [Saiba Mais]()


## 8️⃣ **Conceitos transversais**
Esses conceitos se aplicam a qualquer tipo de coleção e ajudam a dominar o tema por completo.

- **Boxing e Unboxing:** ocorre em coleções não genéricas.
- **Iteração:** uso do `foreach` e `IEnumerator`.
- **Performance e complexidade:** Big O (tempo de busca, inserção e remoção).
- **Comparação e igualdade:** `IEquatable<T>`, `IComparer<T>`.
- **Copiar e clonar coleções:** `CopyTo()`, construtores e métodos de extensão.
- **Diferença entre mutáveis e imutáveis.**
- **Diferença entre valor e referência em coleções.**

 [Saiba Mais]()