using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using WindowsFormsApp2023_Final.Properties;

namespace WindowsFormsApp2023_Final
{
    public class GuideSection
    {
        private string name;
        private GuideSection parentSection;
        private List<GuideSection> subsections;
        private string content;
        private Image[] pictures;

        public GuideSection(string name)
        {
            this.name = name;
            parentSection = null;
            subsections = new List<GuideSection>();
            ReadTextFile();
            pictures = new Image[2];
            ReadImageFiles();
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

        public string Content
        { 
            get { return content; } 
        }

        public Image[] Pictures
        {
            get { return pictures; }
        }

        private string GetResourceName()
        {
            return name.Replace(" ", "_"); // Τα ονόματα των resources στο αρχείο resx περιέχουν underscore αντί για κενό
        }

        private void ReadTextFile()
        {
            ResourceManager resourceManager = new ResourceManager(typeof(Resources));
            content = resourceManager.GetString(GetResourceName());
            if (content == null)
            {
                content = "";
            }
        }

        private void ReadImageFiles()
        {
            pictures[0] = (Image)Resources.ResourceManager.GetObject(GetResourceName() + "1");
            pictures[1] = (Image)Resources.ResourceManager.GetObject(GetResourceName() + "2");
        }

    }
}
