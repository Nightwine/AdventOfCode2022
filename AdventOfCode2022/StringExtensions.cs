using System;

namespace AdventOfCode2022 {

    public static class StringExtensions {
        public static string[] SplitOnNewline(this string s) {
            return s.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
        }
    }
}
