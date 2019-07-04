using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shrek
{
    public partial class Form1 : Form
    {

        Boneco Shrek = new Boneco();
        

//************************ FIM FUNÇOES **********************************
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                Label_erros.Visible = false; // esconde a label dos erros
        }
          
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
                Shrek.Set_nome (textBox1.Text);  // insere o nome no objecto Shrek
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                 Label_erros.Visible = false;
                 Shrek.Set_ano (Convert.ToInt32(textBox2.Text));
                 Shrek.Calcular();
                 textBox4.Text = Convert.ToString(Shrek.resultado);
            }
             
            catch (Exception)
            {
                Label_erros.Visible = true;
                Label_erros.Text = "Dados Invalidos";
                textBox2.Text = "";
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Label_erros.Visible = false;
                Shrek.Set_avenca (Convert.ToDouble(textBox3.Text));
                Shrek.Calcular();
                textBox4.Text = Convert.ToString(Shrek.resultado);

            }
            catch(Exception)
            {
                Label_erros.Visible = true;
                Label_erros.Text = "Dados Invalidos";
                textBox3.Text = "";
            }

        }
        
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Shrek.box1 = true;
                Shrek.Calcular();
            }
            else
            {
                Shrek.box1= false;
                Shrek.Calcular();
            }

            textBox4.Text = Convert.ToString (Shrek.resultado);
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Shrek.box2 = true;
                Shrek.Calcular();
            }
            else
            {
                Shrek.box2 = false;
                Shrek.Calcular();
            }

            textBox4.Text = Convert.ToString(Shrek.resultado);
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Shrek.box3=true;
                Shrek.Calcular();
            }
            else
            {
                Shrek.box3=false;
                Shrek.Calcular();
            }

            textBox4.Text = Convert.ToString(Shrek.resultado);
        }
       
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Shrek.radio1 = true;
                Shrek.Calcular();
            }
            else
            {
                Shrek.radio1 = false;
                Shrek.Calcular();
            }

                textBox4.Text = Convert.ToString(Shrek.resultado);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                Shrek.Set_conselho (comboBox1.SelectedItem.ToString());
                Shrek.Calcular();
                textBox4.Text = Convert.ToString(Shrek.resultado);
        }

      
    }
}
