using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

////////https://qiita.com/siy1121/items/aee3ce1fff6e83e33b22

namespace RPA01
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ScriptOptions options = ScriptOptions.Default
                    .WithImports("System", "System.Windows.Forms", "System.Threading")
                    .WithReferences(Assembly.GetAssembly(typeof(System.Windows.Forms.MessageBox)));
                var script = CSharpScript.Create(textBox1.Text, options);
                script.RunAsync();
            }
            catch (CompilationErrorException ex)
            {
                MessageBox.Show(ex.Message, "コンパイルエラー");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Environment.NewLine;
            textBox1.Text = textBox1.Text + "System.Diagnostics.Process.Start(\"https://www.google.com/\");";
            textBox1.Text = textBox1.Text + "Thread.Sleep(" + "1000" + ");";


            TextBox tb = new TextBox();
            tb.Left = 445;
            tb.Top = GlobalVar.GlobalValue;
            
            tb.Width = 180;
            tb.Height = 24;
            tb.Text = button2.Text;
            tb.BackColor = button2.BackColor;
            GlobalVar.GlobalValue = GlobalVar.GlobalValue + tb.Height;
            this.Controls.Add(tb);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string n = numericUpDown1.Value.ToString();
            textBox1.Text = textBox1.Text + Environment.NewLine;
            textBox1.Text = textBox1.Text + "Thread.Sleep(" + n + "000" + ");";


            TextBox tb = new TextBox();
            tb.Left = 445;
            tb.Top = GlobalVar.GlobalValue;
            
            tb.Width = 180;
            tb.Height = 24;
            tb.Text = button3.Text;
            tb.BackColor = button3.BackColor;
            GlobalVar.GlobalValue = GlobalVar.GlobalValue + tb.Height;
            this.Controls.Add(tb);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string s = textBox3.Text;
            textBox1.Text = textBox1.Text + Environment.NewLine;
            textBox1.Text = textBox1.Text + "SendKeys.Send(\"" + s +  "\");";
            textBox1.Text = textBox1.Text + "Thread.Sleep(" + "1000" + ");";



            TextBox tb = new TextBox();
            tb.Left = 445;
            tb.Top = GlobalVar.GlobalValue;
            
            tb.Width = 180;
            tb.Height = 24;
            tb.Text = button4.Text + s;
            tb.BackColor = button4.BackColor;
            GlobalVar.GlobalValue = GlobalVar.GlobalValue + tb.Height;
            this.Controls.Add(tb);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Environment.NewLine;
            textBox1.Text = textBox1.Text + "SendKeys.Send(\"{ENTER}\");";
            textBox1.Text = textBox1.Text + "Thread.Sleep(" + "1000" + ");";


            TextBox tb = new TextBox();
            tb.Left = 445;
            tb.Top = GlobalVar.GlobalValue;
            
            tb.Width = 180;
            tb.Height = 24;
            tb.Text = button5.Text;
            tb.BackColor = button5.BackColor;
            GlobalVar.GlobalValue = GlobalVar.GlobalValue + tb.Height;
            this.Controls.Add(tb);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Environment.NewLine;
            textBox1.Text = textBox1.Text + "SendKeys.Send(\"{TAB}\");";
            textBox1.Text = textBox1.Text + "Thread.Sleep(" + "1000" + ");";


            TextBox tb = new TextBox();
            tb.Left = 445;
            tb.Top = GlobalVar.GlobalValue;
           
            tb.Width = 180;
            tb.Height = 24;
            tb.Text = button6.Text;
            tb.BackColor = button6.BackColor;
            GlobalVar.GlobalValue = GlobalVar.GlobalValue + tb.Height;
            this.Controls.Add(tb);
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string n = numericUpDown1.Value.ToString();
            textBox1.Text = textBox1.Text + Environment.NewLine;
            button3.Text = n + "秒休む";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string s = textBox2.Text;
            textBox1.Text = textBox1.Text + Environment.NewLine;
            textBox1.Text = textBox1.Text + "System.Diagnostics.Process p = System.Diagnostics.Process.Start(@\"" + s + "\");";
            textBox1.Text = textBox1.Text + "Thread.Sleep(" + "3000" + ");";


            TextBox tb = new TextBox();
            tb.Left = 445;
            tb.Top = GlobalVar.GlobalValue;
            
            tb.Width = 180;
            tb.Height = 24;
            tb.Text = button8.Text + s;
            tb.BackColor = button8.BackColor;
            GlobalVar.GlobalValue = GlobalVar.GlobalValue + tb.Height;
            this.Controls.Add(tb);
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Visible) textBox1.Visible = false;
            else textBox1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.ControlBox = false;
            GlobalVar.GlobalValue = 82;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
