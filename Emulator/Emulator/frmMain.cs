using Newtonsoft.Json;

using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace Emulator
{
    public partial class frmMain : Form
    {
        private Dictionary<string, string> Messages;

        public frmMain()
        {
            InitializeComponent();
            Messages = new Dictionary<string, string>();
            Messages.Add("1", "Всё работает штатно, работы по обновлению не ведутся");
            Messages.Add("2", "Сервис недоступен, ведутся технические работы");
            Messages.Add("3", "Сейчас всё работает штатно, но на {0:dd.MM.yyyy} запланированы работы");
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            txtServer.Text = ConfigurationManager.AppSettings["Server"];
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create(txtServer.Text);
            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string json = reader.ReadToEnd();
            Result result = JsonConvert.DeserializeObject<Result>(json);
            if (!String.IsNullOrEmpty(result.ErrorMessage))
                MessageBox.Show(result.ErrorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string statusCode = ((IDictionary<string, JToken>)result.Data)["statusCode"].ToString();
                string dateStr = ((IDictionary<string, JToken>)result.Data)["date"].ToString();
                DateTime date = DateTime.ParseExact(dateStr, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                string message = String.Format(Messages[statusCode], date);
                MessageBox.Show(message, "Отчет о статусе");
            }
        }
    }
}
