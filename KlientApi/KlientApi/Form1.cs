using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;

namespace KlientApi
{
    public partial class Form1 : Form
    {
        public Dictionary<Guid, string> Pokoje = new Dictionary<Guid, string>();
        public Dictionary<Guid, string> Osoby = new Dictionary<Guid, string>();
        public Dictionary<Guid, Guid> Ewidencja = new Dictionary<Guid, Guid>();
        private HttpClient client = new HttpClient();
        private static string URL = $"https://localhost:44300/api/";
        private Guid CurrentOsoba;
        private Guid CurrentPokoj;

        public Form1()
        {
            InitializeComponent();
            OsobyCombo.DisplayMember = "Value";
            OsobyCombo.SelectedValue = "Key";
            PokojeCombo.DisplayMember = "Value";
            PokojeCombo.SelectedValue = "Key";
            
        }

        private void DataLoadButton_Click(object sender, EventArgs e)
        {
            var responseEwidencja = client.GetAsync(URL+"Ewidencja").Result.Content.ReadAsStringAsync().Result;
            Ewidencja = JsonConvert.DeserializeObject<Dictionary<Guid,Guid>>(responseEwidencja);
           

            var responseOsoby = client.GetAsync(URL + "Osoby").Result.Content.ReadAsStringAsync().Result;
            Osoby = JsonConvert.DeserializeObject<Dictionary<Guid, string>>(responseOsoby);
            

            var responsePokoje = client.GetAsync(URL + "Pokoje").Result.Content.ReadAsStringAsync().Result;
            Pokoje = JsonConvert.DeserializeObject<Dictionary<Guid, string>>(responsePokoje);

            List<GridView> view = new List<GridView>();
            foreach (var item in Ewidencja)
            {
                view.Add(new GridView(item.Key, item.Value, Pokoje.FirstOrDefault(f => f.Key == item.Key).Value, Osoby.FirstOrDefault(f => f.Key == item.Value).Value));
            }
            DataGrid.DataSource = null;
            DataGrid.DataSource = view;


            
            OsobyCombo.DataSource = Osoby.ToList();

            
            PokojeCombo.DataSource = Pokoje.ToList();
           
        }

        private void OsobyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<Guid, string> Nowy = (KeyValuePair<Guid, string>)OsobyCombo.SelectedItem;
                OsobyTextBox.Text = Nowy.Value.ToString();
            CurrentOsoba = Nowy.Key;
        }

        private void PokojeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<Guid, string> Nowy = (KeyValuePair<Guid, string>)PokojeCombo.SelectedItem;
            PokojText.Text = Nowy.Value.ToString();
            CurrentPokoj = Nowy.Key;
        }

        private void UsunOsobe_Click(object sender, EventArgs e)
        {
            
            var response = client.DeleteAsync(URL + "Osoby/" + CurrentOsoba.ToString());
            DataLoadButton_Click(null, null);
        }

        private void EdytujOsobe_Click(object sender, EventArgs e)
        {
            var Content = new StringContent($"\"{OsobyTextBox.Text}\"",Encoding.UTF8,"application/json");
            var response = client.PutAsync(URL + "Osoby/" + CurrentOsoba.ToString(), Content);
            DataLoadButton_Click(null, null);
        }

        private void UsunPokoj_Click(object sender, EventArgs e)
        {
            var response = client.DeleteAsync(URL + "Pokoje/" + CurrentPokoj.ToString());
            DataLoadButton_Click(null, null);
        }

        private void EdytujPokoj_Click(object sender, EventArgs e)
        {
            var Content = new StringContent($"\"{PokojText.Text}\"", Encoding.UTF8, "application/json");
            var response = client.PutAsync(URL + "Pokoje/" + CurrentPokoj.ToString(), Content);
            DataLoadButton_Click(null, null);
        }

        private void DodajOsobe_Click(object sender, EventArgs e)
        {
            var Content = new StringContent($"\"{OsobyTextBox.Text}\"", Encoding.UTF8, "application/json");
            var response = client.PostAsync(URL + "Osoby/", Content);
            DataLoadButton_Click(null, null);
        }

        private void DodajPokoj_Click(object sender, EventArgs e)
        {
            var Content = new StringContent($"\"{PokojText.Text}\"", Encoding.UTF8, "application/json");
            var response = client.PostAsync(URL + "Pokoje/", Content);
            DataLoadButton_Click(null, null);
        }

        private void DodajEwidencje_Click(object sender, EventArgs e)
        {
            var response = client.PostAsync(URL + $"Ewidencja/PostByPokoj?Pokoj={CurrentPokoj.ToString()}&Osoba={CurrentOsoba.ToString()}",null);
            DataLoadButton_Click(null, null);
        }

        private void UsunEwidencje_Click(object sender, EventArgs e)
        {
            try
            {
                GridView Selector = DataGrid.SelectedRows[0].DataBoundItem as GridView;
                var response = client.DeleteAsync(URL + $"Ewidencja/{Selector.gp}");
            }
            catch { }
            DataLoadButton_Click(null, null);
        }



    }
}
