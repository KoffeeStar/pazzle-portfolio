string logsDir = "logs";
Directory.CreateDirectory(logsDir);

string file = Path.Combine(logsDir, $"{DateTime.Now:yyyy-MM-dd}.log");
File.AppendAllText(file, $"{DateTime.Now:O} :: событие\n");

int days = 7;
foreach (var f in Directory.GetFiles(logsDir, "*.log"))
{
    var info = new FileInfo(f);
    if (info.CreationTimeUtc < DateTime.UtcNow.AddDays(-days))
    {
        info.Delete();
    }
}