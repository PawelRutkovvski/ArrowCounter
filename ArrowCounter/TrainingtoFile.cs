using ArrowCounter;
using System.Runtime.CompilerServices;
using System.Text;

namespace ArrowCounter
{
    public class TrainingToFile : TrainingBase
    {
        private const string fileName = "arrowCounter.txt";

        public override event ArrowDamageDelegate ArrowDamage;

        private string fullFileName;

        public TrainingToFile()
        {
            fullFileName = $"{fileName}";
        }

        public override void AddNumberOfArrows(int arrow)
        {
            if (arrow >= 0)
            {
                using (var writer = File.AppendText($"{fullFileName}"))
                {
                    writer.WriteLine(arrow);
                }

                if (arrow == -1)
                {
                    EventArrowDamage();
                }
            }
            else
            {
                throw new Exception("Invalid Arrow Value");
            }
        }

        public override void AddNumberOfArrows(string arrow)
        {
            if (int.TryParse(arrow, out int result))
            {
                this.AddNumberOfArrows(result);
            }
            else throw new Exception("Check What You Have Added.");
        }

        public override void ShowNumberOfArrows()
        {
            StringBuilder toFileBuild = new StringBuilder($"Number arrows I have shot: ");

            using (var reader = File.OpenText($"{fullFileName}"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    toFileBuild.Append($"{line}, ");
                    line = reader.ReadLine();
                }
            }

            Console.WriteLine($"\n{toFileBuild}");
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            if (File.Exists($"{fullFileName}"))
            {
                using (var reader = File.OpenText($"{fullFileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = int.Parse(line);
                        result.AddNumberOfArrows(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return result;
        }
    }
}
