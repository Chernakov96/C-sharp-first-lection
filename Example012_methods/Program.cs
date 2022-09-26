// // first type - метод не принимает и не возвращает ничего
// void Method1()
// {
//     Console.WriteLine("author is ...");
// }
// Method1();

// //second type - метод принимает, но не возвращает значения
// void Method2(string name)
// {
//     Console.WriteLine(name);
// }
// Method2("name");

// void method21(string name, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(name);
//         i++;
//     }
// }
// method21("name", 4); //можно явно указывать какому аргументу какое значение присваивается путем "(name: "somethring", count: 4)". 
// //Если писать таким образом, то порядок указания методов не имеет значения.

// //third type - метод не принимает, но возвращает значение
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// //fourth type - метод принимает и возвращает значения
// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty;
// //     while (i < count)
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result;
// // }

// string Method4(int count, string text)
// {
    
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "ass");
// Console.WriteLine(res);

// //"for" cycle
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty";
//             012345
// s[3] //r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '-');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(text, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();