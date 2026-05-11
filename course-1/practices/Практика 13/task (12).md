# Практика №13
Задание 1
1. Создайте абстрактный класс Shape:
- абстрактное свойство Name;
- абстрактный метод GetArea();
- обычный метод Print() — выводит "{Name}: площадь = {GetArea()}".
2. Реализуйте наследников:
- Circle { double Radius } → πR²;
- Rectangle { double Width, double Height } → W*H.
3. Создайте массив Shape[] из разных фигур и вызовите Print() для каждой.

Задание 2
1. Создайте абстрактный класс Animal:
- конструктор Animal(string name) — сохраняет Name и пишет "Создано животное: {Name}";
- метод Eat() — "{Name} ест.";
- абстрактный метод MakeSound().
2. Создайте классы наследники:
- Для класса Dog реализуйте метод MakeSound(): "{Name}: Гав-гав!";
- Для класса Cat реализуйте метод MakeSound(): "{Name}: Мяу!".
3. Создайте массив Animal[] с Dog("Рекс"), Cat("Мурка"), пройдитесь циклом: вызывая для каждого метод Eat() затем MakeSound().

Задание 3
1. Создайте интерфейс IPlayable, который описывает поведение всех музыкальных инструментов — то есть возможность играть.
```
public interface IPlayable
{
    void Play();
}
```
2. Создайте три класса, реализующие интерфейс IPlayable:
- Guitar — метод Play() выводит "Гитара играет аккорды";
- Piano — метод Play() выводит "Пианино играет мелодию";
- Drum — метод Play() выводит "Барабан отбивает ритм".
3. Создайте массив инструментов и вызовите метод Play() у каждого:
```
IPlayable[] instruments =
{
    new Guitar(),
    new Piano(),
    new Drum()
};

foreach (var i in instruments)
    i.Play();
```

Задание 4
1. Создайте три интерфейса:
```
public interface IReadable
{
    void Read(string filename);
}

public interface IWritable
{
    void Write(string filename, string content);
}

public interface ISavable
{
    void Save();
}
```
2. Создайте класс TextDocument, реализующий все три интерфейса:
```
public class TextDocument : IReadable, IWritable, ISavable
{
    private string content;

    public void Read(string filename)
    {
        Console.WriteLine($"Чтение из файла {filename}");
        content = "Текст из файла";
    }

    public void Write(string filename, string content)
    {
        Console.WriteLine($"Запись в файл {filename}: {content}");
        this.content = content;
    }

    public void Save()
    {
        Console.WriteLine($"Файл сохранён. Содержимое: {content}");
    }
}
```
3. Проверьте работоспособность:
```
TextDocument doc = new TextDocument();
doc.Read("data.txt");
doc.Write("data.txt", "Привет, мир!");
doc.Save();
```