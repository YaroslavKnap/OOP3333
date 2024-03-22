using OOP3333.ZooApp;

namespace OOP3333
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

        private void button1_Click(object sender, EventArgs e)
        {
            Wolf wolf = new Wolf(30.5, 5, 20.0, "Gray Wolf", "Forests");
            wolf.DisplayInfo();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bear bear = new Bear(200.0, 10, 50.0, "Brown", "Omnivore");
            bear.DisplayInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Giraffe giraffe = new Giraffe(800.0, 7, 100.0, 180, true);
            giraffe.DisplayInfo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Panda panda = new Panda(150.0, 6, 80.0, "Bamboo Forests", true);
            panda.DisplayInfo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    namespace ZooApp
    {
        // Базовий клас Animal +++
        abstract class Animal
        {
            public double Weight { get; }
            public int Age { get; }
            public double DailyMaintenanceCost { get; }

            public Animal(double weight, int age, double dailyMaintenanceCost)
            {
                Weight = weight;
                Age = age;
                DailyMaintenanceCost = dailyMaintenanceCost;
            }

            public abstract void DisplayInfo();

            // Індексатор для доступу до полів за назвою
            public object this[string propertyName]
            {
                get
                {
                    var prop = GetType().GetProperty(propertyName);
                    if (prop != null)
                    {
                        var value = prop.GetValue(this, null);
                        if (value != null)
                        {
                            return value;
                        }
                    }
                    throw new ArgumentException($"Властивість '{propertyName}' не знайдена або має значення null");
                }
            }


        }
        //Наслідування
        // Похідний клас Wolf
        class Wolf : Animal
        {
            public string Breed { get; }
            public string NaturalHabitat { get; }

            public Wolf(double weight, int age, double dailyMaintenanceCost, string breed, string naturalHabitat)
                : base(weight, age, dailyMaintenanceCost)
            {
                Breed = breed;
                NaturalHabitat = naturalHabitat;
            }
            //Віртуальні або абстрактні методи:
            public override void DisplayInfo()
            {
                MessageBox.Show($"Wolf:\nWeight: {this["Weight"]}\nAge: {Age}\nDaily Maintenance Cost: {DailyMaintenanceCost}\nBreed: {Breed}\nNatural Habitat: {NaturalHabitat}");
            }
            // Індексатор для доступу до полів за назвою
            public object this[string propertyName]
            {
                get
                {
                    //MessageBox.Show("1234");
                    var prop = GetType().GetProperty(propertyName);
                    if (prop != null)
                    {
                        var value = prop.GetValue(this, null);
                        if (value != null)
                        {
                            return value;
                        }
                    }
                    throw new ArgumentException($"Властивість '{propertyName}' не знайдена або має значення null");
                }
            }
        }
        // Похідний клас Bear
        class Bear : Animal
        {
            public string FurColor { get; }
            public string Diet { get; }

            public Bear(double weight, int age, double dailyMaintenanceCost, string furColor, string diet)
                : base(weight, age, dailyMaintenanceCost)
            {
                FurColor = furColor;
                Diet = diet;
            }

            public override void DisplayInfo()
            {
                MessageBox.Show($"Bear:\nWeight: {Weight}\nAge: {Age}\nDaily Maintenance Cost: {DailyMaintenanceCost}\nFur Color: {FurColor}\nDiet: {Diet}");
            }
        }
        class Giraffe : Animal
        {
            public int NeckLength { get; }
            public bool SpottedPattern { get; }

            public Giraffe(double weight, int age, double dailyMaintenanceCost, int neckLength, bool spottedPattern)
                : base(weight, age, dailyMaintenanceCost)
            {
                NeckLength = neckLength;
                SpottedPattern = spottedPattern;
            }

            public override void DisplayInfo()
            {
                MessageBox.Show($"Giraffe:\nWeight: {Weight}\nAge: {Age}\nDaily Maintenance Cost: {DailyMaintenanceCost}\nNeck Length: {NeckLength}\nSpotted Pattern: {(SpottedPattern ? "Yes" : "No")}");
            }
        }
        class Panda : Animal
        {
            public string Habitat { get; }
            public bool Endangered { get; }

            public Panda(double weight, int age, double dailyMaintenanceCost, string habitat, bool endangered)
                : base(weight, age, dailyMaintenanceCost)
            {
                Habitat = habitat;
                Endangered = endangered;
            }

            public override void DisplayInfo()
            {
                MessageBox.Show($"Panda:\nWeight: {Weight}\nAge: {Age}\nDaily Maintenance Cost: {DailyMaintenanceCost}\nHabitat: {Habitat}\nEndangered: {(Endangered ? "Yes" : "No")}");
            }
        }
    }
}
