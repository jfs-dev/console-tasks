namespace console_tasks.Services;

public static class TaskService
{
    public static async Task ExecuteMethodAsync(string taskName, int taskDuration = 2000)
    {
        Console.WriteLine($"{taskName} iniciada.");
        
        await Task.Delay(taskDuration);
        
        Console.WriteLine($"{taskName} concluída.");
    }

    public static void ExecuteMethodSync(string taskName, int taskDuration = 2000)
    {
        Console.WriteLine($"{taskName} iniciada.");
        
        Thread.Sleep(taskDuration);
        
        Console.WriteLine($"{taskName} concluída.");
    }    
}
