﻿// Написать программу, которая выводит третью цифру заданного числа или сообщает , что третьей цифры некорректное
// 645 -> 5
// 78 -> третьей цифры нет 
// 32679 -> 6


int Prompt(string message)
 {
     Console.Write(message);
    string value = Console.ReadLine();
     int result = Convert.ToInt32(value);
     return result;
 }
 int GetThirdRank(int number)
 {
         while (number > 999)
         {
            number /= 10;
         }
         return number % 10;
 }

bool ValiDateNimber(int number)
 {
     if (number < 100)
     {
        Console.WriteLine("Ошибка!Некорректное число. Попробуйте еще раз!");
         return false;
            }
     return true;
 }
int number = Prompt("Пожалуйста введите число >");
 if (ValiDateNimber(number))
 {
    Console.WriteLine(GetThirdRank(number));
        
}