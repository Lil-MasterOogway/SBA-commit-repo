namespace TaskThree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // DO NOT MODIFY THIS CODE
        private List<double> GenerateRandomGravity()
        {
            Random random = new Random();
            List<double> gravity = new List<double>();

            while (gravity.Count < 15)
            {
                int earthWeight = random.Next(55,120);
                double jupiter =  earthWeight * 2.53;
                if (jupiter >= 139.15 && jupiter <= 301.07)
                {
                    gravity.Add(jupiter);
                }
            }

            return gravity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Write task 3, step 1 here
            List<double> squares = GenerateRandomGravity();
            // Write task 3, step 2 here
            List<double> group1 = squares.Where(n => n >= 113 && n <= 165).ToList();
            List<double> group2 = squares.Where(n => n >= 166 && n <= 216).ToList();
            List<double> group3 = squares.Where(n => n >= 217 && n <= 280).ToList();
            // Write task 3, step 3 here
            label1.Text = "Squares (113 - 165:" + string.Join(", ", group1);
            label2.Text = "Squares (165 - 216:" + string.Join(", ", group1);
            label3.Text = "Squares (217 - 165280" + string.Join(", ", group1);
            // Write task 3, step 4 here
            label1.ForeColor = Color.Turquoise;
            label2.ForeColor = Color.Coral;
            label3.ForeColor = Color.Crimson;
        }
    }
}
