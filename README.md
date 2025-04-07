﻿# ToyShop

**ToyShop** е цялостно приложение, разработено с помощта на Windows Forms и C#, предназначено за управление на магазин за играчки. Проектът е създаден с цел да предостави на потребителите интуитивен интерфейс за управление на продукти, поръчки и потребители, като същевременно осигурява сигурност и ефективност.

## Съдържание

- [Общ преглед](#общ-преглед)
- [Функционалности](#функционалности)
- [Технологии](#технологии)
- [Инсталация](#инсталация)
- [Използване](#използване)
- [Структура на проекта](#структура-на-проекта)
- [База данни](#база-данни)
- [Сигурност](#сигурност)

## Общ преглед

**ToyShop** е предназначен да улесни управлението на магазин за играчки, предоставяйки възможности за добавяне, редактиране и изтриване на продукти, управление на поръчки и потребители. Приложението поддържа различни роли на потребители, включително администратори и клиенти, като осигурява подходящи права за достъп и функционалности за всяка роля.

## Функционалности

### За администратори

- **Управление на продукти**: Добавяне, редактиране и изтриване на продукти с детайли като име, цена и изображение.
- **Управление на поръчки**: Преглед и обработка на клиентски поръчки, включително промяна на статуси.
- **Управление на потребители**: Преглед и управление на регистрирани потребители и техните роли.

### За клиенти

- **Разглеждане на продукти**: Преглед на наличните играчки с детайли и изображения.
- **Пазарска количка**: Добавяне на продукти в количката, промяна на количествата и преглед на общата сума.
- **Създаване на поръчки**: Финализиране на поръчки с предоставяне на информация за доставка.

## Технологии

- **Език за програмиране**: C#
- **Платформа**: .NET Framework
- **GUI**: Windows Forms
- **ORM**: Entity Framework Core
- **База данни**: Microsoft SQL Server

## Инсталация

1. **Клониране на хранилището**:

   ```bash
   git clone https://github.com/zdravkokold/ToyShop.git
   ```

2. **Отваряне на проекта**:

   Отворете `ToyShop.sln` с Visual Studio.

3. **Възстановяване на NuGet пакети**:

   Във Visual Studio отидете на `Tools` > `NuGet Package Manager` > `Manage NuGet Packages for Solution` и възстановете липсващите пакети.

4. **Настройка на базата данни**:

   - Уверете се, че Microsoft SQL Server е инсталиран и работи.
   - Актуализирайте връзката към базата данни в `Program.cs` и `ToyShopDbContextFactory.cs`, за да съответства на вашата конфигурация.
   - Приложете миграциите, за да създадете базата данни в SQL Server Management Studio:

     ```bash
     Update-Database
     ```

5. **Стартиране на приложението**:

   Натиснете `F5` във Visual Studio, за да стартирате приложението.

## Използване

### За администратори

1. **Вход**: Използвайте администраторски данни за вход, за да влезете.
2. **Управление на продукти**: Отидете в секцията за управление на продукти, за да добавяте, редактирате или изтривате продукти.
3. **Управление на потребители**: Достъп до секцията за потребители за преглед и редктиране на потребители.

### За клиенти

1. **Регистрация/Вход**: Създайте нов акаунт или влезте с вече съществуващ.
2. **Разглеждане на продукти**: Преглед на наличните играчки.
3. **Добавяне в количката**: Изберете продукти и ги добавете в пазарската количка.
4. **Създаване на поръчка**: Натиснете "Поръчай" и изберете дали данните ви за доставка да са тези въведени при регистрация или предоставете нова информация за доставка и финализирайте поръчката.

## Структура на проекта

- **Entities**: Съдържа модели на данни, представляващи таблиците в базата данни.
- **Forms**: Съдържа Windows Forms, използвани за потребителския интерфейс.
- **Migrations**: Съдържа файлове за миграции на Entity Framework Core за версиониране на базата данни.
- **Resources**: Съхранява изображения, използвани в приложението.

## База данни

Приложението използва Entity Framework Core за управление на базата данни. Основните таблици включват:

- **Users**: Съхранява информация за потребителите с полета за пълно име, адрес, телефонен номер, имейл и роля.
- **Products**: Съдържа детайли за продуктите като име, цена и изображение.
- **Orders**: Записва поръчки, направени от клиенти, свързани с потребителя и съдържащи статус на поръчката.
- **OrderDetails**: Съдържа продуктите, свързани с всяка поръчка, включително количество и обща цена.

## Сигурност

- **Роли на потребители**: Приложението поддържа различни роли (администратор и клиент) с различни нива на достъп.
- **Хеширане на пароли**: Паролите на потребителите се хешират преди съхранение в базата данни за повишена сигурност.
- **Валидиране на входни данни**: Всички входни данни се валидират, за да се предотвратят SQL инжекции и други атаки 

## Документация
https://shorturl.at/mSfxI