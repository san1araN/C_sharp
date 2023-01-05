Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "женя")
{
        Console.WriteLine("Ура, это же Евгеша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}