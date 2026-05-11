# Практика №20
Уровень 1
1. Установите nuget-пакет Microsoft.AspNetCore.Mvc.NewtonsoftJson. В Program.cs добавьте применение NewtonsoftJson для сериализации/десериализации запросов:
```
builder.Services.AddControllers().AddNewtonsoftJson();
```
2. В Properties/launchSettings.json измените порт на 5000 (выделено желтым, что необходимо изменить)
```
{
 "$schema": "https://json.schemastore.org/launchsettings.json",
 "profiles": {
   "http": {
     "commandName": "Project",
     "dotnetRunMessages": true,
     "launchBrowser": false,
     "applicationUrl": "http://localhost:5000",
     "environmentVariables": {
       "ASPNETCORE_ENVIRONMENT": "Development"
     }
   },
   "https": {
     "commandName": "Project",
     "dotnetRunMessages": true,
     "launchBrowser": false,
     "applicationUrl": "https://localhost:7117;http://localhost:5212",
     "environmentVariables": {
       "ASPNETCORE_ENVIRONMENT": "Development"
     }
   }
 }
}
```
3. Настроим вебхук. Установим node.js Node.js — Download Node.js®
4. После установки, проверяем, что все корректно установилась и работает команда
```
npm -v
```

Уровень 2
5. Установка localtunnel
```
npm install -g localtunnel
```
6. Запуск туннеля
```
lt --port 5000 --subdomain mytelegrambot
```
7. Регистрация вебхук
8. Запуск приложения:
- Запустите приложение, убедитесь, что слушается порт 5000.
- Отправьте сообщение в чат бот, проверьте консоль, должно быть сообщение “Hello”