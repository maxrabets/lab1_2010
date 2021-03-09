using System;
using System.Drawing;
using System.Windows.Forms;
/// <summary>
/// /dfdfmhm
/// </summary>
namespace lab1_2010
{
    public partial class MainForm : Form
    {
        int a = 177;
        private bool[,] bitArray;
        private int[,] bitArray2;
        private int[,] bitArray3;
        Bitmap bitmap;

        public MainForm()
        {
            InitializeComponent();
        }

        private bool findRadius(int i, int j, int i1, int j1, int R)
        {
            if (j1 < 0 || i1 < 0 || i1 >= bitmap.Height || j1 >= bitmap.Width) return false;
            if (bitArray[i, j] != bitArray[i1, j1])
            {
                //ПРОТИВОПОЛОЖНЫЙ ПИКСЕЛЬ НАЙДЕН 
                if (bitArray[i, j] == false)
                    bitArray2[i, j] = -R;
                else
                    bitArray2[i, j] = R;
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
                bitArray = new bool[bitmap.Width, bitmap.Height];
                bitArray2 = new int[bitmap.Width, bitmap.Height];
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                dataGridView3.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView2.Columns.Clear();
                dataGridView3.Columns.Clear();
                for (int i = 0; i < bitmap.Height; i++)
                {
                    dataGridView1.Columns.Add(i.ToString(), i.ToString());
                    dataGridView2.Columns.Add(i.ToString(), i.ToString());
                    dataGridView3.Columns.Add(i.ToString(), i.ToString());
                    dataGridView1.Columns[i].Width = 20;
                    dataGridView2.Columns[i].Width = 20;
                    dataGridView3.Columns[i].Width = 20;
                }
                dataGridView1.Rows.Add(bitmap.Height);
                dataGridView2.Rows.Add(bitmap.Height);
                dataGridView3.Rows.Add(bitmap.Height);
                
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        Color pixel = bitmap.GetPixel(i, j);
                        bitArray[i, j] = pixel.R == 0 && pixel.G == 0 && pixel.B == 0;
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
                        while (bitArray2[i, j] == 0)
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
                        dataGridView2.Rows[j].Cells[i].Value = bitArray2[i, j];
                        bitArray3 = convertBinToGray(bitArray2);
                        bitmap2.SetPixel(i, j, Color.FromArgb(bitArray3[i, j], bitArray3[i, j], bitArray3[i, j]));
                    }
                }
                bitArray3 = convertBinToGray(bitArray2);
                

                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        dataGridView3.Rows[j].Cells[i].Value = bitArray3[i, j];
                        bitmap2.SetPixel(i, j, Color.FromArgb(bitArray3[i, j], bitArray3[i, j], bitArray3[i, j]));
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
            bmp.
        }
    }
}
