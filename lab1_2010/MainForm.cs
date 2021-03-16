using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
/// <summary>
/// /dfdfmhm
/// </summary>
namespace lab1_2010
{
    public partial class MainForm : Form
    {
        int a = 177;
        private bool[,] binaryBitmapArray;
        private int[,] intermediateBitmapArray;
        private int[,] grayBitmapArray;
        Bitmap bitmap;

        public MainForm()
        {
            InitializeComponent();
        }

        private bool findRadius(int i, int j, int i1, int j1, int R)
        {
            if (j1 < 0 || i1 < 0 || i1 >= bitmap.Height || j1 >= bitmap.Width) return false;
            if (binaryBitmapArray[i, j] != binaryBitmapArray[i1, j1])
            {
                //ПРОТИВОПОЛОЖНЫЙ ПИКСЕЛЬ НАЙДЕН 
                if (binaryBitmapArray[i, j] == false)
                    intermediateBitmapArray[i, j] = -R;
                else
                    intermediateBitmapArray[i, j] = R;
                return true;
            }
            return false;
        }

        private int findMax(int[,] bitArray)
        {
            int width = bitArray.GetLength(0);
            int height = bitArray.GetLength(1);
            int max = bitArray[0, 0];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (bitArray[i, j] > max)
                        max = bitArray[i, j];
                }
            }
            return max;
        }

        private int findMin(int[,] bitArray)
        {
            int width = bitArray.GetLength(0);
            int height = bitArray.GetLength(1);
            int min = bitArray[0, 0];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (bitArray[i, j] < min)
                        min = bitArray[i, j];
                }
            }
            return min;
        }

        private int[,] convertBinToGray(int[,] bitArray1)
        {
            int width = bitArray1.GetLength(0);
            int height = bitArray1.GetLength(1);
            int[,] bitArray2 = new int[width, height];
            int min = findMin(bitArray1);
            int max = findMax(bitArray1);
            double interval = 255 / (max - min);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bitArray2[i, j] = 255 - (int)Math.Round(interval*(bitArray1[i,j] - min));
                }
            }
            return bitArray2;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            string fileName;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                //Image image = Bitmap.FromFile(fileName);
                bitmap = (Bitmap)Bitmap.FromFile(fileName);
                Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height, bitmap.PixelFormat);
                pictureBox1.Image = bitmap;
                pictureBox2.Image = newBitmap;
                binaryBitmapArray = new bool[bitmap.Width, bitmap.Height];
                intermediateBitmapArray = new int[bitmap.Width, bitmap.Height];
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                dataGridView3.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView2.Columns.Clear();
                dataGridView3.Columns.Clear();
                for (int i = 0; i < bitmap.Width; i++)
                {
                    dataGridView1.Columns.Add(i.ToString(), i.ToString());
                    dataGridView2.Columns.Add(i.ToString(), i.ToString());
                    dataGridView3.Columns.Add(i.ToString(), i.ToString());
                    dataGridView1.Columns[i].Width = 20;
                    dataGridView2.Columns[i].Width = 20;
                    dataGridView3.Columns[i].Width = 30;
                }
                dataGridView1.Rows.Add(bitmap.Height);
                dataGridView2.Rows.Add(bitmap.Height);
                dataGridView3.Rows.Add(bitmap.Height);
                for (int i = 0; i < bitmap.Height; i++)
                {
                    dataGridView1.Rows[i].HeaderCell.Value = i.ToString();
                    dataGridView2.Rows[i].HeaderCell.Value = i.ToString();
                    dataGridView3.Rows[i].HeaderCell.Value = i.ToString();
                }
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        Color pixel = bitmap.GetPixel(i, j);
                        binaryBitmapArray[i, j] = pixel.R == 0 && pixel.G == 0 && pixel.B == 0;
                        if(pixel.R == 0)
                            dataGridView1.Rows[j].Cells[i].Value = 1;
                        else
                            dataGridView1.Rows[j].Cells[i].Value = 0;
                        //bitmapTextBox.Text += "(" + pixel.A + " " + pixel.R + " " + pixel.G + " " + pixel.B + ") "; //bitArray[i, j].ToString();
                    }
                }

                Bitmap bitmap2 = new Bitmap(bitmap.Width, bitmap.Height);
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        int R = 1;                        
                        while (intermediateBitmapArray[i, j] == 0)
                        {
                            int i1, j1;
                            i1 = i + R;
                            for (j1 = j - R; j1 <= j + R; j1++)
                            {
                                   if (findRadius(i, j, i1, j1, R)) {
                                        break;
                                   }
                            }

                            j1 = j + R;
                            for (i1 = i - R + 1; i1 < i + R; i1++)
                            {
                                if (findRadius(i, j, i1, j1, R))
                                {
                                    break;
                                }
                            }

                            i1 = i - R;
                            for (j1 = j - R; j1 <= j + R; j1++)
                            {
                                if (findRadius(i, j, i1, j1, R))
                                {
                                    break;
                                }
                            }

                            j1 = j - R;
                            for (i1 = i - R + 1; i1 < i + R; i1++)
                            {
                                if (findRadius(i, j, i1, j1, R))
                                {
                                    break;
                                }
                            }
                            R++;
                            
                        }
                        dataGridView2.Rows[j].Cells[i].Value = intermediateBitmapArray[i, j];
                        grayBitmapArray = convertBinToGray(intermediateBitmapArray);
                        bitmap2.SetPixel(i, j, Color.FromArgb(grayBitmapArray[i, j], grayBitmapArray[i, j], grayBitmapArray[i, j]));
                    }
                }
                grayBitmapArray = convertBinToGray(intermediateBitmapArray);
                

                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        dataGridView3.Rows[j].Cells[i].Value = grayBitmapArray[i, j];
                        bitmap2.SetPixel(i, j, Color.FromArgb(grayBitmapArray[i, j], grayBitmapArray[i, j], grayBitmapArray[i, j]));
                    }
                }
                pictureBox2.Image = bitmap2;
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox2.Image.Save(saveFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }                
            }
        }

        private Bitmap CreateNonIndexedImage(Image src)
        {
            Bitmap newBmp = new Bitmap(src.Width, src.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics gfx = Graphics.FromImage(newBmp))
            {
                gfx.DrawImage(src, 0, 0);
            }
            return newBmp;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Bitmap bmp = CreateNonIndexedImage(pictureBox1.Image);
            if(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) == 0)
                bmp.SetPixel(e.ColumnIndex, e.RowIndex, Color.White);
            else
                bmp.SetPixel(e.ColumnIndex, e.RowIndex, Color.Black);
            pictureBox1.Image = bmp;
        }

        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Bitmap bmp = CreateNonIndexedImage(pictureBox2.Image);
            int value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            bmp.SetPixel(e.ColumnIndex, e.RowIndex, Color.FromArgb(value, value, value));
            pictureBox2.Image = bmp;
        }

        private void saveBinButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // binary
            Series binGistogramm = new Series("binary");
            binGistogramm.ChartType = SeriesChartType.Column;
            int numberOf1 = 0;
            int numberOf0 = 0;
            
            foreach(bool pixelColor in binaryBitmapArray)
            {
                if (pixelColor)
                    numberOf1++;
                else
                    numberOf0++;
            }
            binGistogramm.Points.AddXY(0, numberOf0);
            binGistogramm.Points.AddXY(1, numberOf1);
            binChart.Series.Clear();
            binChart.Series.Add(binGistogramm);

            // gray
            Series grayGistogramm = new Series("gray");
            grayGistogramm.ChartType = SeriesChartType.Column;

            //List<int> valuesInGrayBitmap = getValuesInGrayBitmap(grayBitmapArray);
            Dictionary<int, int> numberOfColors = getNumberOfColorsInGrayBitmap(grayBitmapArray);
            foreach(int key in numberOfColors.Keys)
            {
                grayGistogramm.Points.AddXY(key, numberOfColors[key]);
            }
            grayChart.Series.Clear();
            grayChart.Series.Add(grayGistogramm);
        }


        private List<int> getValuesInGrayBitmap(int[,] bmp)
        {
            List<int> valuesInGrayBitmap = new List<int>();
            foreach (int pixelColor in bmp)
            {
                if (!valuesInGrayBitmap.Contains(pixelColor))
                {
                    valuesInGrayBitmap.Add(pixelColor);
                }
            }
            return valuesInGrayBitmap;
        }


        private Dictionary<int, int> getNumberOfColorsInGrayBitmap(int[,] bmp)
        {
            Dictionary<int, int> numberOfColors = new Dictionary<int, int>();
            foreach (int pixelColor in bmp)
            {
                if (!numberOfColors.ContainsKey(pixelColor))
                {
                    numberOfColors.Add(pixelColor, 1);
                }
                else
                {
                    numberOfColors[pixelColor]++;
                }
            }
            return numberOfColors;
        }

        private void openGray_Click(object sender, EventArgs e)
        {
            string fileName;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                //Image image = Bitmap.FromFile(fileName);
                bitmap = (Bitmap)Bitmap.FromFile(fileName);
                pictureBox3.Image = bitmap;
                pictureBox4.Image = binarize(bitmap);
            }
        }

        private Bitmap binarize(Bitmap grayImage) 
        {
            Bitmap binBitmap = new Bitmap(grayImage.Width, grayImage.Height);
            int[,] grayBitArray = new int[grayImage.Width, grayImage.Height];
            byte[,] binBitArray = new byte[grayImage.Width, grayImage.Height];
            int sum = 0;
            for (int i = 0; i < grayImage.Width; i++)
            {
                for (int j = 0; j < grayImage.Height; j++)
                {
                    Color pixel = grayImage.GetPixel(i, j);
                    grayBitArray[i, j] = pixel.R;
                    sum += grayBitArray[i, j];
                }
            }
            int avg = sum / (grayImage.Width * grayImage.Height);
            int borderlineValue = 255 - avg;
            for (int i = 0; i < grayImage.Width; i++)
            {
                for (int j = 0; j < grayImage.Height; j++)
                {
                    if(borderlineValue <= grayBitArray[i, j])
                        binBitArray[i, j] = 1;
                    else
                        binBitArray[i, j] = 0;
                    binBitmap.SetPixel(i, j, Color.FromArgb(binBitArray[i, j], binBitArray[i, j], binBitArray[i, j]));
                }
            }
            
            return binBitmap;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox4.Image.Save(saveFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }
    }
}
