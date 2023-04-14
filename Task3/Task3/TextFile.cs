using System;

namespace Task3
{
    class TextFile
    {
        private Directory directory;
        private File file;

        public TextFile(Directory directory, string name)
        {
            this.directory = directory;
            this.file = new File(name);
            directory.AddFile(file);
        }

        public void Rename(string name)
        {
            file.Name = name;
        }

        public void DisplayContent()
        {
            Console.WriteLine(file.Content);
        }

        public void Append(string text)
        {
            file.Append(text);
        }

        public void Delete()
        {
            directory.RemoveFile(file);
            file.Delete();
        }
    }
}
