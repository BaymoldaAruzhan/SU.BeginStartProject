
using BeginProject;

//5 задание по модулю 1

Console.WriteLine("Привет! Пожалуйста, введите ваше ФИО:");
string fullName = Console.ReadLine();
Console.WriteLine("Приветствую тебя - " + fullName);
//6 задание по модулю 1
Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();

        // Разделяем ввод на отдельные числа
        string[] numbers = input.Split(' ');

        // Переменная для хранения суммы
        int sum = 0;

        // Проходим по каждому числу и суммируем их
        foreach (string number in numbers)
        {
            if (int.TryParse(number, out int parsedNumber))
            {
                sum += parsedNumber;
            }
            else
            {
                Console.WriteLine($"Введенное значение '{number}' не является числом и будет проигнорировано.");
            }
        }

        Console.WriteLine($"Сумма введенных чисел: {sum}");
        Console.ReadLine(); // чтобы консольное окно не закрылось сразу после вывода суммы
    

