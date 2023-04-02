// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("Напишите пятизначное число: ");
string num = Console.ReadLine();

if(SearchFirstLastNum(num)){
    Console.WriteLine("Да");
}else{
    Console.WriteLine("Нет");
}

bool SearchFirstLastNum(string x)
{
    for (int i = 0; i < x.Length/2; i++)
    {    
        if(x[i] != x[x.Length-1-i]){ //проверка являеться ли числа одинаковы
            return false; // вылет из функции при любом не совпадение 
        }  
    }
    return true;// если небыло не совпадающих чисел значит число палиндромом
}

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.Write("Напишите 1 координату 1 точки");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Напишите 1 координату 2 точки");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Напишите 1 координату 3 точки");
// int z1 = int.Parse(Console.ReadLine());
// Console.Write("Напишите 2 координату 1 точки");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Напишите 2 координату 2 точки");
// int y2 = int.Parse(Console.ReadLine());
// Console.Write("Напишите 2 координату 3 точки");
// int z2 = int.Parse(Console.ReadLine());



// Console.Write(SerchR3(x1,y1,z1,x2,y2,z2));

// double SerchR3(int x1, int y1, int z1,int x2, int y2, int z2){
//     double finish = Math.Sqrt(Math.Pow((x2-x1),2)+ Math.Pow((y2-y1),2)+ Math.Pow((z2-z1),2));
//     return finish;
// }
// 

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Напишите число: ");
// int num = int.Parse(Console.ReadLine());

// CubeChisel(num);

// void CubeChisel(int num){
//     for (int i = 0; i < num; i++)
//     {
//         Console.Write($"{Math.Pow((i+1),3)} ");
//     };
// }