using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web.Script.Serialization;  // solution explorer dan reference add ile system.web.extension ekledik.

namespace u1_jsonOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnJsonOlustur_Click(object sender, EventArgs e)
        {
            Kisiler k1 = new Kisiler();
            k1.Adi = "Yasemin";
            k1.Soyadi = "Göktaş";
            k1.Cinsiyet = "Kız";
            k1.Yas = 24;

            Kisiler k2 = new Kisiler();
            k2.Adi = "Esra";
            k2.Soyadi = "Yılmaz";
            k2.Cinsiyet = "Kız";
            k2.Yas = 30;

            Kisiler k3 = new Kisiler();
            k3.Adi = "Hakan";
            k3.Soyadi = "Başar";
            k3.Cinsiyet = "Erkek";
            k3.Yas = 16;

            List<Kisiler> kisiList = new List<Kisiler>();
            kisiList.Add(k1);
            kisiList.Add(k2);
            kisiList.Add(k3);

            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            string JsonMetniniSakla = jsSerializer.Serialize(kisiList); // listeyi serileştir

            textBox1.Text = JsonMetniniSakla;
        }

        private void btnJSONOku_Click(object sender, EventArgs e)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            List<Kisiler> kisiler = (List<Kisiler>)jsSerializer.Deserialize(textBox1.Text, typeof(List<Kisiler>));

            StringBuilder JsonOkuma = new StringBuilder();

            foreach (Kisiler item in kisiler)
            {
                JsonOkuma.AppendLine("Adi : " + item.Adi);
                JsonOkuma.AppendLine("Soyadi : " + item.Soyadi);
                JsonOkuma.AppendLine("Cinsiyet : " + item.Cinsiyet);
                JsonOkuma.AppendLine("Yaş : " + item.Yas);
            }

            textBox2.Text = JsonOkuma.ToString();

        }
    }
}
