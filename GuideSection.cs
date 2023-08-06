using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2023_Final.Properties;

namespace WindowsFormsApp2023_Final
{
    public class GuideSection
    {
        private string name;
        private GuideSection parentSection;
        private List<GuideSection> subsections;
        private string info;
        private Image[] pictures;

        public GuideSection(string name)
        {
            this.name = name;
            parentSection = null;
            subsections = new List<GuideSection>();
            info = ReadTextFile(name);
            if (info == "File not found.")
            {
                info = "";
            }
            pictures = new Image[2];
            ReadImageFiles(name);
        }

        public string Name
        {
            get { return name; }
        }

        public GuideSection ParentSection
        {
            get { return parentSection; }
            set { parentSection = value; }
        }

        public List<GuideSection> Subsections
        {
            get { return subsections; }
            set { subsections = value; }
        }

        public void AddSubsection(GuideSection subsection)
        {
            subsections.Add(subsection);
            subsection.ParentSection = this;
        }

        public bool ContainsSubsections()
        {
            return subsections.Count > 0;
        }

        public string Info
        { 
            get { return info; } 
        }

        public Image[] Pictures
        {
            get { return pictures; }
        }

        private string ReadTextFile(string name)
        {
            string content;
            ResourceManager resourceManager = new ResourceManager(typeof(Resources));
            string resourceName = name.Replace(" ", "_"); // Τα ονόματα των resources στο αρχείο resx περιέχουν underscore αντί για κενό
            try
            {
                content = resourceManager.GetString(resourceName);
            }
            catch
            {
                content = "File not found.";
            }
            return content;
        }

        private void ReadImageFiles(string name)
        {
            string resourceName = name.Replace(" ", "_"); // Τα ονόματα των resources στο αρχείο resx περιέχουν underscore αντί για κενό

            pictures[0] = (Image)Resources.ResourceManager.GetObject(resourceName + "1");
            pictures[1] = (Image)Resources.ResourceManager.GetObject(resourceName + "2");
        }

    }
}
