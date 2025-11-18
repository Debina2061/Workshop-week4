using Task1;

Student s1 = new Student();
s1.name = "Debina";
s1.age = 20;
s1.course = "BIT";

Student s2 = new Student();
s2.name = "David";
s2.age = 21;
s2.course = "Networking";

Console.WriteLine("Student 1: " + s1.name + ", " + s1.age + ", " + s1.course);
Console.WriteLine("Student 2: " + s2.name + ", " + s2.age + ", " + s2.course);

Console.WriteLine("College: " + Student.collegeName);
