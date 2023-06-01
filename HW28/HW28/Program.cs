using System.Threading.Channels;

using System;

    string namesPath = "C:/GitHubProjects/names.txt";
    string[] names = File.ReadAllLines(namesPath);
//find names with "s" in the end;
    string[] FindNamesEndsWithS()
    {
        return names.Where(n => n.EndsWith('s')).ToArray();
    }
    //find longest Name size
    int FindLongestNameSize()
    {
        return names.Max(n => n.Length);
    }
    foreach (var name in FindNamesEndsWithS())
    {
        Console.WriteLine(name);
    }
    //print longest name
    //OrderByDescending - сортирует элементы массива по их длинне по убыванию
    //соответственно первый элемент будет самый большой
Console.WriteLine(names.OrderByDescending(n => n.Length).First());
    
Console.WriteLine(FindLongestNameSize());



