using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Laboratoire2_BD
{
   public partial class GestionEmployes : Form
   {
      // variable utilisé pour la verification dans les textboxs
      const char BACKSPACE = '\b';
      // boolean pour stocker si le form est connecté ou non
      public bool connection = false;
      // variable contenant la connection a la bd 
      OracleConnection oraconnPrincipale = new OracleConnection();
      // Data set
      bool DataSetRempli = false;
      private DataSet monDataSet = new DataSet();
      public GestionEmployes()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         Connection();
      }

      bool EstChiffre(char c)
      {
         String chiffres = "0123456789";
         return (chiffres.IndexOf(c.ToString()) != -1);
      }

      private void Connection()
      {
         if (!connection)
         {
            string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                              "(HOST=205.237.244.251)(PORT=1521)))" +
                              "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
            string user = "boucherm";
            string passwd = "ORACLE1";
            string chaineconnection = "Data Source = " + Dsource + ";User Id =" + user + "; Password =" + passwd;

            try
            {
               oraconnPrincipale.ConnectionString = chaineconnection;
               oraconnPrincipale.Open();
               connection = true;
            }
            catch (OracleException ex)
            {
               //Erreur(ex);
               MessageBox.Show(ex.ToString());
            }
         }
      }

      private void TB_NumEmpAjout_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar != BACKSPACE)
            e.Handled = !EstChiffre(e.KeyChar);
      }

   
   }
}
