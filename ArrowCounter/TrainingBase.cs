using ArrowCounter;

namespace ArrowCounter
{
    public abstract class TrainingBase : ITraining
    {
        public delegate void ArrowDamageDelegate(object sender, EventArgs args);

        public event ArrowDamageDelegate ArrowDamage;
        public string Date { get; private set; }

        public TrainingBase(string date)
        {
            this.Date = date;
        }

        public abstract void AddNumberOfArrows(int arrow);

        public abstract void AddNumberOfArrows(string arrow);

        public abstract Statistics GetStatistics();

        public abstract void ShowNumberOfArrows();

        public void ShowStatistics()
        {
            var staty = GetStatistics();
            if(staty.Count != 0) 
            {
                ShowNumberOfArrows();
                Console.WriteLine("Training General Statistics: ");
                Console.WriteLine($"Total amount of arrows: {staty.Count} ");
                Console.WriteLine($"Minimum amount of arrows: {staty.Min} ");
                Console.WriteLine($"Maximum amount of arrows: {staty.Max} ");
                Console.WriteLine($"Average amount of arrows: {staty.Average:N2} ");
            }
            else
            {
                Console.WriteLine("There is no date to show any statistics");
            }
        }

        protected void EventArrowDamage()
        {
            if( ArrowDamage != null )
            {
                ArrowDamage(this, new EventArgs());
            }
        }
    }
}
