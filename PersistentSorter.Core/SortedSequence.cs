using System.Collections.Generic;

public class SortedSequence
{
    public IEnumerable<SortedNumber> Numbers { get; set; }

    public SortDirection SortDirection { get; set; }

    public int TimeTakenMilliseconds { get; set; }
}