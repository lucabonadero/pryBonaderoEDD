using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBonaderoED
{
    public partial class frmSQLPORTEXTO : Form
    {
        public frmSQLPORTEXTO()
        {
            InitializeComponent();
        }
        string varSQL = "";
        clsBaseDatos clsBaseDatos = new clsBaseDatos();

        private void frmSQLPORTEXTO_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            varSQL = txtSQL.Text;
            clsBaseDatos.Listar(dgvSQL, varSQL);
        }
    }
}
