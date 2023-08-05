using System;
using System.Collections.Generic;
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

        public GuideSection(string name)
        {
            this.name = name;
            parentSection = null;
            subsections = new List<GuideSection>();
            info = ReadTextFile(name);
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

        private string ReadTextFile(string name)
        {
            string content;
            ResourceManager resourceManager = new ResourceManager(typeof(Resources));
            string resourceName = name.Replace(" ", "_");
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

    }
}
