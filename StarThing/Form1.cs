using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarThing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Makes the Star that Changes Size and Position
        /// </summary>
        public void Star(float x, float y, float size)
        {
            try
            {
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(Color.DarkGreen, 3);

                g.Clear(Color.White);

                //Star
                g.DrawLine(p, (4 / 5 * size + x), (75 / 5 * size + y), (61 / 5 * size + x), (119 / 5 * size + y));
                g.DrawLine(p, (61 / 5 * size + x), (119 / 5 * size + y), (38 / 5 * size + x), (193 / 5 * size + y));
                g.DrawLine(p, (38 / 5 * size + x), (193 / 5 * size + y), (101 / 5 * size + x), (148 / 5 * size + y));
                g.DrawLine(p, (101 / 5 * size + x), (148 / 5 * size + y), (162 / 5 * size + x), (193 / 5 * size + y));
                g.DrawLine(p, (162 / 5 * size + x), (193 / 5 * size + y), (141 / 5 * size + x), (119 / 5 * size + y));
                g.DrawLine(p, (141 / 5 * size + x), (119 / 5 * size + y), (201 / 5 * size + x), (75 / 5 * size + y));
                g.DrawLine(p, (201 / 5 * size + x), (75 / 5 * size + y), (124 / 5 * size + x), (75 / 5 * size + y));
                g.DrawLine(p, (124 / 5 * size + x), (76 / 5 * size + y), (101 / 5 * size + x), (2 / 5 * size + y));              
                g.DrawLine(p, (101 / 5 * size + x), (2 / 5 * size + y), (77 / 5 * size + x), (77 / 5 * size + y));
                g.DrawLine(p, (77 / 5 * size + x), (77 / 5 * size + y), (4 / 5 * size + x), (75 / 5 * size + y));
            }
            catch
            {

            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            float x = Convert.ToSingle(xTextBox.Text);
            float y = Convert.ToSingle(yTextBox.Text);
            float size = Convert.ToSingle(sizeTextBox.Text);
            Star(x, y, size);
        }
    }
}
