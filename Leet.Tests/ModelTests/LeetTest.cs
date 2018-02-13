using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Leet;
using Leet.Models;

namespace Leet.Tests
{
  [TestClass]
  public class LeetTest
  {
    [TestMethod]
    public void ChangeE_Returns3_String()
    {
      Message newMessage = new Message();
      Assert.AreEqual(true, "h3llo" == newMessage.IntoLeet("hello"));
    }
  }
}
