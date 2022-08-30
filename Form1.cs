using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Text.Json;

namespace TectClientNet
{
    public partial class Form1 : Form
    {
        private partial class JsonRequest
        {
            public string filename { get; set; }
        }
        private string _strCurDir = "";
        public Form1()
        {
            InitializeComponent();
            _strCurDir = Path.GetDirectoryName(Application.ExecutablePath);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.Multiselect = true;
                openFileDialog1.Title = "Выберите файл";
                DialogResult res = openFileDialog1.ShowDialog();
                if (res != DialogResult.OK)
                    return;

                txtPath.Text = openFileDialog1.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtPath.Text))
            {
                MessageBox.Show("Выберите файл для отправки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _SendFileToHttpServerAsync();
        }
        private async void _SendFileToHttpServerAsync()
        {
            try
            {
                Regex regex = new Regex("^[a-zA-Z0-9. -_?]*$");
                if (!regex.IsMatch(txtPath.Text))
                {
                    MessageBox.Show("В имени файла должны быть английские буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                HttpClient httpClient = new HttpClient();
                MultipartFormDataContent form = new MultipartFormDataContent();

                byte[] file_bytes = File.ReadAllBytes(txtPath.Text);
                form.Add(new ByteArrayContent(file_bytes, 0, file_bytes.Length), Path.GetFileNameWithoutExtension(txtPath.Text), Path.GetFileName(txtPath.Text));
                HttpResponseMessage response = await httpClient.PostAsync(txtUrl.Text, form);
                httpClient.Dispose();
                string ans = "Ответ от Сервера: " + ((int)response.StatusCode).ToString() + ", " + response.ReasonPhrase;
                _WriteMessage(ans);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _WriteMessage(string strVal) {

            lbMessages.Items.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")  + " " + strVal);
            lbMessages.SelectedIndex = lbMessages.Items.Count - 1;
        }
        private void btGetFile_Click(object sender, EventArgs e)
        {
            _GetFileFromHttpServer();
        }

        private async void _GetFileFromHttpServer()
        {
            if(txtPathGet.Text.Length > 2 && txtPathGet.Text[1] == ':')
            {
                MessageBox.Show("Укажите имя файла без пути", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ("" == txtPathGet.Text.Trim())
            {
                MessageBox.Show("Выберите имя файла для выкачивания", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string strDownloadFolder = _strCurDir + @"\tmp\";
                string strFileNewPath = strDownloadFolder + txtPathGet.Text;

                if (File.Exists(strFileNewPath)) {

                    DialogResult dialogResult = MessageBox.Show("Перезаписать файл: " + strFileNewPath + "?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult != DialogResult.Yes)
                        return;
                }                    
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), txtUrl.Text))
                    {
                        JsonRequest param = new JsonRequest();
                        param.filename = txtPathGet.Text;
                        string json = JsonSerializer.Serialize(param);

                        request.Content = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await httpClient.SendAsync(request);

                        if (null == response)
                            return;
                        if (200 != (int)response.StatusCode)
                        {
                            string ans = "Ответ от Сервера: " + ((int)response.StatusCode).ToString() + ", " + response.ReasonPhrase;
                            _WriteMessage(ans);
                        } else if (null != response.Content)
                        {
                            if (!Directory.Exists(strDownloadFolder))
                                Directory.CreateDirectory(strDownloadFolder);

                            if (File.Exists(strFileNewPath))
                                File.Delete(strFileNewPath);

                            MemoryStream ms = (MemoryStream)await response.Content.ReadAsStreamAsync();
                            using (Stream file = File.OpenWrite(strDownloadFolder + txtPathGet.Text))
                                ms.WriteTo(file);
                            _WriteMessage("Получен файл:" + strDownloadFolder + txtPathGet.Text);
                        }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
