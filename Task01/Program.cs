// **Задача 35:** Задайте одномерный массив из 123 случайных чисел. Найдите количество
// элементов массива, значения которых лежат в отрезке [10,99].
// *Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
using System;
using static System.Console;
Clear();

int[] Array = GetRandomArray(123, 0, 200);
WriteLine($"[{String.Join(", ", Array)}]");
int count = Count(Array, 10, 99);
Write(count);



int [] GetRandomArray (int size, int minValue, int maxValue) {
	int[] result = new int[size];
	for (int i = 0; i < size; i ++) {
		result[i] = new Random().Next(minValue, maxValue + 1);
	}
	return result;
}

int Count (int[] array, int min, int max) {
	int result = 0;
	for (int i = 0; i < array.Length; i ++) {
		if (array[i] >= min && array[i] <= max) 	result ++;
	}
	return result;
}