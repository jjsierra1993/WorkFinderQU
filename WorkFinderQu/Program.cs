// See https://aka.ms/new-console-template for more information
using WorkFinderQu;

var matrix = ManageFiles.ReadFiles("../../../Inputs/matrix.txt");
ValidateMatrix validateMatrix = new ValidateMatrix(64,64);

if (validateMatrix.isValid(matrix))
{
    WordFinder wordFinder = new WordFinder(matrix);
    var wordsToFind = ManageFiles.ReadFiles("../../../Inputs/word_To_Find.txt");

    foreach (var word in wordFinder.Find(wordsToFind))
    {
        Console.WriteLine(word);
    }
}
else
{
    Console.WriteLine($"invalid matrix");
}



