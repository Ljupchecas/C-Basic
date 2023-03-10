// Take a sentence as input and print its words.

Console.Write("Enter one sentence > ");

string inputSentence = Console.ReadLine();

string[] words = inputSentence.Split(' ');

Console.WriteLine("The words in the sentence entered are:");

foreach (string word in words)
{
    Console.WriteLine(word);
}
