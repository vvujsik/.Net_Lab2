using System.Text.Json;

namespace Lab2_Api
{
    public partial class Form1 : Form
    {
        private HttpClient client;
        private Bazadanych baza;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            baza = new Bazadanych();
            listBox1.DataSource = baza.Weather.ToList<PogodaDB>();
        }

        private async void buttonDownload_ClickAsync(object sender, EventArgs e)
        {
            const string api_key = "46f78b6c0920dc77457e0f027e5a75f5";
            string city = City_text.Text;
            string call = "https://api.openweathermap.org/data/2.5/weather?q=";
            call += city;
            call += "&appid=" + api_key;
            if (!baza.Weather.Any(x => x.Name == city) && !baza.Weather.Any(s => s.wejscie == city))
            {
                try
                {
                    string response = await client.GetStringAsync(call);
                    Pogoda pogoda = JsonSerializer.Deserialize<Pogoda>(response);
                    if (pogoda.cod == 200)
                    {
                        baza.Weather.Add(new PogodaDB()
                        {
                            Name = pogoda.name,
                            wejscie = city,
                            Temp = pogoda.main.temp,
                            Lat = pogoda.coord.lat,
                            Lon = pogoda.coord.lon,
                            Country = pogoda.sys.country,
                        });
                        baza.SaveChanges();
                        listBox1.DataSource = baza.Weather.ToList<PogodaDB>();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("City not found");
                }
            }
            else
            {
                MessageBox.Show("Podane miasto znajduje sie juz w bazie danych");
            }
            City_text.Text = null;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            baza.Weather.RemoveRange(baza.Weather);
            baza.SaveChanges();
            listBox1.DataSource = baza.Weather.ToList<PogodaDB>();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (baza.Weather.Any(x => x.Id == int.Parse(textBox_ID.Text)))
            {
                var element = baza.Weather.First(s => s.Id == int.Parse(textBox_ID.Text));
                baza.Weather.Remove(element);
                baza.SaveChanges();
                listBox1.DataSource = baza.Weather.ToList<PogodaDB>();
                textBox_ID.Text = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = baza.Weather.ToList<PogodaDB>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = baza.Weather.OrderBy(s => s.Temp).ToList<PogodaDB>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = baza.Weather.OrderBy(s => s.Temp).Reverse().ToList<PogodaDB>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float average = 0;
            List<PogodaDB> lista = baza.Weather.Where(x => x.Country == textBox2.Text).ToList<PogodaDB>();
            foreach (var elem in lista)
            {
                average = average + elem.Temp;
            }
            average = (average / lista.Count) - (float)273.15;
            textBox1.Text = average.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = baza.Weather.OrderBy(s=>s.Country).ToList<PogodaDB>();
        }
    }
}
