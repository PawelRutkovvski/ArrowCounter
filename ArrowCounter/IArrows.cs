using ArrowCounter;
using static ArrowCounter.EmployeeBase;

namespace ArrowCounter
{
    public interface IArrows
    {
        string Name { get; }

        string Surname { get; }

        void AddGrade(int grade);

        void AddGrade(string grade);

        event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();
    }
}
