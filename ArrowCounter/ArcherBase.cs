using ArrowCounter;

namespace ArrowCounter
{
    public abstract class ArcherBase : IArrows
    {
        public delegate void DamagesDelegate(object sender, EventArgs args);

        public abstract event DamagesDelegate EquipmentDamage;

        public ArcherBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract void AddNumberOfArrows(int grade);

        public abstract void AddNumberOfArrows(string grade);

        public abstract Statistics GetStatistics();
    }
}
