using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day8 {
    public class DayEight {
    }

    public class TreeGrid {
        private int[,] _matrix;
        
        public TreeGrid(string input) {
            var allRows = input.SplitOnNewline();
            for (int x = 0; x < allRows.Length; x++) {
                var row = allRows[x];

                if (_matrix == null) {
                    _matrix = new int[allRows.Length, row.Length];
                }

                for (int y = 0; y < row.Length; y++) {
                    _matrix[x, y] = (int)char.GetNumericValue(row[y]);
                }

            }
        }

        public int VisibleTrees() {
            var count = 0;

            for (int x = 0; x < _matrix.GetLength(0); x++) {
                for (int y = 0; y < _matrix.GetLength(1); y++) {
                    if (IsVisible(x, y, _matrix[x,y])) {
                        count++;
                    }
                }
            }

            return count;
        }

        public int ScenicScore() {
            var highScore = 0;
            for (int x = 0; x < _matrix.GetLength(0); x++) {
                for (int y = 0; y < _matrix.GetLength(1); y++) {
                    var score = ScenicScore(x, y, _matrix[x,y]);

                    if (score > highScore) {
                        highScore = score;
                    }
                }
            }
            return highScore;
        }

        private bool IsVisible(int treeX, int treeY, int treeHeight) {
            if (IsEdgeTree(treeX, treeY)) {
                return true;
            }

            var visible = true;
            for (int x = treeX + 1; x < _matrix.GetLength(0); x++) {
                if (_matrix[x, treeY] >= treeHeight) {
                    visible = false;
                    break;
                }
            }

            if (visible) {
                return true;
            }
            
            visible = true;
            for (int x = treeX - 1; x >= 0; x--) {
                if (_matrix[x, treeY] >= treeHeight) {
                    visible = false;
                    break;
                }
            }

            if (visible) {
                return true;
            }

            visible = true;
            for (int y = treeY + 1; y < _matrix.GetLength(1); y++) {
                if (_matrix[treeX, y] >= treeHeight) {
                    visible = false;
                }
            }

            if (visible) { 
                return true;
            }

            visible = true;
            for (int y = treeY - 1; y >= 0; y--) {
                if (_matrix[treeX, y] >= treeHeight) {
                    visible = false;
                    break;
                }
            }

            return visible;
        }

        private int ScenicScore(int treeX, int treeY, int treeHeight) {
            if (IsEdgeTree(treeX, treeY)) {
                return 0;
            }

            var scenicScore = 0;
            for (int x = treeX + 1; x < _matrix.GetLength(0); x++) {
                scenicScore++;
                if (_matrix[x, treeY] >= treeHeight) {
                    break;
                }
            }

            var count = 0;
            for (int x = treeX - 1; x >= 0; x--) {
                count++;
                if (_matrix[x, treeY] >= treeHeight) {
                    break;
                }
            }

            scenicScore *= count;

            count = 0;
            for (int y = treeY + 1; y < _matrix.GetLength(1); y++) {
                count++;
                if (_matrix[treeX, y] >= treeHeight) {
                    break;
                } 
            }

            scenicScore *= count;

            count = 0;
            for (int y = treeY - 1; y >= 0; y--) {
                count++;
                if (_matrix[treeX, y] >= treeHeight) {
                    break;
                } 
            }

            return scenicScore *= count;
        }

        private bool IsEdgeTree(int x, int y) {
            return (x == 0 || y == 0 || x == _matrix.GetLength(0) - 1 || y == _matrix.GetLength(1) - 1);
        }
    }
}
