// аписать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string[] NewArray3 (string[] txt)
{
    
    int n = 0;
    string[] NewStr = new string[txt.Length];
    for (int i=0; i<txt.Length; i++) 
    {
        if (txt[i].Length<4) 
        {
            NewStr[n] = txt[i];
            //Console.WriteLine(NewStr[n]);
            n++;
        }
    }
    NewStr = NewStr.Where(x => x != null).ToArray();
    return (NewStr);
}

Console.WriteLine("Введите текст");
string[] someText = Console.ReadLine().Split(" ").ToArray();
string[] NewArray = NewArray3(someText);
Console.WriteLine(string.Join(", ", NewArray));