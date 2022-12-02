using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.DayOne
{
    public class DayOne {
        private readonly List<int> _packs;

        public DayOne(string calorieList) {
            var inputLines = calorieList.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            var packCalories = 0;
            _packs = new List<int>();

            foreach (var line in inputLines) {
                if (int.TryParse(line, out var snackCalories)) {
                    packCalories += snackCalories;
                } else {
                    _packs.Add(packCalories);
                    packCalories = 0;
                }
            }

            if (packCalories != 0) {
                _packs.Add(packCalories);
            }
        }

        public int CaloriesInLargestBag() {
            return _packs.Max();
        }

        public int CaloriesInTopLargestBags(int count) {
            var orderedPacks = _packs.OrderDescending();
            var topPacks = orderedPacks.Take(count);

            return topPacks.Sum();
        }
    }
}
