using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RPA02
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ScriptOptions options = ScriptOptions.Default
                    .WithImports("System", "System.Windows.Forms", "System.Threading", "System.Diagnostics", "System.Diagnostics.Process")
                    //.WithImports("System",  "System.Threading", "System.Diagnostics", "System.Diagnostics.Process", "System.Windows.Input")
                    .WithReferences(Assembly.GetAssembly(typeof(System.Windows.MessageBox)));
                var script = CSharpScript.Create(ScriptRobot.Text, options);
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ScriptRobot.Text = ScriptRobot.Text + Environment.NewLine;
            ScriptRobot.Text = ScriptRobot.Text + "System.Diagnostics.Process.Start(\"https://www.google.com/\");";
            ScriptRobot.Text = ScriptRobot.Text + Environment.NewLine;
            ScriptRobot.Text = ScriptRobot.Text + "Thread.Sleep(" + "1000" + ");";
        }

        private void ScriptRobot_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string s = InputKeyText.Text;
            ScriptRobot.Text = ScriptRobot.Text + Environment.NewLine;
            ScriptRobot.Text = ScriptRobot.Text + "SendKeys.SendWait(\"" + s + "\");";
            ScriptRobot.Text = ScriptRobot.Text + Environment.NewLine;
            ScriptRobot.Text = ScriptRobot.Text + "Thread.Sleep(" + "1000" + ");";
        }

        private void InputEnter_Click(object sender, RoutedEventArgs e)
        {
            ScriptRobot.Text = ScriptRobot.Text + Environment.NewLine;
            ScriptRobot.Text = ScriptRobot.Text + "SendKeys.SendWait(\"{ENTER}\");";
            ScriptRobot.Text = ScriptRobot.Text + Environment.NewLine;
            ScriptRobot.Text = ScriptRobot.Text + "Thread.Sleep(" + "1000" + ");";

        }

        private void StartProgram_Click(object sender, RoutedEventArgs e)
        {
            string s = InputProgramPath.Text;
            ScriptRobot.Text = ScriptRobot.Text + Environment.NewLine;
            ScriptRobot.Text = ScriptRobot.Text + "System.Diagnostics.Process p = System.Diagnostics.Process.Start(@\"" + s + "\");";
            ScriptRobot.Text = ScriptRobot.Text + "Thread.Sleep(" + "3000" + ");";
        }
    }
}
