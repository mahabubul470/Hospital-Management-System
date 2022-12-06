using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.Resources
{
    public partial class Patient : Component
    {
        public Patient()
        {
            InitializeComponent();
        }

        public Patient(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
