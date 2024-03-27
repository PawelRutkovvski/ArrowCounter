using ArrowCounter;
using static ArrowCounter.TrainingBase;

namespace ArrowCounter
{
    public interface ITraining
    {
        void AddNumberOfArrows(int arrow);

        void AddNumberOfArrows(string arrow);

        void ShowNumberOfArrows();

        event ArrowDamageDelegate ArrowDamage;

        Statistics GetStatistics();

        void ShowStatistics();
    }
}
