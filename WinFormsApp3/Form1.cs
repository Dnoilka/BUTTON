using System.CodeDom;

namespace WinFormsApp3
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //�������� ���������� � Form
            TextBox txt = new TextBox(); 
            //����������� ������������� ��������,�� ������� ����� ��������� ������
            txt.Parent = this;
            //�������� ��������� ����������
            txt.Location = new Point(e.X, 20 + 40 );
            // ���������� ��� �������� ����������
            

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
            //�������� ������ � panel
            Button button = new Button();
            //�������� ��������� ������
            button.Location = new Point(e.X, 20 + 40 );
            //���������� ������ �� panel
            panel1.Controls.Add(button);
            




        }
    }
}