using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace LILIN_Aida_Test
{
    public partial class AIdaSendImage : Form
    {
        public AIdaSendImage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Browse 按鈕觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Multiselect = false,
                Title = "選擇圖片",
                Filter = "Image files (*.jpg, *.jpeg) | *.jpg; *.jpeg"
            };

            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                try
                {
                    Image img = Image.FromFile(dialog.FileName);

                    pb_image.Image = img;
                    pb_image.Width = pb_image.Image.Width;
                    pb_image.Height = pb_image.Image.Height;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        /// <summary>
        /// Send 按鈕觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Send_Click(object sender, EventArgs e)
        {
            string msg = "";
            byte[] imgbyte = null;

            using (var ms = new MemoryStream())
            {
                pb_image.Image.Save(ms, pb_image.Image.RawFormat);
                imgbyte = ms.ToArray();
            }

            string remsg = MyHttpPost(@"http://" + Tb_IP.Text + ":" + Tb_Port.Text + "/sendjpeg?channel=17", 5000, imgbyte, Tb_Account.Text, Tb_Password.Text, ref msg);

            if (remsg != "")
            {
                Console.WriteLine(remsg);
            }

            if (msg != "")
            {
                Console.WriteLine(msg);
            }
        }

        /// <summary>
        /// 傳送 HTTP POST
        /// </summary>
        /// <param name="url"></param>
        /// <param name="Timeout"></param>
        /// <param name="content"></param>
        /// <param name="uaccount"></param>
        /// <param name="upassword"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static string MyHttpPost(string url, int Timeout, byte[] content, string uaccount, string upassword, ref string msg)
        {
            string result = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                //request.Headers["Content-Description"] = "Test";

                request.Timeout = Timeout;

                if (uaccount != "")
                {
                    request.Credentials = new NetworkCredential(uaccount, upassword);
                }

                #region 添加 Post 参数
                request.ContentLength = content.Length;

                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(content, 0, content.Length);
                    reqStream.Close();
                }
                #endregion

                using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream stream = resp.GetResponseStream())
                    {
                        //獲取響應内容
                        using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                        {
                            result = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = "";
                msg = ex.Message;
            }

            return result;
        }
    }
}
