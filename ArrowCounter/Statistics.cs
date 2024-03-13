using ArrowCounter;

namespace ArrowCounter
{
    public class Statistics
    {
        public int Max;
        public int Min;
        public int Sum;
        public int Count; 
        public int Average
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
            this.Max = int.MinValue;
            this.Min = int.MaxValue;
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
