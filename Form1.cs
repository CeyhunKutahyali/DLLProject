using DLLExample;
using Rectangle = DLLExample.Rectangle;

namespace DLLProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text.ToString());
            int square = Calculator.squareCalculate(number);
            textBox2.Text = square.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text.ToString());
            int cube = Calculator.cubeCalculate(number);
            textBox2.Text = cube.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(Convert.ToInt32(textBox1.Text.ToString()), Convert.ToInt32(textBox3.Text.ToString()));
            textBox2.Text = rectangle.areaCalculate().ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(Convert.ToInt32(textBox1.Text.ToString()), Convert.ToInt32(textBox3.Text.ToString()));
            textBox2.Text = rectangle.primeterCalculate().ToString();
        }
    }
}