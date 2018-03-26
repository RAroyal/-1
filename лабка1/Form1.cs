using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace лабка1
{public partial class Form1 : Form
    {public Form1()
        { InitializeComponent();}
private void textBox1_Click_1(object sender, EventArgs e)
        { textBox1.Text = "номер 1";
          textBox1.BackColor = System.Drawing.Color.Gold; }
private void textBox2_Click(object sender, EventArgs e)
        { textBox2.Text = "номер 2";
           textBox2.BackColor = System.Drawing.Color.Gold;}
private void textBox3_Click(object sender, EventArgs e)
        {textBox3.Text = "номер 3";
         textBox3.BackColor = System.Drawing.Color.Gold;}
private void textBox4_Click(object sender, EventArgs e)
        {textBox4.Text = "номер 4";
         textBox4.BackColor = System.Drawing.Color.Gold;}
private void textBox5_Click(object sender, EventArgs e)
        { textBox5.Text = "номер 5";
          textBox5.BackColor = System.Drawing.Color.Gold;}
private void textBox6_Click(object sender, EventArgs e)
        {textBox6.Text = "номер 6";
         textBox6.BackColor = System.Drawing.Color.Gold;}
private void textBox7_Click(object sender, EventArgs e)
        {textBox7.Text = "номер 7";
         textBox7.BackColor = System.Drawing.Color.Gold;}
private void textBox8_Click(object sender, EventArgs e)
        {textBox8.Text = "номер 8";
         textBox8.BackColor = System.Drawing.Color.Gold;}
private void textBox9_Click(object sender, EventArgs e)
        {textBox9.Text = "номер 9";
         textBox9.BackColor = System.Drawing.Color.Gold;}






private void Form1_Resize(object sender, EventArgs e)
        {Control control = (Control)sender;
 if (control.Size.Height != control.Size.Width)
            { control.Size = new Size(control.Size.Width, control.Size.Width);
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";
                textBox7.Text = ""; textBox8.Text = ""; textBox9.Text = "";
                textBox1.BackColor = System.Drawing.Color.White;
                textBox2.BackColor = System.Drawing.Color.White;
                textBox3.BackColor = System.Drawing.Color.White;
                textBox4.BackColor = System.Drawing.Color.White;
                textBox5.BackColor = System.Drawing.Color.White;
                textBox6.BackColor = System.Drawing.Color.White;
                textBox7.BackColor = System.Drawing.Color.White;
                textBox8.BackColor = System.Drawing.Color.White;
                textBox9.BackColor = System.Drawing.Color.White;
                textBox10.Text = "";
                textBox10.BackColor = System.Drawing.Color.White;}}



private void textBox10_Click(object sender, EventArgs e)
        {textBox10.Text = "Dana";
         textBox10.BackColor = System.Drawing.Color.Green;}}}