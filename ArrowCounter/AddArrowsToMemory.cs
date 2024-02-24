using ArrowCounter;

namespace ArrowCounter
{
    public class AddArrowsToMemory : ArcherBase
    {
        //najpierw piszemy jaki delegat będzie obsługiwać nasz event, a nastepnie jego nazwę.
        public override event DamagesDelegate EquipmentDamage;

        private List<int> arrows = new();

        public AddArrowsToMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddNumberOfArrows(int arrow)
        {
            if (arrow >= 0 )
            {
                this.arrows.Add(arrow);

                if (EquipmentDamage != null)
                {
                    EquipmentDamage(this, new EventArgs());
                    //słowo "this" - wskazanie na nas, jako sendera
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
