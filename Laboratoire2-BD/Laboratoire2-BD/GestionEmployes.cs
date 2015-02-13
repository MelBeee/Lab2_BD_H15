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
      // bool savoir si on est entrain de deplacer le form
      private bool _dragging = false;
      // emmagasine la position du curseur lors d'un deplacement de form
      private Point _start_point = new Point(0, 0);

//////////////////////////////////////////////////////////////////////////////
//    CONSTRUCTEUR ET LOAD
//////////////////////////////////////////////////////////////////////////////
      public GestionEmployes()
      {
         InitializeComponent();
      }
      private void Form1_Load(object sender, EventArgs e)
      {
         Connection();
         if(connection)
         {
            RemplirComboBoxCodeDep();
            AfficherNbreEmploye();
         }
         
         BTN_Ajouter.Enabled = false;
         BTN_Back.Enabled = false;
         BTN_Next.Enabled = false;
         BTN_MAJSalaire.Enabled = false;
         BTN_Supprimer.Enabled = false;
         BTN_Rechercher.Enabled = false; 
      }

//////////////////////////////////////////////////////////////////////////////
//    CONNEXION AU SERVEUR
//////////////////////////////////////////////////////////////////////////////
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
               SwitchException(ex);
            }
         }
      }

//////////////////////////////////////////////////////////////////////////////
//    VERIFICATION DES CARACTÈRES ENTRÉS
//////////////////////////////////////////////////////////////////////////////
      private void TB_NomAjout_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar != BACKSPACE)
            e.Handled = !EstAlpha(e.KeyChar);
      }
      private void TB_NumEmpAjout_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar != BACKSPACE)
            e.Handled = !EstChiffre(e.KeyChar);
      }
      bool EstChiffre(char c)
      {
         String chiffres = "0123456789";
         return (chiffres.IndexOf(c.ToString()) != -1);
      }
      bool EstAlpha(char c)
      {
         String alpha = "abcdefghijklmnopqrstuvwxzyzàâäéèêëìîïòôöùûüç -_";
         String car = c.ToString();
         car = car.ToLower();
         return (alpha.IndexOf(car) != -1);
      }

//////////////////////////////////////////////////////////////////////////////
//    SUPPRIMER UN EMPLOYÉ
//////////////////////////////////////////////////////////////////////////////
      private void BTN_Supprimer_Click(object sender, EventArgs e)
      {
         if (Supprimer())
         {
            MessageBox.Show("Suppression reussite");
            TB_NumEmpDelete.Text = "";
            AfficherNbreEmploye();
         }
         else
         {
            MessageBox.Show("Suppression non reussite");
         }
      }
      private bool Supprimer()
      {
         bool reussi = true;
         try
         {
            OracleCommand oraliste = new OracleCommand("GESTIONEMPLOYES", oraconnPrincipale);
            oraliste.CommandText = "GESTIONEMPLOYES.SUPPRIMER";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter orapamNum = new OracleParameter("Num", OracleDbType.Int32);
            orapamNum.Direction = ParameterDirection.Input;
            orapamNum.Value = TB_NumEmpDelete.Text;
            oraliste.Parameters.Add(orapamNum);

            oraliste.ExecuteNonQuery();
         }
         catch(OracleException ex)
         {
            reussi = false;
            SwitchException(ex);
         }
         return reussi; 
      }
      private void TB_NumEmpDelete_TextChanged(object sender, EventArgs e)
      {
         UpdateControlSupprimer();
      }
      private void UpdateControlSupprimer()
      {
         BTN_Supprimer.Enabled = (TB_NumEmpDelete.Text != "");
      }

