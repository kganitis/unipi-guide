using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2023_Final
{
    public class FormCacheManager
    {
        private static readonly FormCacheManager instance = new FormCacheManager();

        private Stack<Form> formHistory = new Stack<Form>();
        private Dictionary<Type, Form> formCache = new Dictionary<Type, Form>();

        public static FormCacheManager Instance { get { return instance; } }

        private FormCacheManager()
        {
            PreloadForms();
        }

        public void PreloadForms()
        {
            // Create instances of all the forms and add them to the cache
            
            formCache.Add(typeof(AboutForm), new AboutForm());
            formCache.Add(typeof(GuideForm), new GuideForm());
            formCache.Add(typeof(UniversitySectionForm), new UniversitySectionForm());
            formCache.Add(typeof(ServicesSectionForm), new ServicesSectionForm());
            formCache.Add(typeof(SchoolsSectionForm), new SchoolsSectionForm());
            formCache.Add(typeof(ReviewsForm), new ReviewsForm());
            formCache.Add(typeof(ReviewSubmitForm), new ReviewSubmitForm());
            formCache.Add(typeof(SlideshowForm), new SlideshowForm());
            formCache.Add(typeof(ViewEventsForm), new ViewEventsForm());

        }

        public void NavigateToForm<T>(Form currentForm) where T : Form
        {
            T nextForm = (T)formCache[typeof(T)];
            // Don't keep LoginForm in history after entering the guide
            if (!(currentForm.GetType() == typeof(LoginForm) && nextForm.GetType() == typeof(GuideForm)))
            {
                formHistory.Push(currentForm);
            }
            currentForm.Hide();
            nextForm.Show();
        }

        public void NavigateBack(Form currentForm)
        {
            if (formHistory.Count > 0)
            {
                Form previousForm = formHistory.Pop();
                currentForm.Hide();
                previousForm.Show();
            }
        }
    }
}
