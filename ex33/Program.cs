// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("введите число для проверки");
int num = int.Parse(Console.ReadLine());//сразу перевели число в инт
string result = $"число {num} отсутствует в массиве";


//метод создания массива
Random rnd = new Random();
int[] initArray()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9, 10);
        //Console.Write(array[i] + " "); //если нужно отобразить
    }
    return array;
}
//метод создания массива

int[] arr = initArray();

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]==num)
    {
        result = $"число {num} присутствует в массиве";
        break;
    }
}

string st=string.Join(", ", arr);//компаную массив в красивую строку
Console.WriteLine(st);
Console.WriteLine(result);




