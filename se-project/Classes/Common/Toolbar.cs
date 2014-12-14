using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using se_project.Interfaces.Common;

namespace se_project.Classes.Common
{
    public class Toolbar : IToolbar
    {
       bool IToolbar.ExecuteButtonAction(int buttonId)
        {
            switch (buttonId)
            {
                case 1:
                    executeFunction1();
                    return true;
                case 2:
                    executeFunction2();
                    return true;
                default:
                    badButton();
                    return false;
            }
        }

        private void executeFunction1() {
            Console.WriteLine("Case 1");    
        }

        private void executeFunction2()
        {
            Console.WriteLine("Case 2");
        }

        private void badButton()
        {
            Console.WriteLine("Wrong buttonId !");
        }
    }
}
