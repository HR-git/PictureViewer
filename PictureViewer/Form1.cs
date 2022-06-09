using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            //[ファイルを開く]ダイアログを表示します。
            //ユーザーが[OK]をクリックした場合は、ユーザーが選択した画像を読み込みます。
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void cleatbutton_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            pictureBox1.Image = null;
        }

        private void backgroundbutton_Click(object sender, EventArgs e)
        {
            //カラーダイアログボックスを表示します。
            //ユーザーが[OK]をクリックした場合は、PictureBoxコントロールの背景をユーザーが選択した色に変更します。
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //ユーザーが[ストレッチ]チェックボックスを選択した場合は、
            //PictureBoxのSizeModeプロパティを[ストレッチ]に変更します。
            //ユーザーがチェックボックスをオフにした場合は、「通常」に変更します。
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
