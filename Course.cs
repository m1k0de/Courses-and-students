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
        if (Students.Count < MaxSeats)
        {
        student.Join(this);
        Console.WriteLine("Välkommen till kursen!");
        }
        else
        {
        Console.WriteLine("Kursen är full");
        }
    }
}