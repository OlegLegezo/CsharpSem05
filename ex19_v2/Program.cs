Console.WriteLine("введите 5-ти значное число");
var number = Console.ReadLine();//var - сам определяет тип

bool isPolyndrom = true;
for (int i = 0; i < number.Lenght; i++) ;
{
    if (number[i] != number[number.Length - 1 - i]) ;
    isPolyndrom = false;
}
Console.WriteLine(isPolyndrom);