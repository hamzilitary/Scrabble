using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabbles;
using Scrabbles.Models;
using System.Collections.Generic;

namespace Scrabbles.Tests
{
  [TestClass]
  public class Scrabble

{
  [TestMethod]
  public void BreakMyKeyword()
  {
    Scrabble tester = new Scrabble();
    tester.SetYourWord("Test");
    tester.BreakKeyWord();
    Assert.AreEqual(true, tester.GetLetter());
    Assert.AreEqual(false, tester.GetLetter());
  }
}
}
