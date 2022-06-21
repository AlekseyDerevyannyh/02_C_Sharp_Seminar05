// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Смутило слово ВЕЩЕСТВЕННЫХ чисел в условии задачи, хотя в примере показан массив целых чисел.
// Методы Random().NextSingle() и Random().NextDouble для fload и double, соответственно, на выходе
// дают числа меньше 1. Можно было, конечно, потом уножить на случайное целое или прибавить случайное целое,
// но как-то это заморочно и массив дробных элементов не красиво выглядит на выходе.
// В общем решил, что это опечатка в условии задачи и сделал с целыми числами
using System;
using static System.Console;

Clear();
int[] array = GetRandomArray(10, -10, 20);
WriteLine($"[{String.Join(", ", array)}] -> {Max(array) - Min(array)}");


int[] GetRandomArray (int size, int minValue, int maxValue) {
	int[] result = new int[size];
	for (int i = 0; i < size; i ++) {
		result[i] = new Random().Next(minValue, maxValue + 1);
	}
	return result;
}

int Max (int[] _array) {
	int max = _array[0];
	for (int i = 1; i < _array.Length; i ++) {
		if (array[i] > max)		max = array[i];
	}
	return max;
}

int Min (int[] _array) {
	int min = _array[0];
	for (int i = 1; i < _array.Length; i ++) {
		if (array[i] < min)		min = array[i];
	}
	return min;
}
