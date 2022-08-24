//Задача 39: Напишите программу, которая перевернет одномерный массив 
//(последний элемент будет на первом месте, а первый на последнем)
//[1,2,3,4,5] -> [5,4,3,2,1]
//[6,7,3,6] -> [6,3,7,6]

/*int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(11);
}

Console.WriteLine($"Array: [{String.Join(", ", array)}]");

//Способ №1
int lastIndex = size - 1;
int[] resultArray = new int[size];
for (int i = 0; i < size; i++)
{
     resultArray[i] = array[lastIndex - i];
}
Console.WriteLine($"Revers array: [{String.Join(", ", resultArray)}");*/

//Способ №2

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] reversArray=CopyArray(array);
Console.WriteLine(String.Join(" ", reversArray));

ReverseArray(array);
//Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];

for (int i = 0; i < size; i++)
{
    res[i] = new Random().Next(minValue, maxValue + 1); // [0;11) => [0;10]
}
return res;
}

void ReverseArray(int[] inArray)
{
for (int i = 0; i < inArray.Length / 2; i++)
{
int temp = inArray[i];
inArray[i] = inArray[inArray.Length - i - 1];
inArray[inArray.Length - i - 1] = temp;
}
}

int[] CopyArray(int[] inArray)
{
int[] result = new int[inArray.Length];
for (int i = 0; i < inArray.Length; i++)
{
result[i] = inArray[inArray.Length - 1 - i];

}
return result;
}
