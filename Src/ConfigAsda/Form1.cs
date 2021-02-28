////////////////////////////////////////////////
//             LORENSTUDIO                     /
//          By Rodrigo(Lucifer)                /
//          Whats: (22)98186-8617              /
//        Email: suporte@lorenstudio.com       /
////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConfigAsda
{
    public partial class Form1 : Form
    {
        bool IsMinimized;


        public Form1()
        {
            InitializeComponent();
            CheckMinimized();
        }

        public void CheckMinimized() //VERIFICA SE A CHECKBOX FOI SELECIONADA OU NÃO.
        {
            string str = ".\\\\system\\NewConfig.ini";
            try
            {
                if (System.IO.File.ReadAllLines(str)[8] == "Window_Mode    =TRUE")
                {
                    Common.lineChanger("Window_Mode    =TRUE", str, 9);
                    IsMinimized = true;
                    WinMode.Checked = true;
                }
                else
                {
                    Common.lineChanger("Window_Mode    =FALSE", str, 9);
                    IsMinimized = false;
                    WinMode.Checked = false;
                }

            }
            catch
            {
                if (!System.IO.File.Exists(str))
                {
                    string[] contents = new string[30]
                    {
"[System]",
"ResolutionX        =",
"ResolutionY        =",
"ResolutionBPP    =",
"Monitor_Refresh  =",
"Depth_Bit              =",
"TextureFilter        =",
"Enable_Light       =",
"Window_Mode    =TRUE",
"Texture_Minimum =",
"FPS_Show         =",
"First_Start          ",
"Language           =",
"FontSize=",
"\n",
"[Graphic]",
"GraphicCustumize =",
"Grass_Show       =",
"Soft_Horizon       =",
"Character_Shade =",
"Terrain_Rendering =",
"Water_Reflect      =",
"TerrainBright        =",
"TerrainShadow     =",
"WeatherEffect     =",
"Shadow_Quality  =",
"Camera_Dis        =",
"MultiSampling_Type=0",
"OutLine_Rendering=",
"Object_View_Distance="
                    };
                    System.IO.File.WriteAllLines(str, contents);
                }
                else
                    Common.lineChanger("Window_Mode    =TRUE", str, 9);
            }
        }






        private void SetWinMode() //SETA EM MODO JANELA
        {
            string str = ".\\\\system\\NewConfig.ini";
            {
                if (System.IO.File.ReadAllLines(str)[8] == "Window_Mode    =FALSE")
                {
                    Common.lineChanger("Window_Mode    =TRUE", str, 9);
                    IsMinimized = true;
                }
                else
                {

                    Common.lineChanger("Window_Mode    =FALSE", str, 9);
                    IsMinimized = false;
                }

            }
        }

            private void Resolu1024() //MUDA A RESOLUÇÃO 
        {
            string str = ".\\\\system\\NewConfig.ini";
            {
               
                    Common.lineChanger("ResolutionX        =1024", str, 2);
                    Common.lineChanger("ResolutionY        =768", str, 3);
            }
        }


        private void Resolu1280() //MUDA A RESOLUÇÃO 
        {
            string str = ".\\\\system\\NewConfig.ini";
            {
              
                    Common.lineChanger("ResolutionX        =1280", str, 2);
                    Common.lineChanger("ResolutionY        =768", str, 3);

            }
        }

        private void Resolu12802() //MUDA A RESOLUÇÃO 
        {
            string str = ".\\\\system\\NewConfig.ini";
            {
                    Common.lineChanger("ResolutionX        =1280", str, 2);
                    Common.lineChanger("ResolutionY        =800", str, 3);
                    

            }
        }


        private void Resolu12803() //MUDA A RESOLUÇÃO 
        {
            string str = ".\\\\system\\NewConfig.ini";
            {
             
                    Common.lineChanger("ResolutionX        =1280", str, 2);
                    Common.lineChanger("ResolutionY        =960", str, 3);

            }
        }

        private void Resolu12804() //MUDA A RESOLUÇÃO 
        {
            string str = ".\\\\system\\NewConfig.ini";
            {
               
                    Common.lineChanger("ResolutionX        =1280", str, 2);
                    Common.lineChanger("ResolutionY        =1024", str, 3);


            }
        }


        private void Resolu1366() //MUDA A RESOLUÇÃO 
        {
            string str = ".\\\\system\\NewConfig.ini";
            {
              
                    Common.lineChanger("ResolutionX        =1366", str, 2);
                    Common.lineChanger("ResolutionY        =768", str, 3);
            }
        }



        private void Resolu1680() //MUDA A RESOLUÇÃO 
        {
            string str = ".\\\\system\\NewConfig.ini";
            {
              
                    Common.lineChanger("ResolutionX        =1680", str, 2);
                    Common.lineChanger("ResolutionY        =1050", str, 3);

            }
        }


        private void Resolu1920() //MUDA A RESOLUÇÃO  
        {
            string str = ".\\\\system\\NewConfig.ini";
            {
               
                    Common.lineChanger("ResolutionX        =1920", str, 2);
                    Common.lineChanger("ResolutionY        =1080", str, 3);


            }
        }


        private void AliasingNone() //SETA NULO NO ANTIALIASING
        {
            string str = ".\\\\system\\NewConfig.ini";
            {
             
                    Common.lineChanger("MultiSampling_Type        =0", str, 28);


            }
        }

        private void AliasingX2() //SETA X2 NO ANTIALIASING
        {
            string str = ".\\\\system\\NewConfig.ini";
            {
               
                    Common.lineChanger("MultiSampling_Type        =1", str, 28);


            }
        }


        private void AliasingX4() //SETA X4 NO ANTIALIASING
        {
            string str = ".\\\\system\\NewConfig.ini";
            {
               
                    Common.lineChanger("MultiSampling_Type        =2", str, 28);


            }
        }


        private void AliasingX8() //SETA X8 NO ANTIALIASING
        {
            string str = ".\\\\system\\NewConfig.ini";
            {
              
                    Common.lineChanger("MultiSampling_Type        =3", str, 28);


            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Resolu1024();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Resolu1280();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                Resolu12802();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                Resolu12803();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                Resolu12804();
            }
            if (comboBox1.SelectedIndex == 5)
            {
                Resolu1366();
            }
            if (comboBox1.SelectedIndex == 6)
            {
                Resolu1680();
            }
            if (comboBox1.SelectedIndex == 7)
            {
                Resolu1920();
            }

            if (comboBox2.SelectedIndex == 0)
            {
               AliasingNone();
            }

            if (comboBox2.SelectedIndex == 1)
            {
                AliasingX2();
            }

            if (comboBox2.SelectedIndex == 2)
            {
                AliasingX4();
            }

            if (comboBox2.SelectedIndex == 3)
            {
                AliasingX8();
            }


            MessageBox.Show("Configuração Salva:" + "\n  " + "Modo Janela:" + " " + WinMode.Checked + "\n  " + "Resolução:" + " " + comboBox1.SelectedItem + "\n " + "Anti Aliasing:" + " " + comboBox2.SelectedItem);

            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WinMode_MouseClick(object sender, MouseEventArgs e)
        {
            SetWinMode();
        }
    }
}
