using System;
using System.Linq;

int[] array1 = new int[] { 1, 2, 3 };
int[] array2 = new int[] { 4, 5, 6 };
int[] array3 = new int[] { 7, 8, 9 };

int[] mergedArray = array1.Concat(array2).Concat(array3).ToArray();
Console.WriteLine(string.Join(", ", mergedArray)); // 1, 2, 3, 4, 5, 6, 7, 8, 9
