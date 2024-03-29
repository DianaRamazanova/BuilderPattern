﻿using  BuilderPattern;

List<Student> students = new()
{
    new Student { Name = "Ivan",   Surname = "A.", Topic = "Game", Mark = 5 },
    new Student { Name = "Katya",  Surname = "H.", Topic = "Site", Mark = 2 },
    new Student { Name = "Sofia",  Surname = "L.", Topic = "App", Mark = 4 },
    new Student { Name = "Nastya", Surname = "M.", Topic = "Shop", Mark = 5},
    new Student { Name = "Ruslan", Surname = "I.", Topic = "Cafe", Mark = 5 },
    new Student { Name = "Maksim", Surname = "V.", Topic = "Kotik", Mark = 3 }
};

var builder = new ReportOfStudentCourseworkBuilder(students);

var director = new ReportOfStudentCourseworkDirector(builder);

director.Build();

var document = builder.GetReportOfStudentCoursework();

Console.WriteLine(document);

Console.ReadKey();

