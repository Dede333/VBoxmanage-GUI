using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBoxManage_Gui
{
    public partial class FormProgress : Form
    {
        public FormProgress()
        {
            InitializeComponent();
        }

        // Active la barre de progression au chargement de la forme
        // Propriété Style à la valeur marquée
        // Révision: 05042020
        //
        private void FormProgress_Load(object sender, EventArgs e)
        {
            timer1.Enabled=true;
        }
    }
}
