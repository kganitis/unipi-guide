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

        public static FormCacheManager Instance { get { return instance; } }

        private Dictionary<Type, Form> formCache = new Dictionary<Type, Form>();

        public T GetForm<T>() where T : Form, new()
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

        public void NavigateToForm<T>() where T : Form, new()
        {
            T form = GetForm<T>();
            form.Show();
        }
    }

}
