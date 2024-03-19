using  BuilderPattern;

List<Student> students = new()
{
    new Student { Name = "Ivan",      Surname = "A.", Topic = "Game", Mark = 5 },
    new Student { Name = "Ekaterina", Surname = "H.", Topic = "Site", Mark = 2 },
    new Student { Name = "Sofia",     Surname = "L.", Topic = "App", Mark = 4 },
    new Student { Name = "Anastasia", Surname = "M.", Topic = "Shop", Mark = 5},
    new Student { Name = "Ruslan",    Surname = "I.", Topic = "Cafe", Mark = 5 },
    new Student { Name = "Maksim",    Surname = "V.", Topic = "Kotik", Mark = 3 }
};

var builder = new StudentCourseworkBuilder(students);

var director = new StudentCourseworkDirector(builder);

director.Build();

var document = builder.GetStudentCoursework();

Console.WriteLine(document);

Console.ReadKey();

