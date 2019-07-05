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
        int lista_index = 0;
        Boneco Shrek = new Boneco();
        List<Boneco> lista_socios = new List<Boneco>();

        private void limpar_form()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = true;
            comboBox1.SelectedIndex = 0;
        }
//************************ FIM FUNÇOES **********************************
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            lista_socios.Add(new Boneco());
            Label_erros.Visible = false; // esconde a label dos erros
            limpar_form();
        }
          
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
                lista_socios[lista_index].Set_nome (textBox1.Text);  // insere o nome no objecto Shrek
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                 Label_erros.Visible = false;
                lista_socios[lista_index].Set_ano (Convert.ToInt32(textBox2.Text));
                lista_socios[lista_index].Calcular();
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
                lista_socios[lista_index].Set_avenca (Convert.ToDouble(textBox3.Text));
                lista_socios[lista_index].Calcular();
                textBox4.Text = Convert.ToString(lista_socios[lista_index].resultado);

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
                lista_socios[lista_index].box1 = true;
                lista_socios[lista_index].Calcular();
            }
            else
            {
                lista_socios[lista_index].box1= false;
                lista_socios[lista_index].Calcular();
            }

            textBox4.Text = Convert.ToString (lista_socios[lista_index].resultado);
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                lista_socios[lista_index].box2 = true;
                lista_socios[lista_index].Calcular();
            }
            else
            {
                lista_socios[lista_index].box2 = false;
                lista_socios[lista_index].Calcular();
            }

            textBox4.Text = Convert.ToString(lista_socios[lista_index].resultado);
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                lista_socios[lista_index].box3=true;
                lista_socios[lista_index].Calcular();
            }
            else
            {
                lista_socios[lista_index].box3=false;
                lista_socios[lista_index].Calcular();
            }

            textBox4.Text = Convert.ToString(lista_socios[lista_index].resultado);
        }
       
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lista_socios[lista_index].radio1 = true;
                lista_socios[lista_index].Calcular();
            }
            else
            {
                lista_socios[lista_index].radio1 = false;
                lista_socios[lista_index].Calcular();
            }

                textBox4.Text = Convert.ToString(lista_socios[lista_index].resultado);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista_socios[lista_index].Set_conselho (comboBox1.SelectedItem.ToString());
            lista_socios[lista_index].Calcular();
                textBox4.Text = Convert.ToString(lista_socios[lista_index].resultado);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (lista_socios[lista_index].nome != "")
            {
                lista_socios.Add(new Boneco());
                lista_index++;
                limpar_form();
            }
        }
        

        private void Button3_Click(object sender, EventArgs e)
        {
         //   lista_socios.Add(new Boneco());
          //  MessageBox.Show(Convert.ToString(lista_socios.Count));
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < lista_socios.Count-1; i++)

          dataGridView1.Rows.Add (lista_socios[i].nome, lista_socios[i].resultado.ToString());
        }
    }
}
