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

bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
Console.WriteLine($"Артём жив: {artem.IsAlive()}");

if (yaroslavAlive) {
    Console.WriteLine("Ярослав может продолжать приключение.");
} else {
    Console.WriteLine("Ярослав больше не может сражаться.");
}

string info = yaroslav.GetInfo();
Console.WriteLine("Строка получена. Сейчас выведем её:");
Console.WriteLine(info);

Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());


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