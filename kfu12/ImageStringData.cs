using System;
using System.Drawing;
using System.IO;


namespace kfu12
{
    class ImageStringData
    {
        public string path;
        public string name;
        public string title;

        public ImageStringData(string fileString)
        {
            if (fileString.Contains(";") && fileString.Contains("\\")) 
            {
                string[] data = fileString.Split(';');
                path = data[0];
                string[] pathParts = data[0].Split('\\');
                name = pathParts[pathParts.Length - 1];
                title = data[1];
            }
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                path = null;
            }
            try
            {
                using (Image img = Image.FromFile(path))
                {
                    if (img.Width <= 0 || img.Height <= 0)
                    {
                        path = null;
                    }
                }
            }
            catch
            {
                path = null;
            }
        }

        public override string ToString()
        {
            return name;
        }
        public string ToSave()
        {
            return $"{path};{title}\n";
        }
    }
}
