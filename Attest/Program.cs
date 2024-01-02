// See https://aka.ms/new-console-template for more information
void PrinStrinArray (string[] txt)
{
    for (int i=0; i<txt.Length; i++) 
    {
        if (txt[i].Length<4) Console.Write($"{txt[i]} ");
    }
}

Console.WriteLine("Введите текст");
string[] someText = Console.ReadLine().Split(" ").ToArray();
//string[] someText = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
PrinStrinArray(someText);