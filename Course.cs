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
}