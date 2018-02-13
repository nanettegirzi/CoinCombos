using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombo;
using System.Collections.Generic;

namespace CoinCombo.Tests
{
  [TestClass]
  public class CoinsTest
  {
    [TestMethod]
    public void CorrectChange_ForOneCoin_OneQuarter()
    {
      Coins testCoins = new Coins();
      Assert.AreEqual("1 Quarter", testCoins.MakeChange (25));
    }
    [TestMethod]
    public void CorrectChange_ForThreecents_ThreePennies()
    {
      Coins testCoins = new Coins();
      Assert.AreEqual("3 Pennies", testCoins.MakeChange (3));
    }
    [TestMethod]
    public void CorrectChange_For21Cents_2D1P()
    {
      Coins testCoins = new Coins();
      Assert.AreEqual("2 Dimes, 1 Penny", testCoins.MakeChange (21));
    }
    [TestMethod]
    public void CorrectChange_For68Cents_2Q1D1N3P()
    {
      Coins testCoins = new Coins();
      Assert.AreEqual("2 Quarters, 1 Dime, 1 Nickel, 3 Pennies", testCoins.MakeChange (68));
    }
  }
}
