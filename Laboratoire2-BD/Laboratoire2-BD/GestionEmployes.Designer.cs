﻿namespace Laboratoire2_BD
{
   partial class GestionEmployes
   {
      /// <summary>
      /// Variable nécessaire au concepteur.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Nettoyage des ressources utilisées.
      /// </summary>
      /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Code généré par le Concepteur Windows Form

      /// <summary>
      /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
      /// le contenu de cette méthode avec l'éditeur de code.
      /// </summary>
      private void InitializeComponent()
      {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_CodeDepAjout = new System.Windows.Forms.TextBox();
            this.TB_SalaireAjout = new System.Windows.Forms.TextBox();
            this.TB_PrenomAjout = new System.Windows.Forms.TextBox();
            this.TB_NomAjout = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_NumEmpDelete = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_MAJSalaire = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_NumEmpMAJ = new System.Windows.Forms.TextBox();
            this.TB_SalaireMAJ = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LB_NbreEmployé = new System.Windows.Forms.Label();
            this.BTN_MAJNbre = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BTN_Rechercher = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_NomSearch = new System.Windows.Forms.TextBox();
            this.BTN_Back = new System.Windows.Forms.Button();
            this.BTN_Next = new System.Windows.Forms.Button();
            this.GB_Employés = new System.Windows.Forms.GroupBox();
            this.LB_CodeDepList = new System.Windows.Forms.Label();
            this.LB_SalaireList = new System.Windows.Forms.Label();
            this.LB_PrenomList = new System.Windows.Forms.Label();
            this.LB_NomList = new System.Windows.Forms.Label();
            this.LB_NumList = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.CB_CodeDepLister = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.GB_Employés.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Ajouter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_CodeDepAjout);
            this.groupBox1.Controls.Add(this.TB_SalaireAjout);
            this.groupBox1.Controls.Add(this.TB_PrenomAjout);
            this.groupBox1.Controls.Add(this.TB_NomAjout);
            this.groupBox1.Location = new System.Drawing.Point(15, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(253, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un employé";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(77, 162);
            this.BTN_Ajouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(100, 28);
            this.BTN_Ajouter.TabIndex = 5;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Code Dep :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salaire :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prenom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom :";
            // 
            // TB_CodeDepAjout
            // 
            this.TB_CodeDepAjout.Location = new System.Drawing.Point(93, 123);
            this.TB_CodeDepAjout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_CodeDepAjout.MaxLength = 3;
            this.TB_CodeDepAjout.Name = "TB_CodeDepAjout";
            this.TB_CodeDepAjout.Size = new System.Drawing.Size(132, 22);
            this.TB_CodeDepAjout.TabIndex = 4;
            this.TB_CodeDepAjout.TextChanged += new System.EventHandler(this.TB_CodeDepAjout_TextChanged);
            this.TB_CodeDepAjout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NomAjout_KeyPress);
            // 
            // TB_SalaireAjout
            // 
            this.TB_SalaireAjout.Location = new System.Drawing.Point(93, 91);
            this.TB_SalaireAjout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_SalaireAjout.MaxLength = 6;
            this.TB_SalaireAjout.Name = "TB_SalaireAjout";
            this.TB_SalaireAjout.Size = new System.Drawing.Size(132, 22);
            this.TB_SalaireAjout.TabIndex = 3;
            this.TB_SalaireAjout.TextChanged += new System.EventHandler(this.TB_SalaireAjout_TextChanged);
            this.TB_SalaireAjout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NumEmpAjout_KeyPress);
            // 
            // TB_PrenomAjout
            // 
            this.TB_PrenomAjout.Location = new System.Drawing.Point(93, 59);
            this.TB_PrenomAjout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_PrenomAjout.MaxLength = 30;
            this.TB_PrenomAjout.Name = "TB_PrenomAjout";
            this.TB_PrenomAjout.Size = new System.Drawing.Size(132, 22);
            this.TB_PrenomAjout.TabIndex = 2;
            this.TB_PrenomAjout.TextChanged += new System.EventHandler(this.TB_PrenomAjout_TextChanged);
            this.TB_PrenomAjout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NomAjout_KeyPress);
            // 
            // TB_NomAjout
            // 
            this.TB_NomAjout.Location = new System.Drawing.Point(93, 27);
            this.TB_NomAjout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_NomAjout.MaxLength = 30;
            this.TB_NomAjout.Name = "TB_NomAjout";
            this.TB_NomAjout.Size = new System.Drawing.Size(132, 22);
            this.TB_NomAjout.TabIndex = 1;
            this.TB_NomAjout.TextChanged += new System.EventHandler(this.TB_NomAjout_TextChanged);
            this.TB_NomAjout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NomAjout_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_Supprimer);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TB_NumEmpDelete);
            this.groupBox2.Location = new System.Drawing.Point(284, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(253, 93);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supprimer un employé";
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(76, 58);
            this.BTN_Supprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(100, 28);
            this.BTN_Supprimer.TabIndex = 9;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Numero :";
            // 
            // TB_NumEmpDelete
            // 
            this.TB_NumEmpDelete.Location = new System.Drawing.Point(93, 26);
            this.TB_NumEmpDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_NumEmpDelete.Name = "TB_NumEmpDelete";
            this.TB_NumEmpDelete.Size = new System.Drawing.Size(132, 22);
            this.TB_NumEmpDelete.TabIndex = 8;
            this.TB_NumEmpDelete.TextChanged += new System.EventHandler(this.TB_NumEmpDelete_TextChanged);
            this.TB_NumEmpDelete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NumEmpAjout_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.BTN_MAJSalaire);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TB_NumEmpMAJ);
            this.groupBox3.Controls.Add(this.TB_SalaireMAJ);
            this.groupBox3.Location = new System.Drawing.Point(284, 108);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(253, 130);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mise à jour du salaire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Salaire :";
            // 
            // BTN_MAJSalaire
            // 
            this.BTN_MAJSalaire.Location = new System.Drawing.Point(76, 87);
            this.BTN_MAJSalaire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_MAJSalaire.Name = "BTN_MAJSalaire";
            this.BTN_MAJSalaire.Size = new System.Drawing.Size(100, 28);
            this.BTN_MAJSalaire.TabIndex = 12;
            this.BTN_MAJSalaire.Text = "Mettre à jour";
            this.BTN_MAJSalaire.UseVisualStyleBackColor = true;
            this.BTN_MAJSalaire.Click += new System.EventHandler(this.BTN_MAJSalaire_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Numero :";
            // 
            // TB_NumEmpMAJ
            // 
            this.TB_NumEmpMAJ.Location = new System.Drawing.Point(93, 23);
            this.TB_NumEmpMAJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_NumEmpMAJ.Name = "TB_NumEmpMAJ";
            this.TB_NumEmpMAJ.Size = new System.Drawing.Size(132, 22);
            this.TB_NumEmpMAJ.TabIndex = 10;
            this.TB_NumEmpMAJ.TextChanged += new System.EventHandler(this.TB_NumEmpMAJ_TextChanged);
            this.TB_NumEmpMAJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NumEmpAjout_KeyPress);
            // 
            // TB_SalaireMAJ
            // 
            this.TB_SalaireMAJ.Location = new System.Drawing.Point(93, 55);
            this.TB_SalaireMAJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_SalaireMAJ.MaxLength = 6;
            this.TB_SalaireMAJ.Name = "TB_SalaireMAJ";
            this.TB_SalaireMAJ.Size = new System.Drawing.Size(132, 22);
            this.TB_SalaireMAJ.TabIndex = 11;
            this.TB_SalaireMAJ.TextChanged += new System.EventHandler(this.TB_SalaireMAJ_TextChanged);
            this.TB_SalaireMAJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NumEmpAjout_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LB_NbreEmployé);
            this.groupBox4.Controls.Add(this.BTN_MAJNbre);
            this.groupBox4.Location = new System.Drawing.Point(15, 218);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(253, 76);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nombre d\'employés";
            // 
            // LB_NbreEmployé
            // 
            this.LB_NbreEmployé.AutoSize = true;
            this.LB_NbreEmployé.Location = new System.Drawing.Point(27, 34);
            this.LB_NbreEmployé.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NbreEmployé.Name = "LB_NbreEmployé";
            this.LB_NbreEmployé.Size = new System.Drawing.Size(81, 17);
            this.LB_NbreEmployé.TabIndex = 2;
            this.LB_NbreEmployé.Text = "X employés";
            // 
            // BTN_MAJNbre
            // 
            this.BTN_MAJNbre.Location = new System.Drawing.Point(139, 28);
            this.BTN_MAJNbre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_MAJNbre.Name = "BTN_MAJNbre";
            this.BTN_MAJNbre.Size = new System.Drawing.Size(100, 28);
            this.BTN_MAJNbre.TabIndex = 6;
            this.BTN_MAJNbre.Text = "Mettre à jour";
            this.BTN_MAJNbre.UseVisualStyleBackColor = true;
            this.BTN_MAJNbre.Click += new System.EventHandler(this.BTN_MAJNbre_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BTN_Rechercher);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.TB_NomSearch);
            this.groupBox5.Location = new System.Drawing.Point(284, 246);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(253, 105);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rechercher";
            // 
            // BTN_Rechercher
            // 
            this.BTN_Rechercher.Location = new System.Drawing.Point(76, 63);
            this.BTN_Rechercher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Rechercher.Name = "BTN_Rechercher";
            this.BTN_Rechercher.Size = new System.Drawing.Size(100, 28);
            this.BTN_Rechercher.TabIndex = 14;
            this.BTN_Rechercher.Text = "Rechercher";
            this.BTN_Rechercher.UseVisualStyleBackColor = true;
            this.BTN_Rechercher.Click += new System.EventHandler(this.BTN_Rechercher_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Nom :";
            // 
            // TB_NomSearch
            // 
            this.TB_NomSearch.Location = new System.Drawing.Point(93, 26);
            this.TB_NomSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_NomSearch.MaxLength = 30;
            this.TB_NomSearch.Name = "TB_NomSearch";
            this.TB_NomSearch.Size = new System.Drawing.Size(132, 22);
            this.TB_NomSearch.TabIndex = 13;
            this.TB_NomSearch.TextChanged += new System.EventHandler(this.TB_NomSearch_TextChanged);
            this.TB_NomSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NomAjout_KeyPress);
            // 
            // BTN_Back
            // 
            this.BTN_Back.Location = new System.Drawing.Point(85, 151);
            this.BTN_Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Back.Name = "BTN_Back";
            this.BTN_Back.Size = new System.Drawing.Size(37, 28);
            this.BTN_Back.TabIndex = 15;
            this.BTN_Back.Text = "<<";
            this.BTN_Back.UseVisualStyleBackColor = true;
            this.BTN_Back.Click += new System.EventHandler(this.BTN_Back_Click);
            // 
            // BTN_Next
            // 
            this.BTN_Next.Location = new System.Drawing.Point(131, 151);
            this.BTN_Next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Next.Name = "BTN_Next";
            this.BTN_Next.Size = new System.Drawing.Size(37, 28);
            this.BTN_Next.TabIndex = 16;
            this.BTN_Next.Text = ">>";
            this.BTN_Next.UseVisualStyleBackColor = true;
            this.BTN_Next.Click += new System.EventHandler(this.BTN_Next_Click);
            // 
            // GB_Employés
            // 
            this.GB_Employés.Controls.Add(this.LB_CodeDepList);
            this.GB_Employés.Controls.Add(this.LB_SalaireList);
            this.GB_Employés.Controls.Add(this.LB_PrenomList);
            this.GB_Employés.Controls.Add(this.LB_NomList);
            this.GB_Employés.Controls.Add(this.LB_NumList);
            this.GB_Employés.Controls.Add(this.label11);
            this.GB_Employés.Controls.Add(this.BTN_Next);
            this.GB_Employés.Controls.Add(this.label12);
            this.GB_Employés.Controls.Add(this.BTN_Back);
            this.GB_Employés.Controls.Add(this.label13);
            this.GB_Employés.Controls.Add(this.label14);
            this.GB_Employés.Controls.Add(this.label15);
            this.GB_Employés.Location = new System.Drawing.Point(284, 359);
            this.GB_Employés.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_Employés.Name = "GB_Employés";
            this.GB_Employés.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_Employés.Size = new System.Drawing.Size(253, 184);
            this.GB_Employés.TabIndex = 14;
            this.GB_Employés.TabStop = false;
            this.GB_Employés.Text = "Employés";
            // 
            // LB_CodeDepList
            // 
            this.LB_CodeDepList.Location = new System.Drawing.Point(107, 124);
            this.LB_CodeDepList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_CodeDepList.Name = "LB_CodeDepList";
            this.LB_CodeDepList.Size = new System.Drawing.Size(123, 23);
            this.LB_CodeDepList.TabIndex = 18;
            this.LB_CodeDepList.Text = "Inf";
            // 
            // LB_SalaireList
            // 
            this.LB_SalaireList.Location = new System.Drawing.Point(107, 99);
            this.LB_SalaireList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_SalaireList.Name = "LB_SalaireList";
            this.LB_SalaireList.Size = new System.Drawing.Size(123, 25);
            this.LB_SalaireList.TabIndex = 17;
            this.LB_SalaireList.Text = "10000$";
            // 
            // LB_PrenomList
            // 
            this.LB_PrenomList.Location = new System.Drawing.Point(107, 74);
            this.LB_PrenomList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_PrenomList.Name = "LB_PrenomList";
            this.LB_PrenomList.Size = new System.Drawing.Size(123, 25);
            this.LB_PrenomList.TabIndex = 16;
            this.LB_PrenomList.Text = "Juteux";
            // 
            // LB_NomList
            // 
            this.LB_NomList.Location = new System.Drawing.Point(107, 50);
            this.LB_NomList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NomList.Name = "LB_NomList";
            this.LB_NomList.Size = new System.Drawing.Size(123, 24);
            this.LB_NomList.TabIndex = 15;
            this.LB_NomList.Text = "Poirier";
            // 
            // LB_NumList
            // 
            this.LB_NumList.Location = new System.Drawing.Point(107, 26);
            this.LB_NumList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NumList.Name = "LB_NumList";
            this.LB_NumList.Size = new System.Drawing.Size(123, 24);
            this.LB_NumList.TabIndex = 14;
            this.LB_NumList.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Code Dep :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 98);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Salaire :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 74);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Prenom :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(59, 50);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "Nom :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 26);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "Numero :";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.CB_CodeDepLister);
            this.groupBox7.Location = new System.Drawing.Point(15, 302);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(253, 79);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Lister par departement";
            // 
            // CB_CodeDepLister
            // 
            this.CB_CodeDepLister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_CodeDepLister.FormattingEnabled = true;
            this.CB_CodeDepLister.Location = new System.Drawing.Point(45, 32);
            this.CB_CodeDepLister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_CodeDepLister.Name = "CB_CodeDepLister";
            this.CB_CodeDepLister.Size = new System.Drawing.Size(160, 24);
            this.CB_CodeDepLister.TabIndex = 7;
            this.CB_CodeDepLister.SelectedIndexChanged += new System.EventHandler(this.CB_CodeDepLister_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratoire2_BD.Properties.Resources.LargeWork;
            this.pictureBox1.Location = new System.Drawing.Point(15, 388);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(210)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.GB_Employés);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 554);
            this.panel1.TabIndex = 17;
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(525, 1);
            this.BTN_Quitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(29, 28);
            this.BTN_Quitter.TabIndex = 18;
            this.BTN_Quitter.Text = "X";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(5, 6);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(176, 18);
            this.label16.TabIndex = 19;
            this.label16.Text = "Gestion des employés";
            this.label16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormGestion_MouseDown);
            this.label16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormGestion_MouseMove);
            this.label16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormGestion_MouseUp);
            // 
            // GestionEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(556, 587);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionEmployes";
            this.Text = "Labo 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormGestion_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormGestion_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormGestion_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.GB_Employés.ResumeLayout(false);
            this.GB_Employés.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button BTN_Ajouter;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox TB_CodeDepAjout;
      private System.Windows.Forms.TextBox TB_SalaireAjout;
      private System.Windows.Forms.TextBox TB_PrenomAjout;
      private System.Windows.Forms.TextBox TB_NomAjout;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button BTN_Supprimer;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.TextBox TB_NumEmpDelete;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Button BTN_MAJSalaire;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox TB_NumEmpMAJ;
      private System.Windows.Forms.TextBox TB_SalaireMAJ;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.Label LB_NbreEmployé;
      private System.Windows.Forms.Button BTN_MAJNbre;
      private System.Windows.Forms.GroupBox groupBox5;
      private System.Windows.Forms.Button BTN_Rechercher;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox TB_NomSearch;
      private System.Windows.Forms.Button BTN_Back;
      private System.Windows.Forms.Button BTN_Next;
      private System.Windows.Forms.GroupBox GB_Employés;
      private System.Windows.Forms.Label LB_CodeDepList;
      private System.Windows.Forms.Label LB_SalaireList;
      private System.Windows.Forms.Label LB_PrenomList;
      private System.Windows.Forms.Label LB_NomList;
      private System.Windows.Forms.Label LB_NumList;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.Label label15;
      private System.Windows.Forms.GroupBox groupBox7;
      private System.Windows.Forms.ComboBox CB_CodeDepLister;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button BTN_Quitter;
      private System.Windows.Forms.Label label16;
   }
}

