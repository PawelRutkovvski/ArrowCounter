using ArrowCounter;

namespace ArrowCounter
{
    public class TrainingToMemory : TrainingBase
    {
        public override event ArrowDamageDelegate ArrowDamage;

        private List<int> arrows = new();
        private string date;

        private override string Date
        {
            get
            {
                return date;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    date = value;
                }
            }
        }

        public TrainingToMemory(string data) : base(data)
        {
            List<int> arrows = new();
        }

        public override void AddNumberOfArrows(int arrow)
        {
            if (arrow >= 0)
            {
                this.arrows.Add(arrow);

                if (arrow == -1)
                {
                    EventArrowDamage();
                }
            }
            else
            {
                throw new Exception("Invalid Arrows Value");
            }
        }

        public override void AddNumberOfArrows(string arrow)
        {
            if (int.TryParse(arrow, out int result))
            {
                this.AddNumberOfArrows(result);
            }
            else throw new Exception("String is not an int.");
        }

        public override void ShowNumberOfArrows()
        {
            StringMaker sm = new StringMaker("This is the number of shots: ");

            for (int i = 0; i < arrows.Count; i++)
            {
                sm.Add(arrows[i]);
            }
            Console.WriteLine($"\n");
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var arrow in this.arrows)
            {
                statistics.AddNumberOfArrows(arrow);
            }

            return statistics;
        }
    }
}
