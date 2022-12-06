namespace AdventOfCode2022.DayThree {
    public static class ItemValueChecker {
        public static int For(char item) {
            var value = item % 32;
            if (char.IsUpper(item)) {
                value += 26;
            }
            return value;
        }
    }
}
