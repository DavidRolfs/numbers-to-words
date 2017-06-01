using Nancy;
using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace NumbersToWordsProject.Objects
{
  public class NumbersToWords
  {
    public string Converter(int userInput)
    {
      int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
      string[] numberNames = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

      for(int i = 0; i < numbers.Length; i++)
      {
        if(userInput == numbers[i])
        {
          return numberNames[i];
        }
      }
      return "error";
    }
  }
}
