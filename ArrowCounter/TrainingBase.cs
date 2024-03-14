using ArrowCounter;

namespace ArrowCounter
{
    public abstract class TrainingBase : ITraining
    {
        public delegate void ArrowDamageDelegate(object sender, EventArgs args);

        public abstract event ArrowDamageDelegate ArrowDamage;
        public override string Date { get; set; }

        public TrainingBase(string date)
        {
            this.Date = date;
        }

        public abstract void AddNumberOfArrows(int arrow);

        public abstract void AddNumberOfArrows(string arrow);

        public abstract void ShowNumberOfArrows();

        public abstract Statistics GetStatistics();

        public void ShowStatistics()
        {
            var staty = GetStatistics();
            if(staty.Count != 0)
            {
                ShowNumberOfArrows();
                Console.WriteLine($"Statistics: ");
                Console.WriteLine();
                Console.WriteLine($"Total amount of arrows: {staty.Count}");
                Console.WriteLine($"Highest amount of arrows: {staty.Max}");
                Console.WriteLine($"Lowest amount of arrows: {staty.Min}");
                Console.WriteLine($"Averge amount of arrows: {staty.Min}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There is no statistics due to lack of information.");
            }
        }

        protected void EventArrowDamage()
        {
            ArrowDamage?.Invoke(this, new EventArgs());
        }
    }
}