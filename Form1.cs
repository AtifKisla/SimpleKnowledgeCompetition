namespace KnowledgeC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0;
        int doğru = 0;
        int yanlış = 0;
        int süre = 30;


        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            süre = 30;
            label10.Text = süre.ToString();

            button5.Text = "İLERİ";
            soruno++;
            label2.Text = soruno.ToString();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            if (soruno == 1)
            {
                richTextBox1.Text = "Dede Korkut'un Türk Destanlarının özgün kopyaları hangi iki kentte bulunmaktadır?";

                button1.Text = "Lizbon-Roma";
                button2.Text = "Dresten-Vatikan";
                button3.Text = "Londra-Budapeşte";
                button4.Text = "Paris-Varşova";
                label4.Text = "Dresten-Vatikan";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "1' den 100'e kadar tüm doğal sayıları yazarken toplam kaç adet 8 rakamı kullanmamız gerekir?";
                button1.Text = "10";
                button2.Text = "12";
                button3.Text = "20";
                button4.Text = "21";
                label4.Text = "21";

            }

            if (soruno == 3)
            {
                richTextBox1.Text = "1'den 10'a kadar tüm tam sayılara kalansız bölünebilen en küçük doğal sayı hangisidir?";
                button1.Text = "2520";
                button2.Text = "840";
                button3.Text = "5040";
                button4.Text = "1260";
                label4.Text = "2520";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Hangi işlemin sonucunun birler basamağı 1 değildir?";
                button1.Text = "Elli beş bölü beş";
                button2.Text = "Otuz altı artı beş";
                button3.Text = "Yirmi iki eksi dokuz";
                button4.Text = "On yedi çarpı üç";
                label4.Text = "Yirmi iki eksi dokuz";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            label3.Text = button1.Text;
            if (label3.Text == label4.Text)
            {
                doğru++;
                label6.Text = doğru.ToString();
                MessageBox.Show("Cevap Doğru.");
            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();
                MessageBox.Show($" Cevap Yanlış..Doğru cevap {label4.Text} olacaktı.");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            label3.Text = button2.Text;
            if (label3.Text == label4.Text)
            {
                doğru++;
                label6.Text = doğru.ToString();
                MessageBox.Show("Cevap Doğru.");
            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();
                MessageBox.Show($"Cevap Yanlış.Doğru cevap {label4.Text} olacaktı.");

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            label3.Text = button3.Text;
            if (label3.Text == label4.Text)
            {
                doğru++;
                label6.Text = doğru.ToString();
                MessageBox.Show("Cevap Doğru.Aferin.");
            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();
                MessageBox.Show($"Cevap Yanlış.Doğru cevap {label4.Text} olacaktı.");




            }
        }



        private void button4_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            if (label3.Text == label4.Text)
            {
                doğru++;
                label6.Text = doğru.ToString();
                MessageBox.Show("Cevap Doğru..");
            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();
                MessageBox.Show($"Cevap Yanlış.Doğru cevap {label4.Text} olacaktı.");



            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre = Convert.ToInt32(label10.Text);
            süre = süre - 1;
            label10.Text = süre.ToString();

            if (süre == 0)
            {
                timer1.Enabled = false;
                yanlış += 1;
                label8.Text = yanlış.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
           
        }
    }
}
