﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum.Tests
{
    public class TestUtils
    {
        // This function will only retrieve the first instance of control found with the same name
        public static Control GetControlNamed(Control ParentControl, string name, bool searchAllChildren)
        {
            Control control = null;
            Control[] allControls = ParentControl.Controls.Find(name, searchAllChildren);

            if (allControls.Length > 0)
            {
                control = allControls[0];
            }

            return control;
        }

        // This function will retrieve all instances of control found with the same name
        public static Control[] GetAllControlNamed(Control ParentControl, string name, bool searchAllChildren)
        {
            Control[] control = ParentControl.Controls.Find(name, searchAllChildren);
            return control;
        }
    }
}