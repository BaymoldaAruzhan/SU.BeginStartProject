//5 задание по модулю 1
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше ФИО:");
        string fullName = Console.ReadLine();
        Console.WriteLine("Приветствую тебя - " + fullName);
        Console.ReadLine(); // чтобы консольное окно не закрылось сразу после вывода имени и фамилии
    }
}