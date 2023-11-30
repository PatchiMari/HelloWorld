Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.Write("введите своё имя: ");
string username = Console.ReadLine();
Console.Write($"Привет, {username}");
