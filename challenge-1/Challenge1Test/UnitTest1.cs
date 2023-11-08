namespace Challenge1Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Challenge1.Program;  // assuming your Program.cs is in the Challenge1 namespace

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void TestSortByFrequency1()
    {
        string input = "tree";
        string expected = "eert";
        string actual = SortByFrequency(input);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestSortByFrequency2()
    {
        string input = "cccaaa";
        string expected = "aaaccc";
        string actual = SortByFrequency(input);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestSortByFrequency5()
    {
        string input = "abcabc";
        string expected = "aabbcc";
        string actual = SortByFrequency(input);
        Assert.AreEqual(expected, actual);
    }
}