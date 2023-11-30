Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username == "Мария")
{
        Console.WriteLine("Ура, это же Мария!");
}
else
{
        Console.Write("Привет, ");
        Console.WriteLine(username);
}