using Xunit;
using System;
using System.Collections.Generic;
using NumbersToWordsProject.Objects;

namespace NumbersToWordsTester
{
  public class NumbersToWordsTest
  {
    [Fact]
    public void SingleDigitNumberToWord_ReturnWord()
    {
      NumbersToWords newNumbersToWords = new NumbersToWords();
      Assert.Equal("one", newNumbersToWords.Converter(1));
    }
    [Fact]
    public void DoubleDigitNumberToWord_ReturnWord()
    {
      NumbersToWords newNumbersToWords = new NumbersToWords();
      Assert.Equal("thirteen", newNumbersToWords.Converter(13));
    }

  }
}
