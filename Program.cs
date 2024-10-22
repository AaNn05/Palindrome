using Algorithms;

Console.Write("Input a word: ");
string word = Console.ReadLine().ToLower();

int n = word.Length;
bool result = true;

Console.WriteLine(Palindrome.checker(word, n, result));