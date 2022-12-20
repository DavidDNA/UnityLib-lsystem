using NUnit.Framework;
using UnityLib.LSystem;

public class LSystemTests {

    [Test]
    public void LSystemTestsSimplePasses() {
        string result = LSystem.Compute("A", new string[] { "A", "B" }, new string[] { "+" }, new Rule[] { }, 1);
        Assert.AreEqual(result, "Hello");
    }
}
