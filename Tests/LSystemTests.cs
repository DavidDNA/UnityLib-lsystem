using NUnit.Framework;
using System.Collections.Generic;
using UnityLib.LSystem;

public class LSystemTests {

    /// <summary>
    /// Taken from https://en.wikipedia.org/wiki/L-system
    /// 
    /// Variables: A, B
    /// Axiom: A
    /// Rules: (A => AB), (B => A)
    /// </summary>
    [Test]
    public void ItShouldApplyRules() {
        string axiom = "A";

        IDictionary<string, string> rules = new Dictionary<string, string>() {
            { "A", "AB" },
            { "B", "A" }
        };

        string result = LSystem.Compute(axiom, rules, 0);
        Assert.AreEqual(result, "A");

        result = LSystem.Compute(axiom, rules, 1);
        Assert.AreEqual(result, "AB");

        result = LSystem.Compute(axiom, rules, 2);
        Assert.AreEqual(result, "ABA");

        result = LSystem.Compute(axiom, rules, 3);
        Assert.AreEqual(result, "ABAAB");

        result = LSystem.Compute(axiom, rules, 4);
        Assert.AreEqual(result, "ABAABABA");

        result = LSystem.Compute(axiom, rules, 5);
        Assert.AreEqual(result, "ABAABABAABAAB");

        result = LSystem.Compute(axiom, rules, 6);
        Assert.AreEqual(result, "ABAABABAABAABABAABABA");

        result = LSystem.Compute(axiom, rules, 7);
        Assert.AreEqual(result, "ABAABABAABAABABAABABAABAABABAABAAB");
    }

    /// <summary>
    /// Taken from https://en.wikipedia.org/wiki/L-system
    /// 
    /// Variables: 0, 1
    /// Constants: [, ]
    /// Axiom: 0
    /// Rules: (1 => 11), (0 => 1[0]0)
    /// </summary>
    [Test]
    public void ItShouldKeepConstants() {
        string axiom = "0";

        IDictionary<string, string> rules = new Dictionary<string, string>() {
            { "1", "11" },
            { "0", "1[0]0" }
        };

        string result = LSystem.Compute(axiom, rules, 0);
        Assert.AreEqual(result, "0");

        result = LSystem.Compute(axiom, rules, 1);
        Assert.AreEqual(result, "1[0]0");

        result = LSystem.Compute(axiom, rules, 2);
        Assert.AreEqual(result, "11[1[0]0]1[0]0");

        result = LSystem.Compute(axiom, rules, 3);
        Assert.AreEqual(result, "1111[11[1[0]0]1[0]0]11[1[0]0]1[0]0");
    }
}
