using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void ReadTextFile()
        {
            ResourceManager resourceManager = new ResourceManager(typeof(Resources));
            string resourceName = name.Replace(" ", "_"); // Τα ονόματα των resources στο αρχείο resx περιέχουν underscore αντί για κενό
            content = resourceManager.GetString(resourceName);
            if (content == null)
            {
                content = "";
            }
        }

        private void ReadImageFiles()
        {
            string resourceName = name.Replace(" ", "_"); // Τα ονόματα των resources στο αρχείο resx περιέχουν underscore αντί για κενό
            pictures[0] = (Image)Resources.ResourceManager.GetObject(resourceName + "1");
            pictures[1] = (Image)Resources.ResourceManager.GetObject(resourceName + "2");
        }

    }
}
