class Student
{
    public string Name;
    public List<Course> Courses;
    public Student(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }
    public bool Join(Course course)
    {
        if (Courses.Contains(course) || course.Students.Contains(this))
        {
            Console.WriteLine($"{Name} är redan anmäld till {course.Name}");
            return false;
        }
        if (course.Students.Count >= course.MaxSeats)
        {
            Console.WriteLine($"{course.Name} är full, {Name} kom inte med");
            return false;
        }
        Courses.Add(course);
        course.Students.Add(this);
        return true;
    }
    public void Leave(Course course)
    {
        if (Courses.Contains(course))
        {
            Courses.Remove(course);
        }
        if (course.Students.Contains(this))
        {
            course.Students.Remove(this);
        }
    }
    
    public void Schedule()
    {
        foreach (Course course in Courses)
        {
            Console.WriteLine(course.Name);
        }
    }

    public override string ToString()
    {
        return Name; 
    }
}