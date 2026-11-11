Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("Александр", 150);

Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());

// Начало проверки здоровья
Hero lowProbe = new Hero("Проверка нижней границы", -100);
Hero highProbe = new Hero("Проверка верхней границы", 5000);
Console.WriteLine($"Нижняя граница: {lowProbe.Health}/{lowProbe.MaxHealth}");
Console.WriteLine($"Верхняя граница: {highProbe.Health}/{highProbe.MaxHealth}");
Console.WriteLine($"Александр до действий: {alexander.Health}/{alexander.MaxHealth}");

alexander.TakeDamage(30);
alexander.Heal(10);
Console.WriteLine($"Обычные действия: {alexander.Health}");
alexander.Heal(5000);
Console.WriteLine($"Большое лечение: {alexander.Health}");
alexander.Heal(-20);
Console.WriteLine($"Отказ в лечении: {alexander.Health}");
alexander.TakeDamage(5000);
Console.WriteLine($"Большой урон: {alexander.Health}; жив: {alexander.IsAlive()}");
alexander.Heal(20);
Console.WriteLine($"Восстановление: {alexander.Health}");
Console.WriteLine($"Артём без изменений: {artem.Health}/{artem.MaxHealth}");
// Конец проверки здоровья


















// Самостоятельная с 9 лабы библиотека
Console.WriteLine();
Console.WriteLine(">>> Библиотека <<<");

Book triumphalArch = new Book("Триумфальная арка", "Эрих Мария Ремарк", 1945, 640);
Book crime = new Book("Преступление и наказание", "Ф. Достоевский", 1866, 671);
Book littlePrince = new Book("Маленький принц", "А. де Сент-Экзюпери", 1943, 96);

Console.WriteLine($"{triumphalArch.Title} | {triumphalArch.Author} | {triumphalArch.Year} | {triumphalArch.Pages} стр. | Доступна: {triumphalArch.IsAvailable} | Рейтинг: {triumphalArch.Rating}");
Console.WriteLine($"{crime.Title} | {crime.Author} | {crime.Year} | {crime.Pages} стр. | Доступна: {crime.IsAvailable} | Рейтинг: {crime.Rating}");
Console.WriteLine($"{littlePrince.Title} | {littlePrince.Author} | {littlePrince.Year} | {littlePrince.Pages} стр. | Доступна: {littlePrince.IsAvailable} | Рейтинг: {littlePrince.Rating}");

Console.WriteLine();
Console.WriteLine("--- Проверка метода RateBook ---");

Console.WriteLine($"До вызова: {triumphalArch.Title} — Рейтинг: {triumphalArch.Rating}");

triumphalArch.RateBook(9.5);
Console.WriteLine($"После допустимого (9.5): {triumphalArch.Title} — Рейтинг: {triumphalArch.Rating}");

triumphalArch.RateBook(15);
Console.WriteLine($"После недопустимого (15): {triumphalArch.Title} — Рейтинг: {triumphalArch.Rating}");