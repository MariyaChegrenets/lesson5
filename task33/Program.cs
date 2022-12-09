// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

int[] array = new int[4];
Random random = new Random();
for(int i=0; i<array.Length; i++)
    array[i] = random.Next(-100,101);
Console.WriteLine(string.Join(",", array)); 

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindElement(array,a));    

bool FindElement (int[] array, int a)
{
    bool count = false;
    for(int i=0; i<array.Length; i++)
        if(array[i] == a)
            count = true;
    return count;
}