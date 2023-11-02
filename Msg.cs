using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public class Msg
    {
        private string appName;

        public Msg(Form1 form)
        {
            appName = form.getAppName();
        }

        public void Error(string message)
        {
            MessageBox.Show(message, appName + " - Erreur");
        }

        public void Success(string message)
        {
            MessageBox.Show(message, appName + " - Succès");
        }

        public void Info(string message)
        {
            MessageBox.Show(message, appName + " - A propos");
        }

        public void Historique(string message)
        {
            MessageBox.Show(message, appName + " - Historique");
        }

        public void Default(string message)
        {
            MessageBox.Show(message, appName);
        }

        public DialogResult YesNo(string message, string type)
        {
            DialogResult msgResult = MessageBox.Show(message, $"{appName} - {type}", MessageBoxButtons.YesNo);
            return msgResult;
        }

        public DialogResult YesNoCancel(string message, string type)
        {
            DialogResult msgResult = MessageBox.Show(message, $"{appName} - {type}", MessageBoxButtons.YesNoCancel);
            return msgResult;
        }
    }
}
