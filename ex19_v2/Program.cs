Console.WriteLine("введите число");
var number = Console.ReadLine();//var - сам определяет тип

bool isPolyndrom = true;
for (int i = 0; i < number.Length; i++)//number.Lenght - длина строки
{
    if (number[i] != number[number.Length - 1 - i]) // "!=" - не равно
    isPolyndrom = false;
}

Console.WriteLine(isPolyndrom);