
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory directory = new Directory("MyDirectory");
            TextFile textFile = new TextFile(directory, "MyTextFile.txt");
            textFile.Append("Hello, world!");
            textFile.DisplayContent(); // output: "Hello, world!"
            textFile.Rename("NewTextFile.txt");
            textFile.Delete();
        }
    }
}
