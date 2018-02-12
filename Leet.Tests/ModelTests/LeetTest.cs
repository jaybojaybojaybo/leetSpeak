using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leet;

namespace Leet.Tests
{
  [TestClass]
  public class LeetTest
  {
    [TestMethod]
    public void ChangeE_Returns3_String()
    {
      char[] testMessage = "hello".ToCharArray();
      char[] leetMessage;
      foreach (char in testMessage)
      {
        if (char == "e" || char =="E")
        {
          leetMessage.push("3");
        }
        else
        {
          leetMessage.push(char);
        }
      }
      string result = string.Join("", leetMessage);
      return result;
    }
  }
}
