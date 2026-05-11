Console.Write("Путь к файлу: ");
string? src = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(src) && File.Exists(src))
{
    string dir = Path.GetDirectoryName(src)!;
    string name = Path.GetFileName(src);
    string bak = Path.Combine(dir, name + ".bak");
    File.Copy(src, bak, overwrite: true);
    Console.WriteLine($"Создана копия: {bak}");
}
else
{
    Console.WriteLine("Файл не найден.");
}