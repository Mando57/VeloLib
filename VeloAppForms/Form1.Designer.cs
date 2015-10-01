namespace VeloAppForms
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_capa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tension = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_puissance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_poids = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_pignon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_couleur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_taille = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_liste = new System.Windows.Forms.DataGridView();
            this.Repeindre = new System.Windows.Forms.Button();
            this.Taille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Couleur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pignon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_type);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tb_capa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_tension);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_puissance);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_poids);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_pignon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_couleur);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_taille);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 352);
            this.panel1.TabIndex = 0;
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Vélo simple",
            "Vélo électrique"});
            this.cb_type.Location = new System.Drawing.Point(24, 18);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 21);
            this.cb_type.TabIndex = 18;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Créer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_capa
            // 
            this.tb_capa.Location = new System.Drawing.Point(89, 260);
            this.tb_capa.Name = "tb_capa";
            this.tb_capa.Size = new System.Drawing.Size(68, 20);
            this.tb_capa.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cap. batterie";
            // 
            // tb_tension
            // 
            this.tb_tension.Location = new System.Drawing.Point(89, 229);
            this.tb_tension.Name = "tb_tension";
            this.tb_tension.Size = new System.Drawing.Size(68, 20);
            this.tb_tension.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tension";
            // 
            // tb_puissance
            // 
            this.tb_puissance.Location = new System.Drawing.Point(89, 196);
            this.tb_puissance.Name = "tb_puissance";
            this.tb_puissance.Size = new System.Drawing.Size(68, 20);
            this.tb_puissance.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.label8.Location = new System.Drawing.Point(21, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Puissance";
            // 
            // tb_poids
            // 
            this.tb_poids.Location = new System.Drawing.Point(89, 166);
            this.tb_poids.Name = "tb_poids";
            this.tb_poids.Size = new System.Drawing.Size(68, 20);
            this.tb_poids.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Poids";
            // 
            // tb_pignon
            // 
            this.tb_pignon.Location = new System.Drawing.Point(89, 137);
            this.tb_pignon.Name = "tb_pignon";
            this.tb_pignon.Size = new System.Drawing.Size(68, 20);
            this.tb_pignon.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pignon";
            // 
            // tb_couleur
            // 
            this.tb_couleur.Location = new System.Drawing.Point(89, 106);
            this.tb_couleur.Name = "tb_couleur";
            this.tb_couleur.Size = new System.Drawing.Size(68, 20);
            this.tb_couleur.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Couleur";
            // 
            // tb_taille
            // 
            this.tb_taille.BackColor = System.Drawing.SystemColors.Window;
            this.tb_taille.ForeColor = System.Drawing.Color.Black;
            this.tb_taille.Location = new System.Drawing.Point(89, 73);
            this.tb_taille.Name = "tb_taille";
            this.tb_taille.Size = new System.Drawing.Size(68, 20);
            this.tb_taille.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Taille";
            // 
            // dgv_liste
            // 
            this.dgv_liste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Taille,
            this.Couleur,
            this.Poids,
            this.Pignon,
            this.Puissance,
            this.Tension,
            this.Capacité,
            this.Restant,
            this.type});
            this.dgv_liste.Location = new System.Drawing.Point(218, 12);
            this.dgv_liste.Name = "dgv_liste";
            this.dgv_liste.Size = new System.Drawing.Size(843, 352);
            this.dgv_liste.TabIndex = 1;
            this.dgv_liste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_liste_CellContentClick);
            // 
            // Repeindre
            // 
            this.Repeindre.Location = new System.Drawing.Point(1090, 28);
            this.Repeindre.Name = "Repeindre";
            this.Repeindre.Size = new System.Drawing.Size(75, 23);
            this.Repeindre.TabIndex = 2;
            this.Repeindre.Text = "Repeindre";
            this.Repeindre.UseVisualStyleBackColor = true;
            this.Repeindre.Click += new System.EventHandler(this.Repeindre_Click);
            // 
            // Taille
            // 
            this.Taille.Frozen = true;
            this.Taille.HeaderText = "Taille";
            this.Taille.Name = "Taille";
            this.Taille.ReadOnly = true;
            // 
            // Couleur
            // 
            this.Couleur.Frozen = true;
            this.Couleur.HeaderText = "Couleur";
            this.Couleur.Name = "Couleur";
            this.Couleur.ReadOnly = true;
            // 
            // Poids
            // 
            this.Poids.Frozen = true;
            this.Poids.HeaderText = "Poids";
            this.Poids.Name = "Poids";
            this.Poids.ReadOnly = true;
            // 
            // Pignon
            // 
            this.Pignon.Frozen = true;
            this.Pignon.HeaderText = "Pignon";
            this.Pignon.Name = "Pignon";
            this.Pignon.ReadOnly = true;
            // 
            // Puissance
            // 
            this.Puissance.Frozen = true;
            this.Puissance.HeaderText = "Puissance";
            this.Puissance.Name = "Puissance";
            // 
            // Tension
            // 
            this.Tension.Frozen = true;
            this.Tension.HeaderText = "Tension";
            this.Tension.Name = "Tension";
            // 
            // Capacité
            // 
            this.Capacité.Frozen = true;
            this.Capacité.HeaderText = "capacité";
            this.Capacité.Name = "Capacité";
            // 
            // Restant
            // 
            this.Restant.Frozen = true;
            this.Restant.HeaderText = "Restant";
            this.Restant.Name = "Restant";
            // 
            // type
            // 
            this.type.Frozen = true;
            this.type.HeaderText = "type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1090, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Rechager";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1090, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "consomation Moteur";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1090, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Ampere";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1185, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(8, 8);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1090, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "temps restant";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1090, 175);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "auto total";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1090, 204);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "conso moy W";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1090, 238);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "prevoir dis";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1090, 268);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "auton/KM";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1090, 297);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 12;
            this.button11.Text = "upgrade";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1090, 326);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 13;
            this.button12.Text = "nb Trajet";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 376);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Repeindre);
            this.Controls.Add(this.dgv_liste);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_poids;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_pignon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_couleur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_taille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_capa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tension;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_puissance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_liste;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button Repeindre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taille;
        private System.Windows.Forms.DataGridViewTextBoxColumn Couleur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poids;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pignon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restant;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

