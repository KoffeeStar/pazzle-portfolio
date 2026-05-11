# Практика №4
Уровень 1
Задание 1: Создание репозитория
1. На рабочем столе создайте папку pazzle-portfolio
2. Откройте её в терминале и инициализируйте репозиторий:
```
git init
```
3. Создайте внутри папки следующую структуру:
```
course-2/
├─ homeworks/
├─ practices/
└─ projects/
course-3/
├─ homeworks/
├─ practices/
└─ projects/
```
4. Сделайте первый коммит:
```
git add .
git commit -m "feat: создана базовая структура учебного репозитория"
```

Уровень 2
Задание 2: Добавление .gitignore
1. В корне создайте файл .gitignore
2. Запишите в него правила, чтобы игнорировались временные файлы:
```
# Папки для сборки проектов .NET
bin/
obj/

# Настройки IDE (Visual Studio, Rider, VS Code)
/.vscode
/.idea
/.vs
```
3. Сделайте коммит:
```
git add .gitignore
git commit -m "feat: добавлен .gitignore для временных файлов и IDE"
```

Задание 3: Добавление README.md
1. Создайте и заполните файл README.md в корне репозитория.
2. Сделайте коммит:
```
git add README.md
git commit -m "docs: добавлен README.md с описанием структуры"
```