//////////////////////////////////////////////////////////////////////////////
//    AJOUTER UN EMPLOYÉ
//////////////////////////////////////////////////////////////////////////////
      private void BTN_Ajouter_Click(object sender, EventArgs e)
      {
         if (Ajouter())
         {
            MessageBox.Show("Insertion reussite");
            TB_NomAjout.Text = "";
            TB_PrenomAjout.Text = "";
            TB_SalaireAjout.Text = "";
            TB_CodeDepAjout.Text = "";
            AfficherNbreEmploye();
         }
         else
         {
            MessageBox.Show("Insertion non reussite");
         }
      }
      private bool Ajouter()
      {
         bool reussi = true; 
         try
         {
            OracleCommand oraliste = new OracleCommand("GESTIONEMPLOYES", oraconnPrincipale);
            oraliste.CommandText = "GESTIONEMPLOYES.INSERTION";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter orapamNom = new OracleParameter("Nom", OracleDbType.Varchar2, 30);
            orapamNom.Direction = ParameterDirection.Input;
            orapamNom.Value = TB_NomAjout.Text;
            oraliste.Parameters.Add(orapamNom);

            OracleParameter orapamPrenom = new OracleParameter("Prenom", OracleDbType.Varchar2, 30);
            orapamPrenom.Direction = ParameterDirection.Input;
            orapamPrenom.Value = TB_PrenomAjout.Text;
            oraliste.Parameters.Add(orapamPrenom);

            OracleParameter orapamSalaire = new OracleParameter("Salaire", OracleDbType.Int32, 8);
            orapamSalaire.Direction = ParameterDirection.Input;
            orapamSalaire.Value = TB_SalaireAjout.Text;
            oraliste.Parameters.Add(orapamSalaire);

            OracleParameter orapamCodeDep = new OracleParameter("CodeDep", OracleDbType.Char, 3);
            orapamCodeDep.Direction = ParameterDirection.Input;
            orapamCodeDep.Value = TB_CodeDepAjout.Text;
            oraliste.Parameters.Add(orapamCodeDep);

            oraliste.ExecuteNonQuery();
         }
         catch(OracleException ex)
         {
            reussi = false; 
            SwitchException(ex);
         }

         return reussi; 
      }
      private void TB_NomAjout_TextChanged(object sender, EventArgs e)
      {
         UpdateControlAjouter();
      }
      private void TB_PrenomAjout_TextChanged(object sender, EventArgs e)
      {
         UpdateControlAjouter();
      }
      private void TB_SalaireAjout_TextChanged(object sender, EventArgs e)
      {
         UpdateControlAjouter();
      }
      private void TB_CodeDepAjout_TextChanged(object sender, EventArgs e)
      {
         UpdateControlAjouter();
      }
      private void UpdateControlAjouter()
      {
         BTN_Ajouter.Enabled = (TB_NomAjout.Text != "" && TB_PrenomAjout.Text != "" && TB_SalaireAjout.Text != "" && TB_CodeDepAjout.Text != "");
      }

//////////////////////////////////////////////////////////////////////////////
//    METTRE A JOUR LE SALAIRE
//////////////////////////////////////////////////////////////////////////////
      private void BTN_MAJSalaire_Click(object sender, EventArgs e)
      {
         if(MAJSalaire())
         {
            MessageBox.Show("Mise à jour reussite");
            TB_SalaireMAJ.Text = "";
            TB_NumEmpMAJ.Text = "";
         }
         else
         {
            MessageBox.Show("Mise à jour non reussite");
         }
      }
      private void UpdateControleMAJ()
      {
         BTN_MAJSalaire.Enabled = (TB_SalaireMAJ.Text != "" && TB_NumEmpMAJ.Text != "");
      }
      private void TB_NumEmpMAJ_TextChanged(object sender, EventArgs e)
      {
         UpdateControleMAJ();
      }
      private void TB_SalaireMAJ_TextChanged(object sender, EventArgs e)
      {
         UpdateControleMAJ();
      }
      private bool MAJSalaire()
      {
         bool reussi = true;
         try
         {
            OracleCommand oraliste = new OracleCommand("GESTIONEMPLOYES", oraconnPrincipale);
            oraliste.CommandText = "GESTIONEMPLOYES.MAJSALAIRE";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter orapamNom = new OracleParameter("Num", OracleDbType.Int32);
            orapamNom.Direction = ParameterDirection.Input;
            orapamNom.Value = TB_NumEmpMAJ.Text;
            oraliste.Parameters.Add(orapamNom);

            OracleParameter orapamSalaire = new OracleParameter("Salaire", OracleDbType.Int32, 6);
            orapamSalaire.Direction = ParameterDirection.Input;
            orapamSalaire.Value = TB_SalaireMAJ.Text;
            oraliste.Parameters.Add(orapamSalaire);

            oraliste.ExecuteNonQuery();
         }
         catch(OracleException ex)
         {
            SwitchException(ex);
            reussi = false; 
         }
         return reussi; 
      }
      
//////////////////////////////////////////////////////////////////////////////
//    LISTER LES EMPLOYÉS
//////////////////////////////////////////////////////////////////////////////
      private void RemplirComboBoxCodeDep()
      {
         CB_CodeDepLister.Items.Clear();

         string sqlremplir = "select codedep from employesclg group by codedep";

         try
         {
            OracleCommand orcd = new OracleCommand(sqlremplir, oraconnPrincipale);
            orcd.CommandType = CommandType.Text;
            OracleDataReader oraRead = orcd.ExecuteReader();

            while (oraRead.Read())
            {
               CB_CodeDepLister.Items.Add(oraRead.GetString(0));
            }

            oraRead.Close();
         }
         catch (OracleException ex)
         {
            SwitchException(ex);
         }
      }
      private void BTN_Next_Click(object sender, EventArgs e)
      {
         BTN_Back.Enabled = true;
         this.BindingContext[monDataSet, "Employés"].Position += 1;
         if (this.BindingContext[monDataSet, "Employés"].Position.ToString() == (this.BindingContext[monDataSet, "Employés"].Count - 1).ToString())
         {
            BTN_Next.Enabled = false;
         }
      }
      private void BTN_Back_Click(object sender, EventArgs e)
      {
         BTN_Next.Enabled = true;
         this.BindingContext[monDataSet, "Employés"].Position -= 1;
         if (this.BindingContext[monDataSet, "Employés"].Position.ToString() == "0")
         {
            BTN_Back.Enabled = false;
         }
      }
      private void CB_CodeDepLister_SelectedIndexChanged(object sender, EventArgs e)
      {

      }
      private void Lister()
      {
         OracleCommand oraliste = new OracleCommand("GESTIONEMPLOYES", oraconnPrincipale);
         oraliste.CommandText = "GESTIONEMPLOYES.LISTER";
         oraliste.CommandType = CommandType.StoredProcedure;
      }

