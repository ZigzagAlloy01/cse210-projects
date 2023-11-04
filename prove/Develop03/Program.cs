using System;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        int round = 0;
        bool reload = true;
        List<int> referenceIndexes = new List<int>();
        List<string> lettersInScripture = new List<string>();
        Scripture scripture1 = new Scripture();
        scripture1._referenceIndexes = referenceIndexes;
        scripture1._lettersInScripture = lettersInScripture;
        Reference reference1 = new Reference();
        reference1._referenceIndexes = referenceIndexes;
        Word word1 = new Word();
        word1._lettersInScripture = lettersInScripture;
        string anyScripture = scripture1.WriteScripture();
        string exactReference = reference1.WriteReference();
        Console.Write(exactReference);
        Console.Write(" ");
        Console.WriteLine(anyScripture);
        while (reload == true) {
            Console.WriteLine(" ");
            Console.Write("Press 'Enter' to continue, type 'Q' to finish, or type 'R' to restore the Scripture: ");
            var userInput = Console.ReadKey();
            if(userInput.Key == ConsoleKey.Enter) {
                if (round < 100) {
                    if (round == 0) {
                        var other = round;
                        while (other > -1) {
                            Console.Write(exactReference + " ");
                            scripture1.GetScriptureLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            var result = word1.EraseLetters();
                            Console.WriteLine(result);
                            other--;
                        }
                    }
                    else if (round <= 5) {
                        var other = round;
                        while (other > (round - 1)) {
                            Console.Write(exactReference + " ");
                            word1.EraseLetters();
                            word1.EraseLetters();
                            var result = word1.EraseLetters();
                            Console.WriteLine(result);
                            other--;
                            var finish = word1.EndGame();
                            if (finish == false) {
                                reload = false;
                            }
                        }
                    }
                    else if (round > 5 && round < 9) {
                        var other = round;
                        while (other > (round - 1)) {
                            Console.Write(exactReference + " ");
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            var result = word1.EraseLetters();
                            Console.WriteLine(result);
                            other--;
                            var finish = word1.EndGame();
                            if (finish == false) {
                                reload = false;
                            }
                        }
                    }
                    else if (round > 8) {
                        var other = round;
                        while (other > (round - 1)) {
                            Console.Write(exactReference + " ");
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            word1.EraseLetters();
                            var result = word1.EraseLetters();
                            Console.WriteLine(result);
                            other--;
                            var finish = word1.EndGame();
                            if (finish == false) {
                                reload = false;
                            }
                        }
                    }
                }
                else if (round == 100) {
                    reload = false;
                }
                round ++;
            }
            else if (userInput.Key == ConsoleKey.Q) {
                reload = false;
            }
            else if (userInput.Key == ConsoleKey.R) {
                exactReference = reference1.WriteReference();
                Console.WriteLine(" ");
                Console.Write(exactReference);
                scripture1.RestoreScripture();
                round = 1;
                reload = true;
                scripture1.GetScriptureLetters();
            }
        } 
    }
}