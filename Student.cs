class Student
{
    public string Name;
    public List<Course> Courses;
    public Student(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }
    public void Join(Course course)
    {
        if (!Courses.Contains(course))
        {
            Courses.Add(course);
        }
        if (!course.Students.Contains(this))
        {
            course.Students.Add(this);
        }
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
    
}