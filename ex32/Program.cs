﻿// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int[] nums = new int[4];
var numRnd = new Random();//var - сам определяет тип
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(-9, 9);
    Console.Write(nums[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < nums.Length; i++)
{
    nums[i]=-nums[i];
    Console.Write(nums[i] + " ");
}
