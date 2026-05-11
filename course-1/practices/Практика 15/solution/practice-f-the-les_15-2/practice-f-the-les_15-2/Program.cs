string dir = "data";
Directory.CreateDirectory(dir);

File.WriteAllText(Path.Combine(dir, "a.txt"), "A");
File.WriteAllText(Path.Combine(dir, "b.txt"), "BBBB");
File.WriteAllText(Path.Combine(dir, "b.md"), "CCC");

foreach (var f in Directory.GetFiles(dir, "*.txt"))
{
    var info = new FileInfo(f);
    Console.WriteLine($"{info.Name} -- {info.Length} байт");
}