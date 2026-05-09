using System;
using System.Windows.Forms;

namespace nituz_project_23
{
    public class MyAppManager : ApplicationContext
    {
        public MyAppManager()
        {
            // פותחים את הלוגין
            LoginScreen login = new LoginScreen();
            login.Show();
        }

    }
}