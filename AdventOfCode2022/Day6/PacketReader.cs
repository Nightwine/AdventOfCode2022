using System;
using System.Linq;

namespace AdventOfCode2022.Day6 {
    public class PacketReader {
        private readonly string _stream;
        private readonly int _packetMarkerSize = 4;
        private readonly int _messageMarkerSize = 14;

        public PacketReader(string stream) {
            _stream = stream;
        }

        public int StartMarkerCompletedIndex() {
            return MarkerCompletedIndexAt(_packetMarkerSize);
        }

        public int StartMessageCompletedIndex() {
            return MarkerCompletedIndexAt(_messageMarkerSize);
        }

        private int MarkerCompletedIndexAt(int markerSize) {
            for (int i = 0; i + markerSize < _stream.Length; i++) {
                var potentialMarker = _stream.Take(new Range(i, i + markerSize));
                if (potentialMarker.Distinct().Count() == markerSize) {
                    return i + markerSize;
                }
            }

            throw new Exception("Start message not found");
        }
    }
}
