# News Aggregator in ASP.NET Core MVC
Реализация новостного агрегатора в архитектуре REST API.
![preview](aggregator.gif)
Данные считываются из тематических RSS-лент новостного портала Russia Today и добавляются в локальную базу данных SQL Server.
NewsPostController отвечает за отображение категорий новостей на сайте. Основного интерфейс IAllNewsPost из папки Interfaces реализуется в класса NewsPostRepository.
В папке Models расположены все необходымые для работы сайта Модели данных(класс NewsPost), а в Views - HTML-представления.
Класс AppDBContent отвечает за работу c SQL Server, за работу с данными в этой БД отвечает класс DBObject. Доступ же к ней осуществляется посредством технологии Entity Framеwork, и все необходимые для нее миграции в папке Migrations. 