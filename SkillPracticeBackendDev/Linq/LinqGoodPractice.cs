namespace SkillPracticeBackendDev.Linq;
public class LinqGoodPractice
{
    public delegate bool IsEvenDelegate(int number);

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static IEnumerable<Student> TeenagerStudents()
    {
        var students = new List<Student>() {
            new Student()
            {
                Id = 1,
                Name = "Zarni",
                Score=85,
                Age=23
            },
             new Student()
            {
                Id = 2,
                Name = "MG",
                Score=90,
                Age=33
            },
             new Student()
            {
                Id = 3,
                Name = "Saw",
                Score=66,
                Age=30
            }
        };
        return students.Where(s=>s.Age>29);
    }
    public static IEnumerable<Student> GroupByStudents()
    {
        var students = new List<Student>() {
            new Student()
            {
                Id = 1,
                Name = "Zarni",
                Score=85,
                Age=23
            },
             new Student()
            {
                Id = 2,
                Name = "MG",
                Score=90,
                Age=33
            },
             new Student()
            {
                Id = 3,
                Name = "Saw",
                Score=66,
                Age=30
            }
        };
        return students.GroupBy(g=>g.Age).Select(g=>new Student
        {
        });
    }
}

public class Student
{
    public int Id { get; set; }
    public float Score { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"[I am {Name} and I am {Age} years old.My Id is {Id} and I got {Score} in my  AWS SAA c03 exam.]";
    }
}
