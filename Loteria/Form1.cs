namespace Loteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNjugar_Click(object sender, EventArgs e)
        {
            MASKEDnum.Enabled = true;
            MessageBox.Show("TENDRAS QUE ADIVINAR LOS NUMEROS 1 AL 100, EL COMENTARIO TE DIRA SI ESTAS CERCA O NO, TIENES 3 OPORTUNIDADES");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TXB1.Enabled = false;
            TXB2.Enabled = false;
            TXB3.Enabled = false;
            MASKEDnum.Enabled = false;
        }
    }
}