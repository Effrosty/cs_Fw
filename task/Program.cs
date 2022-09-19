using System;
using static System.Console;

string[] arr1 = new string[]{"Hello","2","world",":-)"};
string[] arr2 = new string[] { "1234", "1567", "-2", "computer science" };
string[] arr3 = new string[] { "Russia", "Denmark", "Kazan"};

void printStringArr(string[]arr)
{
    Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
            Write($"\"{arr[i]}\"");
       if(i!=arr.Length-1) Write(", ");
    }
    Write("]");
}
string[] noMore3SymbolArr(string[]arr)
{
    int resultLength = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length<4)resultLength++;
    }

    string[] result=new string[resultLength];
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
            if (arr[i].Length < 4)
            {
                result[counter++] = arr[i]; 
            }
    }
    return result;
}
void printResult(string[] arr)
{ 
printStringArr(arr);
Write(" → ");
printStringArr(noMore3SymbolArr(arr));
    Write("\n");
}

printResult(arr1);
printResult(arr2);
printResult(arr3);
