# УЧЕБНЫЙ ПРОЕКТ ГРУППЫ ОТ 2024-11

Проект соц. сети.
Планы приложения:
- [x] Проект: Админское приложение
- [x] Проект: Доступ к базе данных
- [x] Проект: Сервер на базе API
- [x] Проект: Клиентское приложение MVC
- [x] Проект: Клиентское приложение Blazor

## ЗАНЯТИЯ

| № | Тема | Ссылки | Задание |
| --- | --- | --- | --- | --- |
| 1 | Знакомство, настройка решения, план на курс | [Видео](https://disk.yandex.ru/d/LeAjJyoZv5sAiA) [Презентация](https://disk.yandex.ru/d/LeAjJyoZv5sAiA) | Kлонировать себе этот репозиторий и создать свой репозиторий для своего проекта |
| 2 | WPF. Основные элементы и элементы компоновки | [Видео](https://disk.yandex.ru/d/zLFt-t6zPtdg5g) | Сделать калькулятор с помощью [Grid](https://metanit.com/sharp/wpf/4.2.php), [переход на него с окна регистрации](https://metanit.com/sharp/wpf/20.2.php) после ввода логина и пароля, поле для ввода значений неактивно для печати с клавиатуры (набор только кнопками в интерфейсе окна), подсчёт можно организовать простым способом через метод [Compute класса DataTable](https://stackoverflow.com/questions/21950093/string-calculator). |
| 3 | WPF и работа с данными | [Видео](https://disk.yandex.ru/d/fPDfOoC7AjEHjA) | Сделать окно, на котором можно взаимодействовать с наборами данных, создавать, редактировать, удалять записи |
| 4 | WPF и паттерн MVVM | [Видео](https://disk.yandex.ru/d/-0LkLMARsq-mJQ) [Презентация](https://disk.yandex.ru/d/-0LkLMARsq-mJQ) | Перевести WPF приложение на паттерн MVVM |
| 5 | WPF и внедрение зависимостей и логирование | [Видео](https://disk.yandex.ru/d/534Ly7Rblg99Aw) [Презентация](https://disk.yandex.ru/d/534Ly7Rblg99Aw) | |
| 6 | MVC веб-приложение, структура, основы. Web-API и Swagger | [Видео](https://disk.yandex.ru/d/olyBJmoTH9jI5Q) | Добавить API приложение в решение и настроить Swagger |
| 7 | Entity Framework. ORM. Базы данных без баз данных | [Видео](https://disk.yandex.ru/d/RKr-MfZ_X-AIZQ) [Презентация](https://disk.yandex.ru/d/RKr-MfZ_X-AIZQ) | Добавить в решение отдельный проект (типа Console) для взаимодействия с базой данных |
| 8 | Миграции и отношения между сущностями через ORM | [Видео](https://disk.yandex.ru/d/Q2WBMRFqOFl0hA) [Недописанное руководство](https://disk.yandex.ru/d/Q2WBMRFqOFl0hA) | Добавить миграции для работы с БД |
| 9 | Создание структуры проекта с БД. Внедрение проекта в веб-сервер | [Видео](https://disk.yandex.ru/d/Cg7GWDtgD6hjQA) | Создать репозитории в проекте и работать через них в других приложениях |
| 10 | Пропущенные темы: интерфейсы, обобщённые типы, коллекции и методы расширений | [Видео](https://disk.yandex.ru/d/bKFluVELYMWLYg) [Презентации](https://disk.yandex.ru/d/bKFluVELYMWLYg) [Интерфейсы](https://metanit.com/sharp/tutorial/3.9.php) [Коллекции](https://metanit.com/sharp/tutorial/4.5.php) [Методы расширений](https://metanit.com/sharp/tutorial/3.18.php) [Обобщённые типы](https://metanit.com/sharp/tutorial/3.12.php) [StringBuilder](https://metanit.com/sharp/tutorial/7.3.php) | |
| 11 | Пропущенные темы: обработка исключений, делегаты, лямбда-выражения и LINQ | [Видео](https://disk.yandex.ru/d/I0CLvwqvy8Sj6w) [Презентации](https://disk.yandex.ru/d/I0CLvwqvy8Sj6w) [Обработка исключений](https://metanit.com/sharp/tutorial/2.14.php) [Делегаты](https://metanit.com/sharp/tutorial/3.13.php) [Лямбда-выражения](https://metanit.com/sharp/tutorial/3.16.php) [LINQ](https://metanit.com/sharp/tutorial/15.1.php) | |
| 12 | Пропущенные темы: прпллелизм и асинхронность | [Видео](https://disk.yandex.ru/d/SDZgF6MmN2oEEw) [Разница понятий](https://www.ddplanet.ru/blog/parallelizm-mnogopotochnost-asinhronnost-raznica-i-primery-primeneniya-dotnet-c-sharp/) | |
| 13 | Авторизация и аутентификация в API | [Видео](https://disk.yandex.ru/d/Zlt7o-7h-7p4Uw) [Добавление Bearer Token в API](https://metanit.com/sharp/aspnet6/13.2.php) [Настройка Policy](https://learn.microsoft.com/ru-ru/aspnet/core/security/authorization/limitingidentitybyscheme?view=aspnetcore-9.0) [Добавление Bearer Token в Swagger](https://dev.to/eduardstefanescu/aspnet-core-swagger-documentation-with-bearer-authentication-40l6) | |
| 14 | Авторизация и аутентификация в ASP.NET. Хранение паролей | [Видео](https://disk.yandex.ru/d/ictm8-1FH_busA) [Что такое Cookie](https://www.kaspersky.ru/resource-center/definitions/cookies) [Авторизация с помощью Cookie](https://metanit.com/sharp/aspnet6/13.4.php) [Про пароли и хорошие практики](https://code-maze.com/csharp-hashing-salting-passwords-best-practices/) | |
| 15 | Blazor веб-приложение. Основы и компоненты | [Видео](https://disk.yandex.ru/d/MUByTW9r278I8g) [Что такое Blazor](https://metanit.com/sharp/blazor/1.1.php) [Руководство по Blazor](https://metanit.com/sharp/blazor/2.2.php) | |
| 16 | Blazor веб-приложение. Формы и запрос данных с сервера | [Видео]() | |
| 17 | Брокеры сообщений. Kafka | [Видео]() | |
| 18 | Кеш приложения. Redis | [Видео]() | |
| 19 | Тема | [Видео]() | |
| 20 | Хостинг приложений | [Видео]() | |
| 21 | Виды баз данных | [Видео]() | |

# ССЫЛКИ

* [GitHub](https://github.com/)
* [Как вести фаил README.md](https://docs.github.com/ru/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)
* [Скачать GitHub Desktop](https://desktop.github.com/download/)
* [Руководство по WPF](https://metanit.com/sharp/wpf/)
* [Что такое Git](https://education.yandex.ru/journal/chto-takoe-github)
* [Работа с ветками в Git](https://habr.com/ru/companies/yandex_praktikum/articles/728302/)
* [Как работать с GitHub Desktop](https://selectel.ru/blog/git-github-review/)
* [MVVM в WPF](https://skillbox.ru/media/code/mvvm_proektirovanie_prilozheniy_dlya_windows/) [MessageBox в MVVM](https://awkwardcoder.blogspot.com/2012/03/showing-message-box-from-viewmodel-in.html)
* [MVVM в WPF. Полное понимание](https://habr.com/ru/articles/338518/)
* [Пример приложения WPF с MVVM](https://github.com/Mr-Filatik/MariaTest) [Про конвертеры](https://metanit.com/sharp/wpf/11.3.php)
* [DI пакеты для .NET](https://stackoverflow.com/questions/21288/which-net-dependency-injection-frameworks-are-worth-looking-into)
* [Книга про внедрение зависимостей](https://www.smarly.net/dependency-injection-in-net)
* [Логирование с помощью пакета Serilog](https://github.com/serilog/serilog/wiki/Getting-Started)
* [Что такое JSON](https://habr.com/ru/articles/554274/)
* [Руководство по ASP.NET Core MVC](https://metanit.com/sharp/mvc5/)
* [Руководство по WEB-API](https://metanit.com/sharp/aspnet5/23.1.php)
* [Основы Swagger](https://habr.com/ru/companies/simbirsoft/articles/707108/)
* [Настройка примеров запросов в Swagger](https://medium.com/@niteshsinghal85/multiple-request-response-examples-for-swagger-ui-in-asp-net-core-864c0bdc6619)
* [Что такое ORM](https://blog.skillfactory.ru/glossary/orm/)
* [Руководство по Entity Framework](https://metanit.com/sharp/efcore/)
* [Руководство по ADO.NET](https://metanit.com/sharp/adonetcore/)
* [Миграции](https://metanit.com/sharp/entityframeworkcore/2.15.php)
* [Описание организации связей в EF](https://www.learnentityframeworkcore.com/relationships)
* [Описание паттерна Repository](https://ru.stackoverflow.com/questions/1037422/%D0%9F%D0%B0%D1%82%D1%82%D0%B5%D1%80%D0%BD-repository-%D0%B8-%D1%81%D0%BC%D0%B5%D0%BD%D0%B0-orm)
* [Postman: первые шаги](https://habr.com/ru/companies/vk/articles/750096/)
* [Как работает хеширование](https://www.youtube.com/watch?v=xV8USnjKGCU)
