# console-tasks
Executando métodos simultaneamente em C# utilizando programação assíncrona com a classe Task, paralelismo com a classe Parallel ou manualmente usando a classe Thread

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra como executar métodos simultaneamente em C# utilizando programação assíncrona com a classe Task, paralelismo com a classe Parallel ou manualmente usando a classe Thread.

Executar um método simultaneamente em C# pode ser feito utilizando programação assíncrona com a classe Task ou paralelismo com a classe Parallel. Isso permite rodar múltiplas instâncias de um método de forma simultânea, maximizando o uso de recursos do sistema.

1. Usando <code>Task</code> para execução simultânea: A classe Task é ideal para lidar com operações assíncronas, especialmente quando não é necessário compartilhar dados entre as threads.

2. Usando <code>Parallel.For</code> para execução paralela: Se o método é síncrono e você deseja processá-lo em paralelo, use a classe Parallel que distribui automaticamente as execuções entre os núcleos do processador.

3. Usando <code>Thread</code> manualmente: Se precisar de controle explícito sobre cada thread, você pode usar a classe Thread. No entanto, é geralmente menos recomendada por ser de mais baixo nível.

**Qual abordagem escolher?**

>Task: Use para operações assíncronas e de longa duração, excelente para IO-bound ou network-bound.

>Parallel: Use para operações CPU-bound (cálculos intensivos), boa para processar coleções em paralelo.

>Thread: Use se precisar de controle detalhado das threads, mas prefira alternativas mais modernas.

<div align="center">
    <img src="https://github.com/user-attachments/assets/413e8fe5-e209-4ad3-9ec9-9b5d1952b711"</img>
</div>

## Referências
https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task?view=net-10.0

https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.parallel?view=net-10.0

https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread?view=net-10.0

## Licença
GPL-3.0 license
