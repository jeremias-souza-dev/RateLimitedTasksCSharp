# RateLimitedTasks

Projeto em C# para demonstrar a execução de tarefas com limite por minuto usando `Task` e `async/await`.  

O objetivo é controlar a execução de múltiplas tarefas sem ultrapassar um limite definido por minuto, simulando situações de **rate limiting** em APIs ou processos paralelos.

---

## Funcionalidades

- Executa múltiplas tarefas de forma assíncrona.
- Controla o número de execuções por minuto.
- Mostra no console o progresso das tarefas.
- Fácil de configurar `total de tarefas` e `limite por minuto`.

---

## Como usar

1. Clone o repositório:

```bash
git clone https://github.com/jeremias-souza-dev/RateLimitedTasksCSharp.git
````

2. Abra o projeto no Visual Studio.
3. Altere as variáveis `total` e `limitPerMinute` no `Program.cs` conforme necessário:

```csharp
int total = 4000;
int limitPerMinute = 4000;
```

4. Execute o projeto. Você verá a saída no console indicando o progresso:

```text
Executando 0 falta 4000 - 18:42:37.123
Executando 1 falta 3999 - 18:42:37.723
...
Concluído!
```

---

## Captura de tela

![Captura de tela](Captura%20de%20tela%202025-08-17%20184237.png)
