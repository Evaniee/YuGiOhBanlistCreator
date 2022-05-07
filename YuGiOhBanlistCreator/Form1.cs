using Newtonsoft.Json.Linq;
using System.Text;

namespace YuGiOhBanlistCreator
{
    public partial class Form1 : Form
    {
        private readonly string ApiUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php";
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_cards.Rows.Clear();
            string webString = string.Empty;
            string apiQuery = ApiUrl + "?fname=" + txt_search.Text;
            MessageBox.Show(apiQuery);
            // Retrieve Query
            using(HttpClient client = new HttpClient())
            {
                try
                {
                    webString = client.GetStringAsync(apiQuery).Result.ToString();
                }
                catch (AggregateException aggregateError)
                {
                    webString = string.Empty;
                    MessageBox.Show(aggregateError.Message);
                }
                catch(HttpRequestException httpError)
                {
                    webString = string.Empty;
                    MessageBox.Show(httpError.Message);
                }
            }
            if (webString != string.Empty)
            {
                File.WriteAllText("queryresult.json", webString);
                JArray jArray = (JArray)JObject.Parse(webString)["data"];
                List<Tuple<string, string>> cards = new List<Tuple<string, string>>();
                foreach (JObject jObject in jArray)
                    dgv_cards.Rows.Add(new string[] { jObject.SelectToken("name").ToString(), jObject.SelectToken("id").ToString() });
            }
        }

        private void forbiddenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_cards.SelectedRows.Count > 0)
            {
                for(int i = 0; i < dgv_cards.SelectedRows.Count; i++)
                {
                    dgv_forbidden.Rows.Add(new string[] {dgv_cards.SelectedRows[i].Cells[0].Value.ToString(), dgv_cards.SelectedRows[i].Cells[1].Value.ToString() });
                }
            }

        }

        private void limitedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_cards.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgv_cards.SelectedRows.Count; i++)
                {
                    dgv_limited.Rows.Add(new string[] { dgv_cards.SelectedRows[i].Cells[0].Value.ToString(), dgv_cards.SelectedRows[i].Cells[1].Value.ToString() });
                }
            }
        }

        private void semiLimitedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_cards.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgv_cards.SelectedRows.Count; i++)
                {
                    dgv_limited.Rows.Add(new string[] { dgv_cards.SelectedRows[i].Cells[0].Value.ToString(), dgv_cards.SelectedRows[i].Cells[1].Value.ToString() });
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ofd_openList.ShowDialog() == DialogResult.OK)
            {
                List<Tuple<string, string, string>> listLines = new List<Tuple<string, string, string>>();
                foreach(string line in File.ReadAllLines(ofd_openList.FileName)) 
                {
                    if (!line.StartsWith('#') && !line.StartsWith("!") && !line.StartsWith("$"))
                    {
                        string[] splits = line.Split(' ');
                        if(splits.Length > 1)
                        {
                            string id = splits[0];
                            string limit = splits[1];
                            StringBuilder nameBuilder = new StringBuilder();
                            for(int i = 2; i < splits.Length; i++)
                            {
                                if (i != 2)
                                    nameBuilder.Append(" ");
                                nameBuilder.Append(splits[i]);
                            }
                            string name = nameBuilder.ToString().Remove(0, 2);
                            listLines.Add(new Tuple<string, string, string>(id, limit, name.ToString()));
                        }
                    }
                }
                foreach (Tuple<string, string, string> line in listLines)
                {
                    switch (line.Item2)
                    {
                        case "0":
                            dgv_forbidden.Rows.Add(new string[] { line.Item3, line.Item1 });
                            break;
                        case "1":
                            dgv_limited.Rows.Add(new string[] { line.Item3, line.Item1 });
                            break;
                        case "2":
                            dgv_semi.Rows.Add(new string[] { line.Item3, line.Item1 });
                            break;
                    }
                }
            }
        }
    }
}