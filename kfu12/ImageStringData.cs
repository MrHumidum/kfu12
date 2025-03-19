using System;


namespace kfu12
{
    class ImageStringData
    {
        public string path;
        public string name;
        public string title;

        public ImageStringData(string fileString)
        {
            if (fileString.Contains(";") || fileString.Contains("\\")) 
            {
                string[] data = fileString.Split(';');
                this.path = data[0];
                string[] pathParts = data[0].Split('\\');
                this.name = pathParts[pathParts.Length - 1];
                this.title = data[1];
            }
            
        }

        public override string ToString()
        {
            return name;
        }
        public string ToSave()
        {
            return path + ";" + title + "\n";
        }
    }
}
