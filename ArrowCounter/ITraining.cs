using ArrowCounter;
using static ArrowCounter.TrainingBase;

namespace ArrowCounter
{
    public interface ITraining
    {
        string Date { get; set; }

        void AddNumberOfArrows(int arrow);

        void AddNumberOfArrows(string arrow);

        event ArrowDamageDelegate ArrowDamage;

        void ShowNumberOfArrow();

        Statistics GetStatistics();

        void ShowStatistics();
    }
}
