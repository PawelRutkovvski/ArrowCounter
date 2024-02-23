using ArrowCounter;

namespace ArrowCounter
{
    public class Statistics
    {
        public float Max { get; private set; }
        public float Min { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddNumberOfArrows(int arrow)
        {
            this.Count++;
            this.Sum += arrow;
            this.Min = Math.Min(arrow, this.Min);
            this.Max = Math.Max(arrow, this.Max);
        }
    }
}
