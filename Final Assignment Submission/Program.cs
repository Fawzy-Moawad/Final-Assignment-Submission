using System;
using System.Data.Entity;

namespace StudentDatabase
{
    // Step 2: Define the Student entity class
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // Step 3: Set up the context class
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 4: Create and add a student to the database
            using (var context = new StudentDbContext())
            {
                // Create a new Student object
                var student = new Student
                {
                    Name = "John Doe",
                    Age = 20
                };

                // Add the student to the DbSet<Student>
                context.Students.Add(student);

                // Save the changes to the database
                context.SaveChanges();
            }

            Console.WriteLine("Student added successfully!");
        }
    }
}
