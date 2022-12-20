namespace UnityLib.LSystem {

    public class LSystem {

        /// <summary>
        /// G = (V, ?, P)
        /// </summary>
        /// <param name="axiom"></param>
        /// <param name="rules"></param>
        /// <param name="n"></param>
        public static string Compute(string axiom, string[] variables, string[] constants, Rule[] rules, int n) {
            return "Hello";
        }
    }

    public struct Rule {
        public string predecessor;
        public string successor;
    }
}
