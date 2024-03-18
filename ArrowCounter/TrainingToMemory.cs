using ArrowCounter;
using System.Text;

namespace ArrowCounter
{
    public class TrainingToMemory : TrainingBase
    {
        public override event ArrowDamageDelegate ArrowDamage;

        private List<int> arrows = new();
        private string date;

        public TrainingToMemory(string data) : base(data)
        {
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
            else throw new Exception("Enter NUMBER of arrows");
        }

        public override void ShowNumberOfArrows()
        {
            Console.WriteLine("Let's See How Strong I Am: ");
            if(arrows.Count == 0)
            {
                Console.WriteLine("There Was No Training");
            }
            else
            {
                foreach(var arrow in arrows)
                {
                    Console.WriteLine(arrow);
                }
            }
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
