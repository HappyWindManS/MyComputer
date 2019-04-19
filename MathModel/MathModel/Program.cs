using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathModel
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        #region
        //图片转换为二进制流        
        public void PictureToBinaryStream()
        {            //获取当前程序运行路径           
            string path = Application.StartupPath;
            //拼接成测试图片路径            
            string fullPath = path + "\\images\\test.png";
            //初始化类            
            Bitmap bmp = new Bitmap(Image.FromFile(fullPath));
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            ms.Flush();
            //将二进制数据存到byte数字中            
            byte[] bmpBytes = ms.ToArray();
            // richTextBox1.Text = Convert.ToBase64String(bmpBytes);            
            foreach (var item in bmpBytes)
            {
                richTextBox1.Text += item;
            }
            pictureBox1.Image = Image.FromStream(new MemoryStream(bmpBytes));
        }
        #endregion
        #region
        //二进制流转换成图片        
        public void BinaryStreamToPicture()
        {
            string url = @"http://php.weather.sina.com.cn/images/yb3/78_78/duoyun_0.png";
            WebClient client = new WebClient();
            byte[] pageData = client.DownloadData(url);
            //将二进制流数据转换为图片            
            pictureBox1.Image = Image.FromStream(new MemoryStream(pageData));
            Bitmap bmp = new Bitmap(new MemoryStream(pageData));
            string path = Application.StartupPath;
            string fullPath = path + "\\images\\"+ Guid.NewGuid().ToString()+".png";
            richTextBox1.Text = fullPath;
            bmp.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);
        }        
        #endregion

    }
}
