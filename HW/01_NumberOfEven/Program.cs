// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
using System;
using static System.Console;

Clear();
Write("Введите количество элементов массива: ");
int number;
if (! int.TryParse(ReadLine(), out number)) {
	Write("Ошибка ввода числа!");
	return;
}
int[] array = GetRandomArray(number, 100, 999);
Write($"[{String.Join(", ", array)}] -> Количество чётных чисел = {NumberOfEven(array)}");


int [] GetRandomArray (int size, int minValue, int maxValue) {
	int[] result = new int[size];
	for (int i = 0; i < size; i ++) {
		result[i] = new Random().Next(minValue, maxValue + 1);
	}
	return result;
}

int NumberOfEven (int[] _array) {
	int result = 0;
	for (int i = 0; i < _array.Length; i ++) {
		if (_array[i] % 2 == 0)		result ++;
	}
	return result;
}
