Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");






// Самостоятельная с 9 лабы
Console.WriteLine();
Console.WriteLine(">>> Библиотека <<<");

Book triumphalArch = new Book("Триумфальная арка", "Эрих Мария Ремарк", 1945, 640);
Book crime = new Book("Преступление и наказание", "Ф. Достоевский", 1866, 671);
Book littlePrince = new Book("Маленький принц", "А. де Сент-Экзюпери", 1943, 96);

Console.WriteLine($"{triumphalArch.Title} | {triumphalArch.Author} | {triumphalArch.Year} | {triumphalArch.Pages} стр. | Доступна: {triumphalArch.IsAvailable}");
Console.WriteLine($"{crime.Title} | {crime.Author} | {crime.Year} | {crime.Pages} стр. | Доступна: {crime.IsAvailable}");
Console.WriteLine($"{littlePrince.Title} | {littlePrince.Author} | {littlePrince.Year} | {littlePrince.Pages} стр. | Доступна: {littlePrince.IsAvailable}");
