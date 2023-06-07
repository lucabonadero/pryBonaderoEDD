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
    public partial class frmSQL : Form
    {
        public frmSQL()
        {
            InitializeComponent();
        }
        string vSQL = "";
        clsBaseDatos clsBaseDatos = new clsBaseDatos();
        private void btnPrSimple_Click(object sender, EventArgs e)
        {
                vSQL = 
                "SELECT TITULO " +
                "FROM LIBRO " +
                "ORDER BY 1 DESC";
            clsBaseDatos.Listar(dgvSQL, vSQL);
        }

        private void btnPrMult_Click(object sender, EventArgs e)
        {
                vSQL = 
                "SELECT TITULO, AÑO " +
                "FROM LIBRO " +
                "ORDER BY TITULO ASC";
            clsBaseDatos.Listar(dgvSQL, vSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
                vSQL =
                "SELECT * " +
                "FROM LIBRO INNER JOIN AUTOR " +
                "ON LIBRO.IDAUTOR = AUTOR.IDAUTOR ";
            clsBaseDatos.Listar(dgvSQL, vSQL);

        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
                vSQL =
                "SELECT TITULO, IDAUTOR " +
                "FROM LIBRO " +
                "WHERE IDAUTOR <> 5 "+
                "ORDER BY TITULO DESC";
            clsBaseDatos.Listar(dgvSQL, vSQL);
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
                vSQL =
                "SELECT TITULO, IDAUTOR AS AUTOR, IDIDIOMA AS IDIOMA " +
                "FROM LIBRO " +
                "WHERE IDAUTOR <> 5 AND IDIDIOMA =1 " +
                "ORDER BY TITULO ASC";
            clsBaseDatos.Listar(dgvSQL, vSQL);
        }

        private void btnSeleccConvolucion_Click(object sender, EventArgs e)
        {

                vSQL = 
                "SELECT * " +
                "FROM (SELECT * FROM LIBRO WHERE IDAUTOR = 4) AS X " +
                "WHERE IDIDIOMA = 1 " +
                "ORDER BY TITULO";
            clsBaseDatos.Listar(dgvSQL, vSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
                vSQL =
                "SELECT * FROM LIBRO WHERE IDIDIOMA = 1 " +
                "UNION " +
                "SELECT * FROM LIBRO WHERE IDIDIOMA = 2";
            clsBaseDatos.Listar(dgvSQL, vSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
                vSQL =
                "SELECT * FROM LIBRO " +
                "WHERE IDIDIOMA = 2 AND " +
                "IDLIBRO IN " +
                " (SELECT IDLIBRO FROM LIBRO WHERE IDPAIS = 3 )" +
                "ORDER BY 1 ASC";
            clsBaseDatos.Listar(dgvSQL, vSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            vSQL = 
                "SELECT * FROM LIBRO " +
                "WHERE IDIDIOMA = 2 AND " +
                "IDLIBRO NOT IN " +
                " (SELECT IDLIBRO FROM LIBRO WHERE IDPAIS = 3 )" +
                "ORDER BY 1 ASC";
            clsBaseDatos.Listar(dgvSQL, vSQL);
        }

        private void frmSQL_Load(object sender, EventArgs e)
        {

        }
    }
}
