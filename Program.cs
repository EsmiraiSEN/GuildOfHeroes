Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

yaroslav.Health = 75;

Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Health}");
Console.WriteLine($"Уровень: {yaroslav.Level}");
Console.WriteLine($"Опыт: {yaroslav.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Health}");
Console.WriteLine($"Уровень: {anastasia.Level}");
Console.WriteLine($"Опыт: {anastasia.Experience}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Health}");
Console.WriteLine($"Уровень: {artem.Level}");
Console.WriteLine($"Опыт: {artem.Experience}");

Console.WriteLine();
Console.WriteLine(">>> Библиотека <<<");

Book triumphalArch = new Book("Триумфальная арка", "Эрих Мария Ремарк", 1945, 640);
Book crime = new Book("Преступление и наказание", "Ф. Достоевский", 1866, 671);
Book littlePrince = new Book("Маленький принц", "А. де Сент-Экзюпери", 1943, 96);

Console.WriteLine($"{triumphalArch.Title} | {triumphalArch.Author} | {triumphalArch.Year} | {triumphalArch.Pages} стр. | Доступна: {triumphalArch.IsAvailable}");
Console.WriteLine($"{crime.Title} | {crime.Author} | {crime.Year} | {crime.Pages} стр. | Доступна: {crime.IsAvailable}");
Console.WriteLine($"{littlePrince.Title} | {littlePrince.Author} | {littlePrince.Year} | {littlePrince.Pages} стр. | Доступна: {littlePrince.IsAvailable}");
