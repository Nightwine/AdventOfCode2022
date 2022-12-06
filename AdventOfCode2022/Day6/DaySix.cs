namespace AdventOfCode2022.Day6 {
    public class DaySix {
        private readonly PacketReader _packetReader;

        public DaySix(string input) {
            _packetReader = new PacketReader(input);
        }

        public int DoFirstPuzzle() {
            return _packetReader.StartMarkerCompletedIndex();
        }

        public int DoSecondPuzzle() {
            return _packetReader.StartMessageCompletedIndex();
        }
    }
}
