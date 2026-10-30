using System.Diagnostics;

Process currentProcess = Process.GetCurrentProcess();

System.Console.WriteLine($"PID: {currentProcess.Id}");
System.Console.WriteLine("Начинаем вычисления...");

long result = 0;
Stopwatch timer = Stopwatch.StartNew();
while (timer.Elapsed.TotalSeconds < 10)
{
    for (int i = 0; i < 1_000_000; i++)
    {
        result += i * i;
    }
}
timer.Stop();

System.Console.WriteLine($"Результат: {result}");
System.Console.WriteLine($"Время вычислений: {timer.ElapsedMilliseconds} мс");
System.Console.WriteLine("Нажмите Enter для завершения.");

System.Console.ReadLine();