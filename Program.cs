// Написать программу, которая выводит третью цифру заданного числа или сообщает , что третьей цифры некорректное
// 645 -> 5
// 78 -> третьей цифры нет 
// 32679 -> 6

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetThirdRank(int number)
{
    while (numder > 999)
{
    number /= 10;
}
return number % 10;
}

bool ValidateNimber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Ошибка!Некорректное число. Попробуйте еще раз!");
        return false;
    }
}
int number = Prompt("Пожалуйста введите число >");
if (ValidateNimber(number))
{
    Console.WriteLine(GetThirdRank(number));
}