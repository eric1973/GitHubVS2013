using System;
using System.Threading.Tasks;

public delegate void EventHandler();

class Program
{
    public static event EventHandler _show;

    static void Main()
    {
        // Add event handlers to Show event.
        //_show += new EventHandler(Dog);
        //_show += new EventHandler(Cat);
        //_show += new EventHandler(Mouse);
        //_show += new EventHandler(Mouse);

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

    static async void Cat()
    {
        Console.WriteLine("Cat");
    }

    static async void Dog()
    {
        Console.WriteLine("Dog");
    }

    static async void Mouse()
    {
        Console.WriteLine("Mouse");
    }
}