namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Log("��������� button4");

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            MessageBox.Show("�������� �� ��������, ������ �� �쳺�?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Log("��������� button1");

            MessageBox.Show("�����");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Log("��������� button2");

            label1.Text = "� �� �� ���� ?";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Log("��������� button3");

            textBox1.Text = "���������?";
        }
    }
}