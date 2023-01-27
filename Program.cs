// Программа которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа
string[] stringArray = { "string", "arr", "new", "1", "array", "2345", "rt" };
int stringLength = 3;
PrintArray(stringArray);
string[] newArr = generatesNewArrayOfStringsGivenLength(stringArray, stringLength);
PrintArray(newArr);

//Метод, формирующий из исходного строкового массива новый массив из строк, длина которых не превышает заданного значения:
string[] generatesNewArrayOfStringsGivenLength(string[] sourceArray, int strLength)
{
	int count = 0;
	string[] newArray = new string[count];

	for (int i = 0; i < sourceArray.Length; i++)
	{
		if (sourceArray[i].Length <= strLength)
		{
			count++;
			string[] tempArray = new string[count]; // временный массив, длина которого зависит от количества элементов, удовлетворяющих условию

			for (int j = 0; j < tempArray.Length - 1; j++)
			{
				tempArray[j] = newArray[j]; // во временный массив копируется содержимое нового массива
			}

			tempArray[count - 1] = sourceArray[i]; // добавить новый элемент во временный массив
			newArray = tempArray; // перенаправить ссылку формируемого массива на временный массив
		}
	}

	return newArray;
}

// Метод, выводящий строковый массив в консоль:
void PrintArray(string[] array)
{
	System.Console.WriteLine(string.Join("; ", array));
}