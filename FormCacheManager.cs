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

        public static FormCacheManager Instance { get { return instance; } }

        private Dictionary<Type, Form> formCache = new Dictionary<Type, Form>();

        private T GetForm<T>() where T : Form, new()
        {
            Type formType = typeof(T);

            if (formCache.ContainsKey(formType))
            {
                return (T)formCache[formType];
            }
            else
            {
                T form = new T();
                formCache.Add(formType, form);
                return form;
            }
        }

        public void NavigateToForm<T>(Form currentForm) where T : Form, new()
        {
            T nextForm = GetForm<T>();
            if (!(currentForm.GetType() == typeof(LoginForm) && nextForm.GetType() == typeof(GuideForm))) {
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
