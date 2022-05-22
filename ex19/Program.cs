

Console.WriteLine("введите 5-ти значное число");
int number = int.Parse(Console.ReadLine());

//34543

if (number > 9999 && number < 100000)
{
    int digit1 = number / 10000; //3 _____эти переменные все внутренние digit
    int digit2 = number / 1000 % 10;//4
    int digit3 = number / 100 % 10;//5
    int digit4 = number / 10 % 10;//4
    int digit5 = number % 10;//3

    string isPolyYesOut = $"число {number} является полиндромом";
    string isPolyNOOut = $"число {number} не является полиндромом";
    Console.WriteLine(digit1 == digit5 && digit2 == digit4 ? isPolyYesOut : isPolyNOOut);
}
