
namespace Task3
{
    class File
    {
        private string name;
        private string content;

        public File(string name)
        {
            this.name = name;
            this.content = "";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public void Append(string text)
        {
            content += text;
        }

        public void Delete()
        {
            content = "";
        }
    }
}
