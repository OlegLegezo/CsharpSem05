// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.



int[] nums = new int[12];
var numRnd = new Random();//var - сам определяет тип
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(-9, 9);
    Console.Write(nums[i] + " ");
}
int sumPositive = 0;
int sumNegative = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] < 0) sumNegative += nums[i];// += складываем сум негатив = сумнегатив + 
    else sumPositive += nums[i];
}
Console.WriteLine();
Console.WriteLine($"сумма положительных элементов = {sumPositive}");
Console.WriteLine($"сумма отрицательных элементов = {sumNegative}");

void Method(int[] nums);
{
    nums[0]=1;
    nums[1]=2;
}