using ArrowCounter;

namespace ArrowCounter
{
    public class AddArrowsToFile : ArcherBase
    {
        private const string fileName = "arrows.txt";

        public override event DamagesDelegate EquipmentDamage;

        public AddArrowsToFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddNumberOfArrows(int arrow)
        {
            if (arrow >= 0)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(arrow);
                }

                if (EquipmentDamage != null)
                {
                    EquipmentDamage(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid Grade Value");
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

        public override Statistics GetStatistics()
        {
            var arrowsFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(arrowsFromFile);
            return result;
        }

        private List<int> ReadGradesFromFile()
        {
            var arrows = new List<int>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = int.Parse(line);
                        arrows.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return arrows;
        }

        private Statistics CountStatistics(List<int> arrows)
        {
            var statistics = new Statistics();

            foreach (var arrow in arrows)
            {
                statistics.AddNumberOfArrows(arrow);
            }
            return statistics;
        }
    }
}
