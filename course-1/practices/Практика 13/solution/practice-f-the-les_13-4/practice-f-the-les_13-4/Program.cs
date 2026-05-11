public interface IReadable
{
    void Read(string filename);
}

public interface IWriteable
{
    void Write(string filename, string content);
}

public interface ISaveable
{
    void Save();
}

public class TextDocument : IReadable, IWriteable, ISaveable
{
    private string content;

    public void Read(string filename)
    {
        Console.WriteLine($"Чтение из файла {filename}");
        content = "Текст из файла";
    }

    public void Write(string filename, string content)
    {
        Console.WriteLine($"Запись в файл{filename}: {content}");
        this.content = content;
    }

    public void Save()
    {
        Console.WriteLine($"Файл сохранён. Содержимое: {content}");
    }
}

class Program
{
    static void Main()
    {
        TextDocument doc = new TextDocument();
        doc.Read("data.txt");
        doc.Write("data.txt", "Привет, мир!");
        doc.Save();
    }
}

public interface IDocumentExporter
{
    string FormatName { get; }
    void Export(string content);
    void ShowInfo()
    {
        Console.WriteLine($"Записать в формат {FormatName}: {content}");
    }
}

public class TxtExporter : IDocumentExporter
{
    public string FormatName => "TXT";
    public void Export(string content)
    {
        Console.WriteLine("Сохраняем текстовый файл...");
    }
}
public class PdfExporter : IDocumentExporter
{
    public string FormatName => "PDF";
    public void Export(string content)
    {
        Console.WriteLine("Создаём PDF-документ");
    }
}

class Program
{
    static void Main()
    {
        IDocumentExporter[] exporters =
        {
            new TxtExporter(),
            new PdfExporter()
        };
        foreach (var e in exporters)
        {
            e.ShowInfo("Hello world");
            e.Export("Hello world");
        }
    }

}