using System.Collections.Generic;
using System;

namespace Scrabbles.Models
{
  public class Scrabble
  {
    private string _yourWord;
    private char[] _letters;
    private string[] _word;
    private int _letterScore;
    private int _wordScore;
    private static List<Scrabble> _instances = new List<Scrabble> {};

    public Scrabble(string[] word)
    {
      _word = word;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static List<Scrabble> GetAll()
    {
      return _instances;
    }
    public string GetYourWord()
    {
      return _yourWord;
    }
    public void SetYourWord(string yourWord)
    {
      _yourWord = yourWord;
    }
    public char[] GetLetters()
    {
      return _letters;
    }
    public void SetLetters(char[] letters)
    {
      _letters = letters;
    }
    public int GetLetterScrore()
    {
      return _letterScore;
    }
    public void SetLetterScore(int letterScore)
    {
      _letterScore = letterScore;
    }
    public int GetWordScore()
    {
      return _wordScore;
    }
    public void SetWordScore(int wordScore)
    {
      _wordScore = wordScore;
    }
    public string[] GetWord(string word)
    {
      return _word;
    }
    public void SetYourWord(char[] letter)
    {
      _word = letter;
    }
    public void BreakKeyWord(string word)
    {
      SetYourWord(word.ToCharArray());
    }


    // private int GetLetterScrore()
    // {
    //   int score = 0;
    //   foreach(char letter in this.Letters)
    //   {
    //     _letter = "a", "e", "i", "o", "u", "l", "n", "r", "s", "t";
    //     {
    //       return letterScore(1);
    //     }
    //     _letter = {"d","g"};
    //     {
    //       return letterScore(2);
    //     }
    //     _letter = "b", "c", "m", "p";
    //     {
    //       return letterScore(3);
    //     }
    //     _letter = {"f", "h", "v", "w", "y"};
    //     {
    //       return letterScore(4);
    //     }
    //     _letter = {"k"};
    //     {
    //       return letterScore(5);
    //     }
    //     _letter = {"j", "x"};
    //     {
    //       return letterScore(8);
    //     }
    //     _letter = {"q", "z"};
    //     {
    //       return letterScore(10);
    //     }
    //
    //   }
    // }
  }
}
