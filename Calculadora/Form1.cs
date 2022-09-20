namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void rd_btn_Basicas_CheckedChanged(object sender, EventArgs e)
        {
            cmBoxBasica.Enabled = true;
            listaAvanzada.Enabled = false;
            cmBoxBasica.Items.Add("Sumar");
            cmBoxBasica.Items.Add("Restar");
        }

        private void rd_btn_Avanzada_CheckedChanged(object sender, EventArgs e)
        {
            cmBoxBasica.Enabled = false;
            listaAvanzada.Enabled = true;
            listaAvanzada.Items.Add("Multiplicar");
            listaAvanzada.Items.Add("Dividir");
        }
    }
}