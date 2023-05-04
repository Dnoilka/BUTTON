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
            //создание текстбокса в Form
            TextBox txt = new TextBox(); 
            //определение родительского элемента,на котором будет размещена кнопка
            txt.Parent = this;
            //Создание положение текстбокса
            txt.Location = new Point(e.X, 20 + 40 );
            // Перебираем все элементы управления
            

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
            //создание кнопки в panel
            Button button = new Button();
            //Создание положение кнопки
            button.Location = new Point(e.X, 20 + 40 );
            //добавление кнопки на panel
            panel1.Controls.Add(button);
            




        }
    }
}