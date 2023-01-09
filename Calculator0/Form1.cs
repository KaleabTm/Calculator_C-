namespace Calculator0
{
    public partial class Form1 : Form
    {
        public double result = 0;
        public string oprt = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Operadant(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button bt = (Button)sender;
            textBox1.Text += bt.Text;
        }

        private void Operation(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            result = double.Parse(textBox1.Text);
            textBox1.Clear();
            oprt = bt.Text;
            label1.Text = result + " " + oprt;
        }

        private void Answer(object sender, EventArgs e)
        {
            
            double n = double.Parse(textBox1.Text);
            Calc ca = new Calc();
            ca.Op(oprt, result, n);
            double  z= ca.t;
            textBox1.Text=z.ToString();
            
        }

        private void Change_Sign(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('-'))
            {
                textBox1.Text = textBox1.Text.Trim('-');
            }
            else
            {
                if (textBox1.Text == "0")
                    textBox1.Clear();
                textBox1.Text = "-" + textBox1.Text;

            }
        }

        private void Unary(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            result = double.Parse(textBox1.Text);
            textBox1.Clear();
            string b = bt.Text;

            Calc ca = new Calc();
            ca.Un(result, b);
            double z = ca.t;
            textBox1.Text = z.ToString();

        }

        private void Clear_one(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void Clear_all(object sender, EventArgs e)
        {
            result = 0;
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void Clear_last(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void Dot_op(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (!textBox1.Text.Contains(bt.Text))
                textBox1.Text += bt.Text;
        }

    }
}