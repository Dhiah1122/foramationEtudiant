using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormationEtudiant
{
    public partial class cmb_formation : Form
    {
        int i = 0;
        public cmb_formation()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_formation_Load(object sender, EventArgs e)
        {
            cmb_form.Items.Add("JAVA");
            cmb_form.Items.Add("C# .NET");
            cmb_form.Items.Add("SQL");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {
            if (txt_nom.Text == "")
            {
                btn_ajout.Enabled = false;
            }
            else
            {
                btn_ajout.Enabled = true;
            }
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {

            if (cmb_form.SelectedItem=="JAVA")
                {
                    list_java.Items.Add(txt_nom.Text);
                    lbl_java.Text = "" + list_java.Items.Count;
                }
                if (cmb_form.SelectedItem == "C# .NET")
                {
                    listc.Items.Add(txt_nom.Text);
                   
                }
                if (cmb_form.SelectedItem == "SQL")
                {
                    list_sql.Items.Add(txt_nom.Text);
                }
        }

        private void list_java_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
