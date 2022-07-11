// //Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string num) //----------------------------Ввод чисел в терминале
{
    System.Console.Write (num);
    return int.Parse(Console.ReadLine());
}

int [] RandomArray (int length)//---------------------Заполнение массива с клавиатуры
{
    int[] newarray = new int[length];
    //Random rand = new Random();
    for (int i = 0;i < newarray.Length; i++)
    {
        newarray[i] = Prompt($"Введите {i+1}-ое число в массив ");     
    }
    return newarray;
}

int Count(int  num_M, int  []A, int l, int count) // Подсчет количества элементов массива, больших  зданного числа M
//num_M - число с которым сравниваем;
//A - массив:
//l - колличество ээлементов в массиве A.Legth;
//count = количество искомых элементов > числа num ;
//
{
    if (count==l)
        return 0; // выход из функции
    else
    {
        if (num_M<A[count])
            return Count(num_M, A, l, count+1) + 1; // добавить 1 к результату, и перейти далее
        else
            return Count(num_M, A, l, count+1); // перейти к следующему элементу массива
    }
} 
int Num = Prompt("Введите число с которым нужно сравнивать  --> ");
int LengthArray = Prompt("Введите длину массива --> ");
int []A = RandomArray(LengthArray);;
int count = Count(Num, A, LengthArray, 0);
Console.WriteLine($"Количество чисел в массиве > {Num} = {count}");