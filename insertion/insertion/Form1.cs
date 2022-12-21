namespace insertion
{
    public partial class Form1 : Form
    {
        public int num1;
        public int num2;
        public int num3;
        public int num4;
        public int num5;
        public int num6;
        public int num7;
        public int num8;
        int[]array =new int [1];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1= int.Parse(txt1.Text);
            num2= int.Parse(txt2.Text);
            num3= int.Parse(txt3.Text);
            num4= int.Parse(txt4.Text);
            num5= int.Parse(txt5.Text);
            num6= int.Parse(txt6.Text);
            num7= int.Parse(txt7.Text);
            num8= int.Parse(txt8.Text);
            array= new int[] {num1,num2,num3,num4,num5,num6,num7,num8};
            for (int i = 0; i < array.Length; i++)
            {
                var key = array[i];
                int j = i - 1;

                while (j >=0 && array[j]>key)
                {
                    array[j + 1] = array[j];
                    j= j - 1;
                    array[j + 1] = key;
                }
            }
            string sorted_array=string.Join(",", array);
            label5.Text = sorted_array;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            array=new int[8];
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            label5.Text = "";

        }
    }
}