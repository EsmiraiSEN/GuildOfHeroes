Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);

alexander.TakeDamage(10);
alexander.Heal(10);

Console.WriteLine(">>> Участники готовы <<<");
Console.WriteLine();
Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());
Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");

// Библиотека (собственный проект) 
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