//////////////////////////////////////////////////////////////////////////////
//    NOMBRE D'EMPLOYÉS
//////////////////////////////////////////////////////////////////////////////
      private void BTN_MAJNbre_Click(object sender, EventArgs e)
      {
         if (AfficherNbreEmploye())
         {
            MessageBox.Show("Actualisation reussite");
         }
         else
         {
            MessageBox.Show("Actualisation non reussite");
         }
      }
      private bool AfficherNbreEmploye()
      {
         bool reussi = true;
         try
         {
            OracleCommand oraliste = new OracleCommand("GESTIONEMPLOYES", oraconnPrincipale);
            oraliste.CommandText = "GESTIONEMPLOYES.NBREEMPLOYE";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter oraNombre = new OracleParameter("Nombre", OracleDbType.Int32);
            oraNombre.Direction = ParameterDirection.ReturnValue;
            oraliste.Parameters.Add(oraNombre);

            oraliste.ExecuteNonQuery();

            LB_NbreEmployé.Text = oraNombre.Value.ToString() + " employés "; 
         }
         catch(OracleException ex)
         {
            SwitchException(ex);
            reussi = false;
         }
         return reussi;
      }

//////////////////////////////////////////////////////////////////////////////
//    RECHERCHER DES EMPLOYÉS
//////////////////////////////////////////////////////////////////////////////
      private void BTN_Rechercher_Click(object sender, EventArgs e)
      {
         if(Rechercher())
         {
            MessageBox.Show("Recherche completé");
            TB_NomSearch.Text = "";
         }
         else
         {
            MessageBox.Show("Recherche non completé");
         }
      }
      private void UpdateSearch()
      {
         BTN_Rechercher.Enabled = TB_NomSearch.Text != "";
      }
      private void TB_NomSearch_TextChanged(object sender, EventArgs e)
      {
         UpdateSearch();
      }
      private bool Rechercher()
      {
         BTN_Back.Enabled = false; 
         bool reussi = true;
         try
         {
            OracleCommand oraliste = new OracleCommand("GESTIONEMPLOYES", oraconnPrincipale);
            oraliste.CommandText = "GESTIONEMPLOYES.RECHERCHER";
            oraliste.CommandType = CommandType.StoredProcedure;

            OracleParameter OrapameResultat = new OracleParameter("Resultat", OracleDbType.RefCursor);
            OrapameResultat.Direction = ParameterDirection.ReturnValue;
            oraliste.Parameters.Add(OrapameResultat);

            // déclaration du paramètre en IN
            OracleParameter OrapamNom = new  OracleParameter("Nom", OracleDbType.Varchar2, 30);
            OrapamNom.Value = TB_NomSearch.Text;
            OrapamNom.Direction = ParameterDirection.Input;
            oraliste.Parameters.Add(OrapamNom);

            OracleDataAdapter orAdater = new OracleDataAdapter(oraliste);
            if (monDataSet.Tables.Contains("Employés"))
            {
               monDataSet.Tables["Employés"].Clear();
            }
            orAdater.Fill(monDataSet, "Employés");
            oraliste.Dispose();
            
            if(this.BindingContext[monDataSet, "Employés"].Count > 0)
            {
               GB_Employés.Text = "Employé (" + this.BindingContext[monDataSet, "Employés"].Count.ToString() + " résultats";
               InitLabel();
            }
            else
            {
               MessageBox.Show("La table ne contient aucune valeur");
               ReinitialiseLabel();
            }
            if(this.BindingContext[monDataSet, "Employés"].Count > 1)
            {
               BTN_Next.Enabled = true; 
            }
         }
         catch(OracleException ex)
         {
            SwitchException(ex);
            reussi = false; 
         }
         return reussi;
      }
      private void InitLabel()
      {
         LB_NumList.DataBindings.Add("Text", monDataSet, "Employesclg.numemp");
         LB_NomList.DataBindings.Add("Text", monDataSet, "Employesclg.nom");
         LB_PrenomList.DataBindings.Add("Text", monDataSet, "Employesclg.Prenom");
         LB_SalaireList.DataBindings.Add("Text", monDataSet, "Employesclg.Salaire");
         LB_CodeDepList.DataBindings.Add("Text", monDataSet, "Employesclg.CodeDep");

         LB_SalaireList.Text += "$";
      }
      private void ReinitialiseLabel()
      {
         LB_NumList.DataBindings.Clear();
         LB_NomList.DataBindings.Clear();
         LB_PrenomList.DataBindings.Clear();
         LB_SalaireList.DataBindings.Clear();
         LB_CodeDepList.DataBindings.Clear();
      }

