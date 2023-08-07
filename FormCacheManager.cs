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
            // Αρχικοποίηση όλων των forms εδώ
            formCache.Add(typeof(AboutForm), new AboutForm());
            formCache.Add(typeof(GuideForm), new GuideForm());
            formCache.Add(typeof(UniversitySectionForm), new UniversitySectionForm());
            formCache.Add(typeof(ServicesSectionForm), new ServicesSectionForm());
            formCache.Add(typeof(SchoolsSectionForm), new SchoolsSectionForm());
            formCache.Add(typeof(ReviewsForm), new ReviewsForm());
            formCache.Add(typeof(ReviewSubmitForm), new ReviewSubmitForm());
            formCache.Add(typeof(SlideshowForm), new SlideshowForm());
        }

        public void NavigateToForm<T>(BaseForm currentForm) where T : BaseForm
        {
            T nextForm = (T)formCache[typeof(T)];
            // Όταν μεταβαίνουμε από το Login στην αρχική σελίδα του οδηγού, δεν θέλουμε να κρατήσουμε την Login στην στοίβα ιστορικού
            if (!(currentForm.GetType() == typeof(LoginForm) && nextForm.GetType() == typeof(GuideForm)))
            {
                formHistory.Push(currentForm);
            }
            // Ενημέρωση του back button text
            if (formHistory.Count == 0)
            {
                nextForm.DisableBackButton();
            }
            if (formHistory.Count > 0)
            {
                nextForm.EnableBackButton(currentForm);
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
