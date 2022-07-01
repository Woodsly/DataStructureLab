using System.Collections;

Console.WriteLine("Please enter a word that you would like reversed");
string word = Console.ReadLine();
Console.WriteLine(Reverser(word));

//Methods
static string Reverser(string input)
{
    char[] inputArray = input.ToCharArray();
    int size = inputArray.Length;
    Stack stacker = new Stack(size);
    string result;
    int i;
    for(i = 0; i < size; ++i)
    {
        stacker.Push(inputArray[i]);
    }
    for(i = 0; i < size; ++i)
    {
        inputArray[i] = (char)stacker.Pop();
    }
    result = string.Join("",inputArray);
    return result;
}