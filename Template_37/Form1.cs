namespace Template_37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2.form1 = this;
        }

        private void buttonForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}