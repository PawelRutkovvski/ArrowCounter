using ArrowCounter;
using static ArrowCounter.ArcherBase;

namespace ArrowCounter
{
    public interface IArrows
    {
        string Name { get; }

        string Surname { get; }

        void AddNumberOfArrows(int grade);

        void AddNumberOfArrows(string grade);

        event DamagesDelegate EquipmentDamage;

        Statistics GetStatistics();
    }
}
