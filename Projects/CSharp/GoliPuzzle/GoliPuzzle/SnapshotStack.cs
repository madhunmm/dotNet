using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoliPuzzle
{
    class SnapshotStack
    {
        private Stack<Snapshot> snaps;

        public SnapshotStack()
        {
            snaps = new Stack<Snapshot>();
        }
        public void SaveSnapshot(Snapshot ss)   { snaps.Push(ss); }
        public Snapshot GetLatestSnapshot()     { return snaps.Peek(); }
        public void RemoveLatestSnapshot()      { snaps.Pop(); }
    }
}
