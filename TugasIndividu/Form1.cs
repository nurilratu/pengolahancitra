using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace TugasIndividu
{
    public partial class Form1 : Form
    {
        Bitmap originalBitmap;
        Bitmap greyscaleBitmap;
        Bitmap resultBitmap;
        String status = null;
        Boolean isGreyScale = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            originalBitmap = isGreyScale
                             ? greyscaleBitmap
                             : originalBitmap;
            
            resultBitmap = status == null
                           ? new Bitmap(originalBitmap)
                           : new Bitmap(resultBitmap);

            string select = (string)comboBox1.SelectedItem;
            if (select == "Flip Horizontal")
            {
                //resultBitmap = new Bitmap(originalBitmap);
                for (int x = 0; x < originalBitmap.Width; x++)
                    for (int y = 0; y < originalBitmap.Height; y++)
                    {
                        Color w = originalBitmap.GetPixel(x, y);
                        resultBitmap.SetPixel(originalBitmap.Width - 1 - x, y, w);
                    }
                pictureBox3.Image = resultBitmap;
            }
            if (select == "Flip Vertikal")
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    for (int y = 0; y < originalBitmap.Height; y++)
                    {
                        Color w = originalBitmap.GetPixel(x, y);
                        resultBitmap.SetPixel(x, originalBitmap.Height - 1 - y, w);
                    }
                    pictureBox3.Image = resultBitmap;
                }
            }
            if (select == "Rotate 90")
            {
                for (int x = 0; x < originalBitmap.Height; x++)
                {
                    for (int y = 0; y < originalBitmap.Width; y++)
                    {
                        Color w = originalBitmap.GetPixel(y, originalBitmap.Height - 1 - x);
                        resultBitmap.SetPixel(x, y, w);
                    }
                    pictureBox3.Image = resultBitmap;
                }
            }
            if (select == "Rotate 180")
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                    for (int y = 0; y < originalBitmap.Height; y++)
                    {
                        Color w = originalBitmap.GetPixel(x, y);
                        resultBitmap.SetPixel(originalBitmap.Width - 1 - x, originalBitmap.Height - 1 - y, w);
                    }
                pictureBox3.Image = resultBitmap;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            originalBitmap = isGreyScale
                             ? greyscaleBitmap
                             : originalBitmap;
            
            resultBitmap = status == null
                           ? new Bitmap(originalBitmap)
                           : new Bitmap(resultBitmap);

            string select = (string)comboBox2.SelectedItem;
            if (select == "Layer Red")
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                    for (int y = 0; y < originalBitmap.Height; y++)
                    {
                        Color w = originalBitmap.GetPixel(x, y);
                        int wr = w.R;
                        Color new_w = Color.FromArgb(wr, wr, wr);
                        resultBitmap.SetPixel(x, y, new_w);
                    }
                pictureBox3.Image = resultBitmap;
            }
            if (select == "Layer Green")
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                    for (int y = 0; y < originalBitmap.Height; y++)
                    {
                        Color w = originalBitmap.GetPixel(x, y);
                        int wg = w.G;
                        Color new_w = Color.FromArgb(wg, wg, wg);
                        resultBitmap.SetPixel(x, y, new_w);
                    }
                pictureBox3.Image = resultBitmap;
            }
            if (select == "Layer Blue")
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                    for (int y = 0; y < originalBitmap.Height; y++)
                    {
                        Color w = originalBitmap.GetPixel(x, y);
                        int wb = w.B;
                        Color new_w = Color.FromArgb(wb, wb, wb);
                        resultBitmap.SetPixel(x, y, new_w);
                    }
                pictureBox3.Image = resultBitmap;
            }
            if (select == "Greyscale Red")
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                    for (int y = 0; y < originalBitmap.Height; y++)
                    {
                        Color w = originalBitmap.GetPixel(x, y);
                        int wr = w.R;
                        Color new_w = Color.FromArgb(wr, wr, wr);
                        resultBitmap.SetPixel(x, y, new_w);
                    }
                pictureBox3.Image = resultBitmap;
            }
            if (select == "Greyscale Green")
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                    for (int y = 0; y < originalBitmap.Height; y++)
                    {
                        Color w = originalBitmap.GetPixel(x, y);
                        int wg = w.G;
                        Color new_w = Color.FromArgb(wg, wg, wg);
                        resultBitmap.SetPixel(x, y, new_w);
                    }
                pictureBox3.Image = resultBitmap;
            }
            if (select == "Greyscale Blue")
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                    for (int y = 0; y < originalBitmap.Height; y++)
                    {
                        Color w = originalBitmap.GetPixel(x, y);
                        int wb = w.B;
                        Color new_w = Color.FromArgb(wb, wb, wb);
                        resultBitmap.SetPixel(x, y, new_w);
                    }
                pictureBox3.Image = resultBitmap;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Load
        private void button1_Click(object sender, EventArgs e)
        {
                DialogResult d = openFileDialog1.ShowDialog();

                if (d == DialogResult.OK)
                {
                    originalBitmap = new Bitmap(openFileDialog1.FileName);
                    pictureBox1.Image = originalBitmap;
                }

                greyscaleBitmap = new Bitmap(originalBitmap);

                for (int x = 0; x < greyscaleBitmap.Width; x++)
                    for (int y = 0; y < greyscaleBitmap.Height; y++)
                    {
                        Color w = greyscaleBitmap.GetPixel(x, y);
                        int xg = (int)((w.R + w.G + w.B) / 3);
                        Color c = Color.FromArgb(xg, xg, xg);
                        greyscaleBitmap.SetPixel(x, y, c);
                    }

                pictureBox2.Image = greyscaleBitmap;
        }


        //Auto Level
        private void button5_Click(object sender, EventArgs e)
        {
            originalBitmap = isGreyScale
                             ? greyscaleBitmap
                             : originalBitmap;
            
            resultBitmap = status == null
                           ? new Bitmap(originalBitmap)
                           : new Bitmap(resultBitmap);

            int rmin = 255;
            int gmin = 255;
            int bmin = 255;
            int rmax = 0;
            int gmax = 0;
            int bmax = 0;
            for (int x = 0; x < originalBitmap.Width; x++)
                for (int y = 0; y < originalBitmap.Height; y++)
                {
                    Color w = originalBitmap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    if (r < rmin) rmin = r;
                    if (r > rmax) rmax = r;
                    if (g < gmin) gmin = g;
                    if (g > gmax) gmax = g;
                    if (b < bmin) bmin = b;
                    if (b > bmax) bmax = b;
                }
            for (int x = 0; x < originalBitmap.Width; x++)
                for (int y = 0; y < originalBitmap.Height; y++)
                {
                    Color w = originalBitmap.GetPixel(x, y);
                    int r = w.R;
                    int g = w.G;
                    int b = w.B;
                    int rbaru = (int)(255 * (r - rmin) / (rmax - rmin));
                    int gbaru = (int)(255 * (g - gmin) / (gmax - gmin));
                    int bbaru = (int)(255 * (b - bmin) / (bmax - bmin));
                    Color wb = Color.FromArgb(rbaru, gbaru, bbaru);
                    originalBitmap.SetPixel(x, y, wb);
                }
            pictureBox3.Image = resultBitmap;
        }

        //Invers
        private void button6_Click(object sender, EventArgs e)
        {
            originalBitmap = isGreyScale
                             ? greyscaleBitmap
                             : originalBitmap;
            
            resultBitmap = status == null
                           ? new Bitmap(originalBitmap)
                           : new Bitmap(resultBitmap);

            for (int x = 0; x < originalBitmap.Width; x++)
                for (int y = 0; y < originalBitmap.Height; y++)
                {
                    Color w = originalBitmap.GetPixel(x, y);
                    int r = (int)(255 - w.R);
                    int g = (int)(255 - w.G);
                    int b = (int)(255 - w.B);
                    Color wb = Color.FromArgb(r, g, b);
                    resultBitmap.SetPixel(x, y, wb);
                }
            status = "invers";

            pictureBox3.Image = resultBitmap;
        }

        //Noise Gaussian
        private void button7_Click(object sender, EventArgs e)
        {
            originalBitmap = isGreyScale
                             ? greyscaleBitmap
                             : originalBitmap;
            
            resultBitmap = status == null
                           ? new Bitmap(originalBitmap)
                           : new Bitmap(resultBitmap);

            Random r = new Random();
            Color wb;
            for (int x = 0; x < resultBitmap.Width; x++)
                for (int y = 0; y < resultBitmap.Height; y++)
                {
                    int p = r.Next(0, 100);
                    Color w = resultBitmap.GetPixel(x, y);
                    wb = w; if (p < 20)
                    {
                        int nr = r.Next(0, 200);
                        int rb = w.R + nr - 100;
                        if (rb < 0) rb = 0;
                        if (rb > 255) rb = 255;
                        int gb = w.G + nr - 100;
                        if (gb < 0) gb = 0;
                        if (gb > 255) gb = 255;
                        int bb = w.B + nr - 100;
                        if (bb < 0) bb = 0;
                        if (bb > 255) bb = 255;
                        wb = Color.FromArgb(rb, gb, bb);
                    }
                    resultBitmap.SetPixel(x, y, wb);
                }

            status = "noise gaussian";

            pictureBox3.Image = resultBitmap;
        }
                
        private void button10_Click(object sender, EventArgs e)
        {
            originalBitmap = isGreyScale
                             ? greyscaleBitmap
                             : originalBitmap;
            
            resultBitmap = status == null
                           ? new Bitmap(originalBitmap)
                           : new Bitmap(resultBitmap);

            //resultBitmap = new Bitmap(originalBitmap);
            for (int x = 1; x < originalBitmap.Width - 1; x++)
                for (int y = 1; y < originalBitmap.Height - 1; y++)
                {
                    Color w = originalBitmap.GetPixel(x, y);
                    int xg = w.R;
                    Color w1 = originalBitmap.GetPixel(x - 1, y - 1);
                    Color w2 = originalBitmap.GetPixel(x - 1, y);
                    Color w3 = originalBitmap.GetPixel(x - 1, y + 1);
                    Color w4 = originalBitmap.GetPixel(x, y - 1);
                    Color w5 = originalBitmap.GetPixel(x, y);
                    Color w6 = originalBitmap.GetPixel(x, y + 1);
                    Color w7 = originalBitmap.GetPixel(x + 1, y - 1);
                    Color w8 = originalBitmap.GetPixel(x + 1, y);
                    Color w9 = originalBitmap.GetPixel(x + 1, y + 1);
                    int x1 = w1.R;
                    int x2 = w2.R;
                    int x3 = w3.R;
                    int x4 = w4.R;
                    int x5 = w5.R;
                    int x6 = w6.R;
                    int x7 = w7.R;
                    int x8 = w8.R;
                    int x9 = w9.R;
                    int xt1 = (int)((x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9) / 9);
                    int xt2 = (int)(-x1 - 2 * x2 - x3 + x7 + 2 * x8 + x9);
                    int xt3 = (int)(-x1 - 2 * x4 - x7 + x3 + 2 * x6 + x9);
                    int xb = (int)(xt1 + xt2 + xt3); if (xb < 0) xb = -xb;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    resultBitmap.SetPixel(x, y, wb);
                }
            pictureBox3.Image = resultBitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                isGreyScale = true;
            }
            else
            {
                isGreyScale = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            greyscaleBitmap = new Bitmap(originalBitmap);

            for (int x = 0; x < greyscaleBitmap.Width; x++)
                for (int y = 0; y < greyscaleBitmap.Height; y++)
                {
                    Color w = greyscaleBitmap.GetPixel(x, y);
                    int xg = (int)((w.R + w.G + w.B) / 3);
                    Color c = Color.FromArgb(xg, xg, xg);
                    greyscaleBitmap.SetPixel(x, y, c);
                }

            pictureBox3.Image = greyscaleBitmap;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            float[] h = new float[256];
            float[] c = new float[256];
            int i = 0;
            originalBitmap = isGreyScale
                             ? greyscaleBitmap
                             : originalBitmap;
            
            resultBitmap = status == null
                           ? new Bitmap(originalBitmap)
                           : new Bitmap(resultBitmap);

            string select = (string)comboBox6.SelectedItem;
            if (select == "Histogram")
            {
                for (i = 0; i < 256; i++) h[i] = 0;
                for (int x = 0; x < originalBitmap.Width; x++)
                    for (int y = 0; y < originalBitmap.Height; y++)
                    {
                        Color w = originalBitmap.GetPixel(x, y);
                        int xg = (int)((w.R + w.G + w.B) / 3);
                        h[xg] = h[xg] + 1;
                    }
                    for (i = 0; i < 256; i++)
                    {
                        chart1.Series["Series1"].Points.AddXY(i, h[i]);
                    }
                if (select == "Histogram Equalization")
                {
                    for (i = 0; i < 256; i++)
                    {
                        for (int x = 0; x < originalBitmap.Width; x++)
                            for (int y = 0; y < originalBitmap.Height; y++)
                            {
                                Color w = originalBitmap.GetPixel(x, y); 
                                int xg = (int)((w.R + w.G + w.B) / 3); 
                                h[xg] = h[xg] + 1; 
                            }
                        c[0] = h[0]; 
                        for (i = 1; i < 256; i++) 
                            c[i] = c[i - 1] + h[i];
                        originalBitmap = new Bitmap(originalBitmap);
                        int nx = originalBitmap.Width;
                        int ny = originalBitmap.Height;
                        for (int x = 0; x < originalBitmap.Width; x++)
                            for (int y = 0; y < originalBitmap.Height; y++)
                            {
                                Color w = originalBitmap.GetPixel(x, y); 
                                int xg = (int)((w.R + w.G + w.B) / 3);
                                int xb = (int)(255 * c[xg] / nx / ny);
                                h[xb] = h[xb] + 1; 
                                Color wb = Color.FromArgb(xb, xb, xb);
                                originalBitmap.SetPixel(x, y, wb); 
                            }
                        pictureBox1.Image = originalBitmap; 
                        for (i = 0; i < 256; i++)
                        {
                            chart1.Series["Series1"].Points.AddXY(i, h[i]);
                        }
                    }
                }
                if (select == "CDF")
                {
                    for (i = 0; i < 256; i++) h[i] = 0;
                    for (int x = 0; x < originalBitmap.Width; x++)
                        for (int y = 0; y < originalBitmap.Height; y++)
                        {
                            Color w = originalBitmap.GetPixel(x, y); 
                            int xg = (int)((w.R + w.G + w.B) / 3); 
                            h[xg] = h[xg] + 1; 
                        }
                    c[0] = h[0]; 
                    for (i = 1; i < 256; i++) c[i] = c[i - 1] + h[i]; 
                    for (i = 0; i < 256; i++) 
                    {
                        chart1.Series["Series1"].Points.AddXY(i, c[i]); 
                    }
                }
                if (select == "PDF")
                {
                    int n = 0; 
                    for (i = 0; i < 256; i++) h[i] = 0;
                    for (int x = 0; x < originalBitmap.Width; x++)
                        for (int y = 0; y < originalBitmap.Height; y++)
                        {
                            Color w = originalBitmap.GetPixel(x, y); 
                            int xg = (int)((w.R + w.G + w.B) / 3); 
                            h[xg] = h[xg] + 1;
                            n += 1;
                        }
                    for (i = 0; i < 256; i++)
                        h[i] = h[i] / n; 
                    for (i = 0; i < 256; i++)
                    {
                        chart1.Series["Series1"].Points.AddXY(i, h[i]); 
                    }
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            originalBitmap = isGreyScale
                             ? greyscaleBitmap
                             : originalBitmap;
            
            resultBitmap = status == null
                           ? new Bitmap(originalBitmap)
                           : new Bitmap(resultBitmap);

            string select = (string) comboBox3.SelectedItem;
            if (select == "4 Node") { 
                float[] a= new float[5];
                a[1]=(float)0.2;
                a[2]=(float)0.2;
                a[3]=(float)0.2;             
                a[4]=(float)0.2;             
                a[0]=(float)0.2;             
                resultBitmap = new Bitmap(originalBitmap);
                for (int x = 1; x < originalBitmap.Width-1; x++)
                    for (int y = 1; y < originalBitmap.Height-1; y++) {
                        Color w1 = originalBitmap.GetPixel(x - 1, y);                     
                        Color w2 = originalBitmap.GetPixel(x + 1, y);                     
                        Color w3 = originalBitmap.GetPixel(x, y - 1); 
                        Color w4 = originalBitmap.GetPixel(x, y + 1);       
                        Color w = originalBitmap.GetPixel(x, y);
                        int x1 = w1.R;                  
                        int x2 = w2.R;
                        int x3 = w3.R; 
                        int x4 = w4.R;
                        int xg = w.R;  
                        int xb =  (int)(a[0]*xg);   
                        xb=(int)(xb+a[1]*x1+a[2]*x2+a[3]*x3+a[3]*x4);
                        if (xb < 0) xb = 0; 
                        if (xb > 255) xb = 255;
                        Color wb = Color.FromArgb(xb, xb, xb);
                        resultBitmap.SetPixel(x, y, wb);
                    } pictureBox3.Image = resultBitmap; 
            }
            if (select == "8 Node") { 
                float[] a= new float[10];
                a[1]=(float)0.1;
                a[2]=(float)0.1;
                a[3]=(float)0.1;
                a[4]=(float)0.1;
                a[5]=(float)0.2;
                a[6]=(float)0.1;
                a[7]=(float)0.1;
                a[8]=(float)0.1;
                a[9]=(float)0.1;
                resultBitmap = new Bitmap(originalBitmap);             
                for (int x = 1; x < originalBitmap.Width-1; x++)                 
                    for (int y = 1; y < originalBitmap.Height-1; y++) { 
                        Color w1 = originalBitmap.GetPixel(x-1, y-1);
                        Color w2 = originalBitmap.GetPixel(x-1, y);
                        Color w3 = originalBitmap.GetPixel(x-1, y+1);  
                        Color w4 = originalBitmap.GetPixel(x, y-1);
                        Color w5 = originalBitmap.GetPixel(x, y);   
                        Color w6 = originalBitmap.GetPixel(x, y+1);  
                        Color w7 = originalBitmap.GetPixel(x+1, y-1);           
                        Color w8 = originalBitmap.GetPixel(x+1, y);  
                        Color w9 = originalBitmap.GetPixel(x+1, y+1);            
                        int x1 = w1.R;           
                        int x2 = w2.R;           
                        int x3 = w3.R;            
                        int x4 = w4.R;              
                        int x5 = w5.R;                
                        int x6 = w6.R;           
                        int x7 = w7.R;           
                        int x8 = w8.R;           
                        int x9 = w9.R;           
                        int xb = (int)(a[1]*x1+a[2]*x2+a[3]*x3);  
                        xb=(int)(xb+a[4]*x4+a[5]*x5+a[6]*x6);      
                        xb=(int)(xb+a[7]*x7+a[8]*x8+a[9]*x9);      
                        if (xb < 0) xb = 0;  
                        if (xb > 255) xb = 255;    
                        Color wb = Color.FromArgb(xb, xb, xb);
                        originalBitmap.SetPixel(x, y, wb);
                    }
                pictureBox3.Image = resultBitmap; 
            }
            if (select == "F Sobel") {
                for (int x = 1; x < originalBitmap.Width - 1; x++)
                    for (int y = 1; y < originalBitmap.Height - 1; y++)
                    {
                        Color w1 = originalBitmap.GetPixel(x - 1, y - 1);
                        Color w2 = originalBitmap.GetPixel(x - 1, y);
                        Color w3 = originalBitmap.GetPixel(x - 1, y + 1);
                        Color w4 = originalBitmap.GetPixel(x, y - 1);
                        Color w5 = originalBitmap.GetPixel(x, y);
                        Color w6 = originalBitmap.GetPixel(x, y + 1);
                        Color w7 = originalBitmap.GetPixel(x + 1, y - 1);
                        Color w8 = originalBitmap.GetPixel(x + 1, y);
                        Color w9 = originalBitmap.GetPixel(x + 1, y + 1);

                        int x1 = w1.R;
                        int x2 = w2.R;
                        int x3 = w3.R;
                        int x4 = w4.R;
                        int x5 = w5.R;
                        int x6 = w6.R;
                        int x7 = w7.R;
                        int x8 = w8.R;
                        int x9 = w9.R;
                        int xh = (int)(-x1 - 2 * x4 - x7 + x3 + 2 * x6 + x9);
                        int xv = (int)(-x1 - 2 * x2 - x3 + x7 + 2 * x8 + x9);
                        int xb = (int)(xh + xv);
                        if (xb < 0) xb = -xb;
                        if (xb > 255) xb = 255;
                        Color wb = Color.FromArgb(xb, xb, xb);
                        resultBitmap.SetPixel(x, y, wb);
                    }
                pictureBox3.Image = resultBitmap;
            }
            if (select == "F Rata-rata") {
                pictureBox1.Image = originalBitmap;
                for (int x = 1; x < originalBitmap.Width - 1; x++)
                    for (int y = 1; y < originalBitmap.Height - 1; y++)
                    {
                        Color w1 = originalBitmap.GetPixel(x - 1, y - 1);
                        Color w2 = originalBitmap.GetPixel(x - 1, y);
                        Color w3 = originalBitmap.GetPixel(x - 1, y + 1);
                        Color w4 = originalBitmap.GetPixel(x, y - 1);
                        Color w5 = originalBitmap.GetPixel(x, y);
                        Color w6 = originalBitmap.GetPixel(x, y + 1);
                        Color w7 = originalBitmap.GetPixel(x + 1, y - 1);
                        Color w8 = originalBitmap.GetPixel(x + 1, y);
                        Color w9 = originalBitmap.GetPixel(x + 1, y + 1);
                        int r = (int)((w1.R + w2.R + w3.R + w4.R + w5.R + w6.R + w7.R + w8.R + w9.R) / 9);
                        int g = (int)((w1.G + w2.G + w3.G + w4.G + w5.G + w6.G + w7.G + w8.G + w9.G) / 9);
                        int b = (int)((w1.B + w2.B + w3.B + w4.B + w5.B + w6.B + w7.B + w8.B + w9.B) / 9);
                        Color wb = Color.FromArgb(r, g, b);
                        resultBitmap.SetPixel(x, y, wb);
                    }
                pictureBox3.Image = resultBitmap;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            originalBitmap = isGreyScale
                             ? greyscaleBitmap
                             : originalBitmap;
            
            resultBitmap = status == null
                           ? new Bitmap(originalBitmap)
                           : new Bitmap(resultBitmap);
 
            int contrast = (int)Convert.ToSingle(textBox2.Text);
            for (int x = 0; x < originalBitmap.Width; x++)
                for (int y = 0; y < originalBitmap.Height; y++) 
                {
                    Color w = originalBitmap.GetPixel(x, y); 
                    int xg = (int)((w.R + w.G + w.B) / 3);
                    int xc = (int)contrast * xg; 
                    if (xc > 255)
                    {
                        xc = 255;
                    }
                    else
                    {
                        xc = 0;
                    }
                    Color new_w = Color.FromArgb(xc, xc, xc);
                    resultBitmap.SetPixel(x, y, new_w); 
                }
            pictureBox3.Image = resultBitmap; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            originalBitmap = isGreyScale
                             ? greyscaleBitmap
                             : originalBitmap;

            resultBitmap = status == null
                           ? new Bitmap(originalBitmap)
                           : new Bitmap(resultBitmap);

            int brightness = Convert.ToInt16(textBox1.Text);
            for (int x = 0; x < originalBitmap.Width; x++)
                for (int y = 0; y < originalBitmap.Height; y++)
                {
                    Color w = originalBitmap.GetPixel(x, y); 
                    int xg = (int)((w.R + w.G + w.B) / 3);
                    int xb = xg + brightness; 
                    if (xb < 0) 
                    {
                        xb = xb * (-1);
                    }
                    Color new_w = Color.FromArgb(xb / 2, xb / 2, xb / 2);
                    resultBitmap.SetPixel(x, y, new_w); 
                }
            pictureBox3.Image = resultBitmap;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            originalBitmap = isGreyScale
                             ? greyscaleBitmap
                             : originalBitmap;
            
            resultBitmap = status == null
                           ? new Bitmap(originalBitmap)
                           : new Bitmap(resultBitmap);
            string select = (string)comboBox5.SelectedItem;
            if (select == "8") { 
                 for (int x = 0; x < originalBitmap.Width; x++)
                 for (int y = 0; y < originalBitmap.Height; y++) {
                     Color w = originalBitmap.GetPixel(x, y);
                     int r = w.R; 
                     int g = w.G;
                     int b = w.B;
                     int xg = (int)((r + g + b) / 3);
                     int xk = 8*(int)(xg/8);
                     Color wb = Color.FromArgb(xk, xk, xk);
                     resultBitmap.SetPixel(x, y, wb);
                 }
                pictureBox3.Image = resultBitmap; 
            }
            if (select == "16") { 
                for (int x = 0; x < originalBitmap.Width; x++)
                 for (int y = 0; y < originalBitmap.Height; y++) {
                     Color w = originalBitmap.GetPixel(x, y);
                     int r = w.R; 
                     int g = w.G;
                     int b = w.B;
                     int xg = (int)((r + g + b) / 3);
                     int xk = 16*(int)(xg/16);
                     Color wb = Color.FromArgb(xk, xk, xk);
                     resultBitmap.SetPixel(x, y, wb);
                 }
                pictureBox3.Image = resultBitmap; 
            }
            if (select == "32") { 
                 for (int x = 0; x < originalBitmap.Width; x++)
                 for (int y = 0; y < originalBitmap.Height; y++) {
                     Color w = originalBitmap.GetPixel(x, y);
                     int r = w.R; 
                     int g = w.G;
                     int b = w.B;
                     int xg = (int)((r + g + b) / 3);
                     int xk = 32*(int)(xg/32);
                     Color wb = Color.FromArgb(xk, xk, xk);
                     resultBitmap.SetPixel(x, y, wb);
                 }
                pictureBox3.Image = resultBitmap; 
            }
            if (select == "64") { 
                 for (int x = 0; x < originalBitmap.Width; x++)
                 for (int y = 0; y < originalBitmap.Height; y++) {
                     Color w = originalBitmap.GetPixel(x, y);
                     int r = w.R; 
                     int g = w.G;
                     int b = w.B;
                     int xg = (int)((r + g + b) / 3);
                     int xk = 64*(int)(xg/64);
                     Color wb = Color.FromArgb(xk, xk, xk);
                     resultBitmap.SetPixel(x, y, wb);
                 }
                pictureBox3.Image = resultBitmap; 
            }
        }
    }
}
