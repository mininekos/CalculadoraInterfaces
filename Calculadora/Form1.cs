namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmBoxBasica.Items.Add("Sumar");
            cmBoxBasica.Items.Add("Restar");
            listaAvanzada.Items.Add("Multiplicar");
            listaAvanzada.Items.Add("Dividir");
            cmBoxBasica.SelectedIndex = 0;
        }


        private void rd_btn_Basicas_CheckedChanged(object sender, EventArgs e)
        {
            cmBoxBasica.Enabled = true;
            listaAvanzada.Enabled = false;

        }

        private void rd_btn_Avanzada_CheckedChanged(object sender, EventArgs e)
        {
            cmBoxBasica.Enabled = false;
            listaAvanzada.Enabled = true;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text), num2 = Convert.ToInt32(txtNum2.Text);
            if (cmBoxBasica.Enabled == true)
            {
                if (cmBoxBasica.Text == "Sumar")
                {
                    MessageBox.Show("La suma es: " + (num1 + num2));
                }
                else 
                    MessageBox.Show("La resta es: " + (num1 - num2));
            }

            if (listaAvanzada.Enabled == true)
            {
                if (listaAvanzada.Text == "Multiplicar")
                {
                    MessageBox.Show("La multiplicacion es: " + (num1 * num2));
                }
                else if (listaAvanzada.Text == "Dividir")
                {
                    MessageBox.Show("La division es: " + (num1 / num2));
                }
                else
                    MessageBox.Show("No ha seleccionado operacion");
            }
        }
    }
 }