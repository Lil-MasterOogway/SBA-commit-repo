namespace TaskOne
{
    public partial class Form1 : Form
    {
        private List<Planet> planets;

        public Form1()
        {
            InitializeComponent();

            planets = new List<Planet>
            {
                new Planet("Mercury", 0, false),
                new Planet("Venus", 0, false),
                new Planet("Earth", 1, false),
                new Planet("Mars", 2, false),
                new Planet("Jupiter", 95, true),
                new Planet("Saturn", 146, true),
                new Planet("Uranus", 28, true),
                new Planet("Neptune", 16, true),
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Write task 1, step 4 here
            List<Planet>nameStartM = planets.Where(p => p.Name.StartsWith("M")).ToList();
            listBox1.Items.Clear();

            // Write task 1, step 5 here
            foreach (Planet p in nameStartM)
            {
                listBox1.Items.Add(p);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Write task 1, step 6 here
            List<Planet> moonNumberRange = planets.Where(p => p.NumberOfMoons>=15 && p.NumberOfMoons <= 100).ToList();
            listBox2.Items.Clear();

            // Write task 1, step 7 here
            foreach (Planet p in moonNumberRange)
            {
                listBox2.Items.Add(p);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Write task 1, step 8 here
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
