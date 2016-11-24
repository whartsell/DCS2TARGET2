using HtmlAgilityPack;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace DCS2TARGET
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int padSize;
        public MainWindow()
        {
            InitializeComponent();
            padSize = 0;
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            
            HtmlDocument doc;
            List<TargetKeyMacro> macros;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "HTML files (*.html;*.htm)|*.html;*.htm|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (openFileDialog.ShowDialog() == true)
            {
                //read the html and creat macros
                macros = new List<TargetKeyMacro>();
                doc = new HtmlDocument();
                doc.Load(openFileDialog.FileName);
                foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table"))
                {
                    foreach (HtmlNode row in table.SelectNodes("tr"))
                    {
                        HtmlNodeCollection tds = row.SelectNodes("td");
                        if (tds.Count > 2)
                        {
                            TargetKeyMacro macro = new TargetKeyMacro();

                            macro.Category = HtmlEntity.DeEntitize(tds[2].InnerText);
                            string name = HtmlEntity.DeEntitize(tds[1].InnerText);
                            if (name.Length > padSize)
                                padSize = name.Length;
                            macro.Name = name;
                            macro.Command = HtmlEntity.DeEntitize(tds[0].InnerText);
                            macros.Add(macro);
                            
                        }
                    }
                }
                // format for writing
                Dictionary<string,Dictionary<string, string>> commands = new Dictionary<string,Dictionary<string, string>>();
                // build categories
                foreach (TargetKeyMacro macro in macros)
                {
                    if (commands.ContainsKey(macro.Category))
                    {
                        Dictionary<String, String> category = commands[macro.Category];
                        category[macro.Name] =  macro.Command;
                    }
                    else
                    {
                        Dictionary<string, string> category = new Dictionary<string, string>();
                        commands.Add(macro.Category, category);
                    }
                }
                StringWriter printWriter = new StringWriter();
                printWriter.Write("//Created by DCS2Target\n\n\n");
                printWriter.Write("include \"usbkeys.ttm\"\n\n\n");

                foreach (KeyValuePair<string,Dictionary<string,string>> category in commands)
                {
                    printWriter.Write("\n//{0}\n\n",category.Key);
                    foreach(KeyValuePair<string,string> command in category.Value)
                    {
                        string name = string.Format("define {0}", command.Key);


                        printWriter.Write("{0} {1}\n", name.PadRight(padSize + "define".Length + 10 ), command.Value);
                    }
                }
                //for (Map.Entry<String, HashMap<String, String>> entry:commands.entrySet())
                //{
                //    printWriter.printf("\n//%s\n\n", entry.getKey());
                //    HashMap<String, String> categoryCommands = entry.getValue();
                //    for (Map.Entry<String, String> command:categoryCommands.entrySet())
                //    {
                //        printWriter.printf("define %-50s\t%-40s\n", command.getKey(), command.getValue());
                //    }
                //}
                txtEditor.Text = printWriter.ToString();
            }
            
        }
    }
}
