using System;
using System.Threading.Tasks;

public delegate void EventHandler();

class Program
{
    public static event EventHandler _show;

    static void Main()
    {
        // Add event handlers to Show event.
        _show += async () =>
        {
            await Task.Delay(2000);
            Console.WriteLine("async call");
        };

        // Invoke the event.
        _show.Invoke();
        Console.WriteLine("after invoke");
        Console.ReadLine();
    }
}