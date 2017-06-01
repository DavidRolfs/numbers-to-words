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
      int[] singleNumbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
      int[] teenNumbers = {10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
      string[] singleNumberNames = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
      string[] teenNumberNames = {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

      if (userInput < 10)
      {
        for(int i = 0; i < singleNumbers.Length; i++)
        {
          if(userInput == singleNumbers[i])
          {
            return singleNumberNames[i];
          }
        }
      }
      else if(userInput < 20)
      {
        for(int i = 0; i < teenNumbers.Length; i++)
        {
          if(userInput == teenNumbers[i])
          {
            return teenNumberNames[i];
          }
        }
      }
      return "error";
    }
  }
}
