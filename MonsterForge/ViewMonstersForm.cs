using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterForge
{
    public partial class ViewMonstersForm : Form
    {
        private JSONHandler jsonHandler = new JSONHandler();

        public ViewMonstersForm()
        {
            
            InitializeComponent();
            monsterListView.View = View.Details;

            
        }
    }
}