//////////////////////////////////////////////////////////////////////////////
//    DEPLACEMENT DE FORM ET BTN GENERAL
//////////////////////////////////////////////////////////////////////////////
      private void BTN_Quitter_Click(object sender, EventArgs e)
      {
         this.Close();
      }
      private void FormGestion_MouseDown(object sender, MouseEventArgs e)
      {
         _dragging = true;  // Enregistre que l'utilisateur a selectionner la form
         _start_point = new Point(e.X, e.Y); // Enregistre le point actuelle du form 
      }
      private void FormGestion_MouseMove(object sender, MouseEventArgs e)
      {
         if (_dragging) // si l'utilisateur a selectionner le form
         {
            Point p = PointToScreen(e.Location);
            Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
         }
      }
      private void FormGestion_MouseUp(object sender, MouseEventArgs e)
      {
         _dragging = false; // Enregistre que l'utilisateur a "lacher le form"
      }

//////////////////////////////////////////////////////////////////////////////
//    GESTION DES ERREURS
//////////////////////////////////////////////////////////////////////////////
      private void SwitchException(OracleException ex)
      {
         string DescriptionErreur;
         // Va chercher l'erreur lancé et set la description dans un string 
         switch (ex.Number)
         {
            case 00001:
               DescriptionErreur = "Erreur de valeur unique.";
               break;
            case 00904:
               DescriptionErreur = "Nom de colonne invalide ou manquante.";
               break;
            case 00933:
               DescriptionErreur = "Commande SQL invalide.";
               break;
            case 00936:
               DescriptionErreur = "La commande sql exécuté est incorrecte.";
               break;
            case 00947:
               DescriptionErreur = "Il manque des informations dans la commande sql exécuté.";
               break;
            case 01008:
               DescriptionErreur = "Une tentative de liaison de variable a échoué";
               break;
            case 01017:
               DescriptionErreur = "Mot de passe ou nom d'utilisateur invalide. \nConnection non établi.";
               break;
            case 01036:
               DescriptionErreur = "Nom de variable invalide ou manquante";
               break;
            case 01400:
               DescriptionErreur = "Vous ne pouvez pas ajouter une colonne avec une valeur null.";
               break;
            case 01407:
               DescriptionErreur = "Vous ne pouvez pas mettre a jour une colonne avec une valeur null.";
               break;
            case 01410:
               DescriptionErreur = "Vous ne pouvez pas mettre de valeur null.";
               break;
            case 01438:
               DescriptionErreur = "Valeur dépassant la précision maximale dans la BD";
               break;
            case 01747:
               DescriptionErreur = "Tentative d'utilisation d'un mot reservé dans Oracle";
               break;
            case 01830:
               DescriptionErreur = "Le format de date est invalide";
               break;
            case 01843:
               DescriptionErreur = "La date n'est pas valide";
               break;
            case 01861:
               DescriptionErreur = "Le format de date est invalide";
               break;
            case 02290:
               DescriptionErreur = "Tentative d'execution d'une commande qui viole une constrainte Check";
               break;
            case 02292:
               DescriptionErreur = "Tentative de suppression d'une clé lié à une clé étrangère.";
               break;
            case 03224:
               DescriptionErreur = "Pas de connection à Mercure";
               break;
            case 12170:
               DescriptionErreur = "La base de données est indisponible, réessayer plus tard.";
               break;
            case 12504:
               DescriptionErreur = "Connexion impossible. \nLe nom d'instance Oracle est invalide.";
               break;
            case 12533:
               DescriptionErreur = "Connexion impossible. \nLe parametre de connexion d'adresse est invalide.";
               break;
            case 12541:
               DescriptionErreur = "Connexion impossible. \nLa destination est invalide ou pas rejoignable.";
               break;
            case 12543:
               DescriptionErreur = "Connexion impossible. \nVérifiez votre connection internet.";
               break;
            default:
               DescriptionErreur = ex.Message;
               break;
         }

         MessageBox.Show(DescriptionErreur, "Erreur #" + ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }


 
   }
}
