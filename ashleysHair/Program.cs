List<string> students = new List<string>() {
    "Sara",
    "Isaiah",
    "Zaccheaus"
};

students.Add("Cole"); // <3
students.Add("Ashley");

string statement = String.Join("','", students);
Console.WriteLine("List of W people:");
Console.WriteLine($"['{statement}']");