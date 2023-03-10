// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

// int[] CreateArray(int size){
//     int[] array = new int[size];
//     int i;
//     for(i = 0; i < size; i++){
//         Console.Write("element - {0} : ",i);
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void CountPositive(int[] array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i] > 0){
//             count++;
//         }
//     }
//     Console.WriteLine($"The amount of numbers over 0 is - {count} ");
// }

// Console.WriteLine("Enter the size of the array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = CreateArray(size);
// Console.WriteLine($"Your array is {arr}");
// CountPositive(arr);




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




double FindY(double bone, double btwo, double kone, double ktwo){
    double res = (kone*btwo - ktwo*bone)/(kone-ktwo);
    if(kone-ktwo == 0)
        Console.WriteLine("Error because of dividing by zero");
    return res;
}

double FindX(double bone, double btwo, double kone, double ktwo){
    double res = (FindY(bone, btwo, kone, ktwo)/kone) - (bone/kone);
    if(kone == 0)
        Console.WriteLine("Error because of dividing by zero");
    return res;
}

Console.WriteLine("Enter the value b1: ");
double bone = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the value k1: ");
double kone = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the value b2: ");
double btwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the value k2: ");
double ktwo = Convert.ToInt32(Console.ReadLine());
double Xnum = FindX(bone, btwo, kone, ktwo);
double Ynum = FindY(bone, btwo, kone, ktwo);
Console.WriteLine($"The junction point of the two Lines is ( {Xnum} ; {Ynum} )");