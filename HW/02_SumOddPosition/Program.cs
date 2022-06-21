// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
using System;
using static System.Console;

Clear();
int[] array = GetRandomArray(10, -100, 100);
Write($"[{String.Join(", ", array)}] -> {SumOfNumbersOddPosition(array)}");


int[] GetRandomArray (int size, int minValue, int maxValue) {
	int[] result = new int[size];
	for (int i = 0; i < size; i ++) {
		result[i] = new Random().Next(minValue, maxValue + 1);
	}
	return result;
}

int SumOfNumbersOddPosition (int[] _array) {
	int result = 0;
	for (int i = 1; i < _array.Length; i += 2) {
		result += _array[i];
	}
	return result;
}
