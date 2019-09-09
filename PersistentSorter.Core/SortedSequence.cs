using System.Collections.Generic;

namespace PersistentSorter.Core
{
    public class SortedSequence
    {
        public int Id { get; set; }

        public IEnumerable<SortedNumber> Numbers { get; set; }

        public SortDirection SortDirection { get; set; }

        public int TimeTakenMilliseconds { get; set; }
    }
}