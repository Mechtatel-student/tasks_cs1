using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP
{
    class Presenter
    {
        CalculatorView view;
        Model model = new Model();

        public void Begin()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorView());
        }

        public void ViewToPresenter()
        {
        }
    }
}
