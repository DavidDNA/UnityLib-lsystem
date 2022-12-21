using System.Collections.Generic;
using System.Text;

namespace UnityLib.LSystem {

    public class LSystem {

        /// <summary>
        /// G = (V, ?, P)
        /// </summary>
        /// <param name="axiom"></param>
        /// <param name="rules"></param>
        /// <param name="n"></param>
        public static string Compute(string axiom, IDictionary<string, string> rules, int n) {
            string result = axiom;
            for (int i = 0; i < n; i++) {
                result = ApplyRules(result, rules);
            }
            return result;
        }

        /// <summary>
        /// Applies the rules against the given string.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="alphabet"></param>
        /// <param name="rules"></param>
        /// <returns></returns>
        private static string ApplyRules(string s, IDictionary<string, string> rules) {
            StringBuilder builder = new StringBuilder();
            foreach (char c in s) {
                string predecessor = c.ToString();
                if (rules.ContainsKey(predecessor)) {
                    builder.Append(rules[predecessor]);
                } else {
                    builder.Append(predecessor);
                }
            }
            return builder.ToString();
        }
    }
}
