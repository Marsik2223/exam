Console.WriteLine("Введите свое имя ");
string username = Console.ReadLine();

if(username.ToLower() == "рома")
{
    Console.WriteLine("Я тебя люблю!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}