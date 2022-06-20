// **Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
using System;
using static System.Console;
Clear();

Write("Введите элементы массива через пробел: ");
int[] array = GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(", ", array)}]");
WriteLine($"[{String.Join(", ", (MultiPair(array)))}]");

int[] GetArrayFromString (string arrayStr) {
	string[] arS = arrayStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
	int[] result = new int[arS.Length];
	for(int i = 0; i < arS.Length; i ++) {
		result[i]=int.Parse(arS[i]);
	}
	return result;
}

int[] MultiPair (int[] _array) {
	int[] result = new int[_array.Length % 2 == 0 ? _array.Length / 2 : _array.Length / 2 + 1];
	for (int i = 0; i < (_array.Length % 2 == 0 ? result.Length: result.Length - 1); i ++) {
		result[i] = _array[i] * _array[_array.Length - i - 1];
	}
	if ((_array.Length % 2) != 0)	result[result.Length - 1] = _array[_array.Length / 2];
	return result;
}
