using System.ComponentModel.Design;

namespace TaskTwo
{
    public partial class Form1 : Form
    {
        private List<Planet> planets;

        public Form1()
        {
            InitializeComponent();

            planets = new List<Planet>
            {
                new RockyPlanet("Mercury", 88),
                new RockyPlanet("Venus", 225),
                new RockyPlanet("Earth", 365),
                new RockyPlanet("Mars", 687),
                new GasGiant("Jupiter", 4333),
                new GasGiant("Saturn", 10759),
                new GasGiant("Uranus", 30687),
                new GasGiant("Neptune", 60190)
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Write task 2, step 8 here
            dataGridView1.Columns.Add("name", "Name");
            dataGridView1.Columns.Add("yearLengthInEarthDays", "YearLengthInEarthDays");
            // Write task 2, step 9 here
            foreach (Planet planet in planets)
            {
                dataGridView1.Rows.Add(planet.Name, planet.YearLengthInEarthDays);
            }

            // DO NOT MODIFY THIS CODE
            int rowHeight = dataGridView1.RowTemplate.Height;
            int headerHeight = dataGridView1.ColumnHeadersHeight;
            dataGridView1.Height = headerHeight + (rowHeight * (planets.Count + 1));

            // Write task 2, step 10 here
            int count = planets.Count(planet => planet.YearLengthInEarthDays <= 5000);
            MessageBox.Show($"Number of planets with their year in Earth days <= 5000: {count}");
        }
    }
}
