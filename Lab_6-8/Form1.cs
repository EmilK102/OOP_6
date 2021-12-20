using System;
using System.Windows.Forms;

namespace Lab_6_8
{
    public partial class Form1 : Form
    {
        MyStorage storage;
        PaintBox _paintBox;
        public Form1()
        {
            InitializeComponent();
            storage = new MyStorage(50);
            _paintBox = new PaintBox(paintBox.Width, paintBox.Height);
            paintBox.Image = _paintBox.GetBitmap();
            KeyUp += new KeyEventHandler(KeyDownEvent);
        }

        private void paintBox_MouseClick(object sender, MouseEventArgs e)
        {
            storage.MouseAction(e.X, e.Y, _paintBox.GetGraphics(), e.Button, comboBox1.Text);
            UpdateForm();
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            storage.ButtonAction(e.KeyCode);
            UpdateForm();
        }
        
        private void UpdateForm()
        {
            _paintBox.ClearBox();
            for (int i = 0; i < storage.getCount(); i++)
            {
                if (storage.checkObject(i))
                {
                    storage.getObject(i).Draw();
                }
            }
            paintBox.Image = _paintBox.GetBitmap();
        }

    }
}
