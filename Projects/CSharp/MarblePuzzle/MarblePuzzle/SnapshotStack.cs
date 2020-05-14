using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarblePuzzle
{
    class SnapshotStack
    {
        private Stack<Snapshot> snaps;

        public SnapshotStack()
        {
            snaps = new Stack<Snapshot>();
        }
        public void SaveSnapshot(Snapshot ss)       { snaps.Push(new Snapshot(ss)); }
        public Snapshot GetLatestSnapshot()         { return snaps.Peek(); }
        public Snapshot RemoveLatestSnapshot()      { return snaps.Pop(); }
        public Boolean HasMoreSnapshots()           { return snaps.Count != 0; }
        public int GetSnapshotCount()               { return snaps.Count; }
    }
}
