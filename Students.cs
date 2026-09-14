class Student
{
    public string Name;
    public List<Course> Courses;
    public Student(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }
}