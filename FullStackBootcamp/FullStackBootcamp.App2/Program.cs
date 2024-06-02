namespace FullStackBootcamp.App2;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World from App2!");

        Pen pen1 = new Pen();
        pen1.Color = "Red";
        pen1.Height = 100;
        pen1.Width = 600;
        Console.WriteLine(pen1.Width);

        Write(pen1);
        Console.WriteLine(pen1.Width);

        int value = 10;
        Console.WriteLine(value);
        Write2(value);
        Console.WriteLine(value);
    }

    static void Write(Pen pen)
    {
        pen.Width = 100;
    }

    static int Write2(int value)
    {
        value = 100 * 2;
        return value;
    }
}


// Uygulama çalışırken Main metodu çalıştırılır. Main metodu içerisindeki kodlar sırasıyla çalışır.
// Termialde uygulamayı çalıştırmak için dotnet run komutu kullanılır.
// dotnet run komutu çalıştırıldığında uygulama çalıştırılır ve ekrana "Hello World from App2!" yazısı yazdırılır.
// Arayüz aracılığıyla uygulamayı çalıştırmak için Visual Studio Code üzerinde Run butonuna basılır. Arka planda dotnet run komutu çalıştırılır.
