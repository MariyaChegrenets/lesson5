// Задача 32: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Write("Input array.Length: "); //пользователь задает длину массива вручную
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a]; // создали массив с именем array из a элементов 

Random random = new Random(); //создали экземпляр класса Random, чтобы генерировать случайные числа
for(int i=0; i < array.Length; i++) // цикл, чтобы пройтись по каждому элементу(ячейке) массива array
{
    array[i] = random.Next(-9,10); // заполняем каждую ячейку массива array случайными числами (диапазон выбираем сами)
}
Console.WriteLine(string.Join(" ", array));
Console.WriteLine(string.Join(" ", Zamena(array)));

int[] Zamena (int[] array)
{
    for(int i=0; i<array.Length; i++)
        array[i] = -1*array[i];  // или array[i] *= -1 или array[i] = -array[i]
    return array;
}