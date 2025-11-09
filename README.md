# 🏦 Fundamentals C# & .NET — O Resgate do Banco Digital Futuro

## 📖 Índice

- [👩‍💻 Introdução](#👩‍💻-introdução)
- [🎯 Contexto](#🎯-contexto)
- [💼 Desafios (Regras de Negócio)](#💼-desafios-regras-de-negócio)
  - [Sistema básico de transações](#🏛-sistema-básico-de-transações)
  - [Processamento com Collections e LINQ](#📊-processamento-com-collections-e-linq)
  - [Operações com Async/Await](#⚙️-operações-com-asyncawait)
  - [Features do C# moderno](#🧩-features-do-c-moderno)
  - [Delegates e Events](#📢-delegates-e-events)
  - [Tratamento de Exceções](#💣-tratamento-de-exceções)
- [✅ Critérios de Aceite](#✅-critérios-de-aceite)
- [💡 Critérios de Qualidade](#💡-critérios-de-qualidade)
- [📚 Conceitos Fundamentais](#📚-conceitos-fundamentais)


## 👩‍💻 Introdução

**Fundamentals C# & .NET — O Resgate do Banco Digital Futuro** é um projeto prático criado para estudar os **fundamentos modernos da linguagem C# e da plataforma .NET**, aplicados a um **sistema bancário digital fictício**.

A proposta é unir **prática e teoria**, construindo passo a passo um sistema funcional enquanto se exploram conceitos essenciais da linguagem:

- Classes, Structs, Records e Enums  
- Stack, Heap, Mutabilidade e Imutabilidade  
- Arrays, List, Dictionary, Queue, Stack e HashSet  
- LINQ e consultas funcionais  
- Programação assíncrona (async/await, Task, CancellationToken)  
- Delegates, Events e Pattern Matching  
- Exceções customizadas e boas práticas de código    


## 🎯 Contexto

A **TechGrow** adquiriu um pequeno banco digital com sistema legado.  
O objetivo é **modernizar o núcleo do sistema** utilizando **C# moderno**, aplicando fundamentos da linguagem e boas práticas de desenvolvimento.

## 💼 Desafios (Regras de Negócio)

### 🏛 Sistema básico de transações
- Implementar classes para **Conta**, **Transação** e **Cliente** usando **records e classes**;
- Cada transação deve validar **saldo suficiente**;
- Limite diário de **R$ 5.000 por conta**;
- Usar **enums** para tipos de transação, status da conta e tipo de conta.


### 📊 Processamento com Collections e LINQ
- Usar **List<T>** e **Dictionary<TKey, TValue>** para armazenar contas e transações;
- Implementar **busca de transações por período** com `LINQ` (`Where`/`Select`);
- Calcular **saldo médio e totais por categoria** com `GroupBy` e `Sum`; 
- Gerar **extrato paginado** usando `Skip` e `Take`.  


### ⚙️ Operações com Async/Await
- Simular **operações assíncronas de banco**;
- Usar `Task.Delay` para simular processamento;
- Implementar **cancelamento** com `CancellationToken`.  


### 🧩 Features do C# moderno
- Usar **pattern matching** para detectar tipos de transação;  
- Implementar **tuples** para retornos complexos `(bool sucesso, string msg, decimal valor)`;  
- Usar **records** para representar dados **imutáveis** de transação.  

### 📢 Delegates e Events
- Implementar **event** para notificar transações acima de **R$ 10.000**;  
- Usar **Action/Func** para diferentes estratégias de cálculo de tarifas;  
- Criar **delegate** para validações customizadas.  

### 💣 Tratamento de Exceções
- Criar exceções customizadas:
  - `Saldo Insuficiente Exception`
  - `Limite Diario Excedido Exception`
- Implementar `try/catch` específico para cada operação;  
- Garantir **rollback** em caso de falha.  

## ✅ Critérios de Aceite

| Categoria | Requisito |
|------------|------------|
| **Modelagem** | Classes `CurrentAccount`, `Client`, `Transaction` implementadas corretamente |
| **Records** | Usados para dados imutáveis |
| **Enums** | Definidos para tipos de transação, status da conta e tipo de conta |
| **Tipos** | Uso correto de `decimal` (valores), `DateTime` (datas) |
| **Collections** | `List<T>` para armazenar transações, `Dictionary` para buscar contas |
| **LINQ** | Uso de `Where`, `Select`, `GroupBy`, `Sum`, `Skip`, `Take` |
| **Async/Await** | Uso correto de `Task`, `Task.Delay`, `CancellationToken` |
| **Eventos** | Event para transações suspeitas (> R$10.000) |
| **Delegates** | `Action`, `Func` e delegates customizados para validação e tarifas |
| **Pattern Matching** | Identificação de tipos de transação |
| **Tuples** | Retornos múltiplos |
| **Exceções** | Customizadas e tratadas adequadamente |
| **Boas práticas** | `finally` para limpeza e `string formatting` para extratos |

## 💡 Critérios de Qualidade

### 🧩 Qualidade do Código
- Compila sem erros nem warnings  
- Nomes de variáveis e métodos são **significativos**  
- Cada método tem **responsabilidade única**

### ⚙️ Funcionalidade
- **Depósito** aumenta saldo corretamente  
- **Saque** valida e reduz saldo  
- **Transferência** entre contas funcionando  
- **Consulta de saldo** retorna valores corretos  
- **Comentários** apenas quando necessários  
- **Suporte a múltiplas operações concorrentes**

## 📚 Conceitos Fundamentais

Os fundamentos teóricos estudados durante o desenvolvimento estão detalhados em:

👉 [`Conceitos Fundamentais`](/Docs/concepts.md)

## 💾 Como rodar o projeto

1. Clone este repositório:
```bash
    git clone https://github.com/seuusuario/fundamentals-csharp-dotnet.git
    cd fundamentals-csharp-dotnet
```

2. Execute no terminal
```bash
    dotnet run
```

3. Ou abra no Visual Studio Code / Visual Studio e pressione ▶️ Run.