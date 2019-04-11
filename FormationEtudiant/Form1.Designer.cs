namespace FormationEtudiant
{
    partial class cmb_formation
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
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_form = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.btn_ret_ins = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.list_java = new System.Windows.Forms.ListBox();
            this.listc = new System.Windows.Forms.ListBox();
            this.list_sql = new System.Windows.Forms.ListBox();
            this.lbl_java = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_sql = new System.Windows.Forms.Label();
            this.btn_rech = new System.Windows.Forms.Button();
            this.btn_ann = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nom.Location = new System.Drawing.Point(101, 36);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(129, 20);
            this.txt_nom.TabIndex = 0;
            this.txt_nom.TextChanged += new System.EventHandler(this.txt_nom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etudiant";
            // 
            // cmb_form
            // 
            this.cmb_form.FormattingEnabled = true;
            this.cmb_form.Location = new System.Drawing.Point(101, 72);
            this.cmb_form.Name = "cmb_form";
            this.cmb_form.Size = new System.Drawing.Size(129, 21);
            this.cmb_form.TabIndex = 2;
            this.cmb_form.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Formation";
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(446, 33);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(158, 23);
            this.btn_ajout.TabIndex = 4;
            this.btn_ajout.Text = "Ajouter inscription";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // btn_ret_ins
            // 
            this.btn_ret_ins.Location = new System.Drawing.Point(446, 75);
            this.btn_ret_ins.Name = "btn_ret_ins";
            this.btn_ret_ins.Size = new System.Drawing.Size(158, 23);
            this.btn_ret_ins.TabIndex = 5;
            this.btn_ret_ins.Text = "Retirer inscription";
            this.btn_ret_ins.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Formation JAVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Formation C# .NET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Formation SQL";
            // 
            // list_java
            // 
            this.list_java.FormattingEnabled = true;
            this.list_java.Location = new System.Drawing.Point(36, 188);
            this.list_java.Name = "list_java";
            this.list_java.Size = new System.Drawing.Size(107, 69);
            this.list_java.TabIndex = 9;
            this.list_java.SelectedIndexChanged += new System.EventHandler(this.list_java_SelectedIndexChanged);
            // 
            // listc
            // 
            this.listc.FormattingEnabled = true;
            this.listc.Location = new System.Drawing.Point(287, 188);
            this.listc.Name = "listc";
            this.listc.Size = new System.Drawing.Size(95, 69);
            this.listc.TabIndex = 10;
            // 
            // list_sql
            // 
            this.list_sql.FormattingEnabled = true;
            this.list_sql.Location = new System.Drawing.Point(516, 188);
            this.list_sql.Name = "list_sql";
            this.list_sql.Size = new System.Drawing.Size(88, 69);
            this.list_sql.TabIndex = 11;
            // 
            // lbl_java
            // 
            this.lbl_java.AutoSize = true;
            this.lbl_java.Location = new System.Drawing.Point(55, 271);
            this.lbl_java.Name = "lbl_java";
            this.lbl_java.Size = new System.Drawing.Size(13, 13);
            this.lbl_java.TabIndex = 12;
            this.lbl_java.Text = "0";
            this.lbl_java.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(310, 271);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(16, 13);
            this.lbl_c.TabIndex = 13;
            this.lbl_c.Text = "0 ";
            // 
            // lbl_sql
            // 
            this.lbl_sql.AutoSize = true;
            this.lbl_sql.Location = new System.Drawing.Point(548, 271);
            this.lbl_sql.Name = "lbl_sql";
            this.lbl_sql.Size = new System.Drawing.Size(13, 13);
            this.lbl_sql.TabIndex = 14;
            this.lbl_sql.Text = "0";
            // 
            // btn_rech
            // 
            this.btn_rech.Location = new System.Drawing.Point(101, 299);
            this.btn_rech.Name = "btn_rech";
            this.btn_rech.Size = new System.Drawing.Size(161, 23);
            this.btn_rech.TabIndex = 15;
            this.btn_rech.Text = "chercher formation";
            this.btn_rech.UseVisualStyleBackColor = true;
            // 
            // btn_ann
            // 
            this.btn_ann.Location = new System.Drawing.Point(486, 299);
            this.btn_ann.Name = "btn_ann";
            this.btn_ann.Size = new System.Drawing.Size(118, 23);
            this.btn_ann.TabIndex = 16;
            this.btn_ann.Text = "Annuler formation";
            this.btn_ann.UseVisualStyleBackColor = true;
            // 
            // cmb_formation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 334);
            this.Controls.Add(this.btn_ann);
            this.Controls.Add(this.btn_rech);
            this.Controls.Add(this.lbl_sql);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.lbl_java);
            this.Controls.Add(this.list_sql);
            this.Controls.Add(this.listc);
            this.Controls.Add(this.list_java);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ret_ins);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_form);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nom);
            this.Name = "cmb_formation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.cmb_formation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_form;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.Button btn_ret_ins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox list_java;
        private System.Windows.Forms.ListBox listc;
        private System.Windows.Forms.ListBox list_sql;
        private System.Windows.Forms.Label lbl_java;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lbl_sql;
        private System.Windows.Forms.Button btn_rech;
        private System.Windows.Forms.Button btn_ann;
    }
}

