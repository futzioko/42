namespace Template_37
{
    public partial class Form2 : Form
    {
        public static Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            form1.comboBox1.Items.Add(str);
        }
    }
}
