namespace Cedula_winforms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SexoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox sexoComboBox = new ComboBox();
            sexoComboBox.Items.Add("M");
            sexoComboBox.Items.Add("F");

            this.Controls.Add(sexoComboBox);

        }
    }
}