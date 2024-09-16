namespace DvymerniyMassiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int[,] array = new int [n,n];
            int[,] array2 = new int [n-1,n-1];
            int column = 0;
            int line = 0;
            int max = 0;
            Random rnd = new Random();

            for (int i = 0; i < n; i++) {
                string s = "";

                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(-100,100);
                    s += array[i, j].ToString() + " | ";
                }
                listBox1.Items.Add(s);
            }


            for (int k = 0; k < 2; k++) {
                if (k == 0)
                {
                    int a = 0;
                    int b = 0;
                    int c = 0;

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (i == 0 && j == 0)
                            {
                                a = array[i, j];
                            }
                            b = array[i, j];
                            if (Math.Abs(b) > Math.Abs(a))
                            {
                                a = b;
                                max = a;
                            }
                            else
                            {
                                max = a;
                            }
                        }
                        label1.Text = max.ToString();
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            c = array[i, j];
                            if (c == max)
                            {
                                column = i;
                                line = j;
                            }
                        }
                    }
                }else if(k == 1)
                {
                    int num = 0;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (i == column || j == line)
                            {
                                if (i == column)
                                {
                                    break;
                                }
                                else if (j == line)
                                { 
                                    j++;
                                }
                            }
                            else
                            {
                                num = array[i, j];
                                if (i == n - 1 || j == n - 1)
                                {
                                    if (i == n - 1 && j == n - 1)
                                    {
                                        array2[i - 1, j - 1] = num;
                                    }
                                    if (i == n - 1)
                                    {
                                        array2[i - 1, j] = num;
                                    }else if (j == n - 1)
                                    {
                                        array2[i, j - 1] = num;
                                    }
                                }
                                else
                                {
                                    array2[i, j] = num;
                                }
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < n-1; i++)
            {
                string s = "";

                for (int j = 0; j < n-1; j++)
                {
                    s += array2[i, j].ToString() + " | ";
                }
                listBox2.Items.Add(s);
            }
        }
    }
}
