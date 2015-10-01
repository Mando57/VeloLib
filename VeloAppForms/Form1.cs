using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeloLib;

namespace VeloAppForms
{
    public partial class Form1 : Form
    {
        List<Velo> lesVelos;
        List<VeloElectrique> lesVelosElec;
        public Form1()
        {
            InitializeComponent();
            lesVelos = new List<Velo>();
            lesVelosElec = new List<VeloElectrique>();
            cb_type.SelectedItem = "Vélo simple";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_type.Text == "Vélo simple")
            {
                MessageBox.Show((cb_type.Text));
                Velo v = new Velo(tb_taille.Text, tb_couleur.Text, Convert.ToInt16(tb_pignon.Text), Convert.ToDouble(tb_poids.Text));
                lesVelos.Add(v);
                int ligne = dgv_liste.NewRowIndex;
                dgv_liste.Rows.Add(v.getTailleCadre(), v.getCouleur() , v.getPignon(), v.getPoids());
                dgv_liste.Rows[ligne].Cells[8].Value = "classique";
               // dgv_liste.Rows[dgv_liste.RowCount - 2].Cells[8].Value = "classique";
            }
            else
            {
                MessageBox.Show((cb_type.Text));
                VeloElectrique ve = new VeloElectrique(Convert.ToInt16(tb_puissance.Text), Convert.ToInt16(tb_tension.Text),Convert.ToDouble(tb_capa.Text),Convert.ToDouble(tb_capa.Text),tb_taille.Text, tb_couleur.Text, Convert.ToInt16(tb_pignon.Text), Convert.ToDouble(tb_poids.Text));
                lesVelosElec.Add(ve);
                dgv_liste.Rows.Add(ve.getTailleCadre(), ve.getPoids(), ve.getPignon(), ve.getCouleur(),tb_puissance.Text,tb_tension.Text,tb_capa.Text,tb_capa.Text,"elec");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void Repeindre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous allez modifier le vélo " + dgv_liste.CurrentCell.RowIndex);

            string value = "Entrez ici votre nouvelle couleur";
            if (InputBox("Repeindre", "Nouvelle couleur:", ref value) == DialogResult.OK)
            {
                MessageBox.Show("Votre vélo va être repeint en " + value);
                dgv_liste.CurrentRow.Cells[3].Value = value;
            }

        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_type.Text== "Vélo simple")
            {
                label6.Hide();
                label7.Hide();
                label8.Hide();
                tb_puissance.Hide();
                tb_tension.Hide();
                tb_capa.Hide();
            }
            else
            {
                label6.Show();
                label7.Show();
                label8.Show();
                tb_puissance.Show();
                tb_tension.Show();
                tb_capa.Show();
            }
        }

        private void dgv_liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dgv_liste.Rows[dgv_liste.CurrentCell.RowIndex].Cells[8].Value== "elec")
            {
                button10.Show();
                button11.Show();
                button12.Show();
                button2.Show();
                button3.Show();
                button4.Show();
                button5.Show();
                button6.Show();
                button7.Show();
                button8.Show();
                button9.Show();
            }
            else
            {
                button10.Hide();
                button11.Hide();
                button12.Hide();
                button2.Hide();
                button3.Hide();
                button4.Hide();
                button5.Hide();
                button6.Hide();
                button7.Hide();
                button8.Hide();
                button9.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}