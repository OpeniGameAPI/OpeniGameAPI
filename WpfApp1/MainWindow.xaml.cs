using OpeniGameAPI.Service.CSharp;
using OpeniGameAPI.Service.CSharp.LED;
using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        LEDAPI LEDAPI = new LEDAPI();
        iGameMBoard iGameMBoard = new iGameMBoard();
        public MainWindow()
        {
            InitializeComponent();
            

            

            iGameSpaceCalcAPI.iGameSpaceCalc_Stop();
            iGameEasyCalc_API.iGameEasyCalc_Stop();

            iGameSpaceCalcAPI.iGameSpaceCalc_Init();
            iGameEasyCalc_API.iGameEasyCalc_Init();

            iGameMBoard.Init();

            List<string> ledmodelist = new List<string>();
            ledmodelist.Add("Static");
            ledmodelist.Add("Rainbow");
            ledmodecombo.ItemsSource = ledmodelist;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var test2 = default(iGameEasyCalc_LEDParameter);
            test2.Brightness = 255;
            //test2.LEDType = iGameEasyCalc_LEDType.Static;
            test2.Color = new RGB
            {
                r = 215,
                g = 53,
                b = 190,
            };
            test2.LEDCount = 100;
            test2.Speed = 5;

            switch (ledmodecombo.SelectedItem)
            {
                case "Static":
                    System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
                    colorDialog.AllowFullOpen = true;
                    colorDialog.FullOpen = true;
                    colorDialog.ShowHelp = true;
                    colorDialog.Color = System.Drawing.Color.Black;
                    colorDialog.ShowDialog();
                    test2.LEDType = iGameEasyCalc_LEDType.Static;
                    test2.Color = new RGB
                    {
                        r = colorDialog.Color.R,
                        g = colorDialog.Color.G,
                        b = colorDialog.Color.B,
                    };
                    break;
                case "Rainbow":
                    test2.LEDType = iGameEasyCalc_LEDType.Rainbow;
                    break;
            }
            LEDAPI.iGameEasyCalc_Calc_Effects(test2);
        }
    }
}
