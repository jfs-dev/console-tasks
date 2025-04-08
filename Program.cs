using console_tasks.Services;

int[] taskDurations = [2000, 2500, 1000, 4000];

Console.WriteLine("Task");
Console.WriteLine("----");

var tasks = new Task[]
{
    TaskService.ExecuteMethodAsync("Tarefa 1", taskDurations[0]),
    TaskService.ExecuteMethodAsync("Tarefa 2", taskDurations[1]),
    TaskService.ExecuteMethodAsync("Tarefa 3", taskDurations[2]),
    TaskService.ExecuteMethodAsync("Tarefa 4", taskDurations[3])
};

await Task.WhenAll(tasks);

Console.WriteLine();
Console.WriteLine("Parallel");
Console.WriteLine("--------");

Parallel.For(0, 4, i =>
{
    TaskService.ExecuteMethodSync($"Tarefa {i + 1}", taskDurations[i]);
});

Console.WriteLine();
Console.WriteLine("Thread");
Console.WriteLine("------");

for (int i = 0; i < 4; i++)
{
    var taskId = i + 1;
    var taskDuration = taskDurations[i];

    Thread thread = new(() => TaskService.ExecuteMethodSync($"Tarefa {taskId}", taskDuration));

    thread.Start();
}
