using System.Collections.Generic;

namespace Task3
{
    class Directory
    {
        private string name;
        private List<File> files;

        public Directory(string name)
        {
            this.name = name;
            this.files = new List<File>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AddFile(File file)
        {
            files.Add(file);
        }

        public void RemoveFile(File file)
        {
            files.Remove(file);
        }

        public List<File> Files
        {
            get { return files; }
        }

        public File FindFile(string name)
        {
            foreach (File file in files)
            {
                if (file.Name == name)
                {
                    return file;
                }
            }
            return null;
        }
    }
}
