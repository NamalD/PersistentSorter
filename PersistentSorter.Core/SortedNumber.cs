namespace PersistentSorter.Core
{
    public class SortedNumber
    {
        public int Id { get; set; }

        public SortedSequence Sequence { get; set; }

        public int Value { get; set; }

        public int UnsortedOrder { get; set; }

        public int SortedOrder { get; set; }
    }
}