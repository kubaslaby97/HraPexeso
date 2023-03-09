using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HraPexeso
{
    public partial class frmHlavni : Form
    {
        PexesoGUI pexeso;
        bool zmenaVelikosti;
        public frmHlavni()
        {
            InitializeComponent();
        }

        private void btnSpustit_Click(object sender, EventArgs e)
        {
            if (rbPevna.Checked == true)
                zmenaVelikosti = false;
            else if (rbPohybliva.Checked == true)
                zmenaVelikosti = true;

            pexeso = new PexesoGUI((int)numRadky.Value, (int)numSloupce.Value, (int)numCasZakryti.Value);
            pexeso.ZahajitHru(this.Icon, txtTitulek.Text, zmenaVelikosti, chkMinimalizace.Checked, chkMaximalizace.Checked, (int)numVelikostKarty.Value);
        }
    }
}
