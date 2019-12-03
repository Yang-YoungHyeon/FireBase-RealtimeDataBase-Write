using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Json;

namespace FireBaseTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /* 파이어베이스 데이터 전송 */
        private void Write_Button_Click(object sender, EventArgs e)
        {
            FB_DB_Write(NameText.Text.ToString(), BirthText.Text.ToString(), GenderText.Text.ToString());
        }

        /* FireBase Realtime DataBase : Data Write */
        private void FB_DB_Write(string name, string birth, string gender)
        {
            JsonObjectCollection col = new JsonObjectCollection();
            col.Name = "User";
            col.Add(new JsonStringValue("Name", name));
            col.Add(new JsonStringValue("Birth", birth));
            col.Add(new JsonStringValue("Gender", gender));


            JsonObjectCollection col2 = new JsonObjectCollection();
            col2.Add(col);

            JsonTextParser parser = new JsonTextParser();
            try
            {
                JsonObject NewObject = parser.Parse(col2.ToString());
                var request = WebRequest.CreateHttp("FireBase Address/.josn"); //ex)https://??????????.firebase.com/.json
                request.Method = "PATCH";
                request.ContentType = "JSON";
                var buffer = Encoding.UTF8.GetBytes(NewObject.ToString());
                request.ContentLength = buffer.Length;
                request.GetRequestStream().Write(buffer, 0, buffer.Length);
                var response = request.GetResponse();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }




    }
}
