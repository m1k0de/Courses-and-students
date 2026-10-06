class Course
{
    public string Name;
    public int MaxSeats;
    public List<Student> Students;
    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
        Students = new List<Student>();
    }

    public void Enroll(Student student)
    {
        if (student.Join(this))
        {
        Console.WriteLine("Välkommen till kursen!");
        }
    }

    public void Remove(Student student)
    {
        student.Leave(this);
    }

    public void RollCall()
    {
        foreach (Student student in Students)
        {
            Console.WriteLine(student.Name);
        }
    }

    public override string ToString()
    {
        return $"{Name} ({Students.Count} / {MaxSeats} platser)";
    }
}