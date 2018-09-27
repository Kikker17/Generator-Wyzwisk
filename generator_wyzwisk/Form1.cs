using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace generator_wyzwisk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random los = new Random();
            string[] przymiotnik = {"niewyuczalny", "głupkowaty", "wykolejony", "cofnięty", "homogenizowany", "ordynarny", "uzależniony", "wulgarny" , "ordynarny" , "pospolity" , "prostacki" , "sprośny" , "plugawy" , "rynsztokowy" , "uliczny", "nieprzyzwoity" , "nikczemny", "podły", "wredny", "zabrudzony", "niecny", "nieszlachetny", "nieprawy", "zbędny", "zapluty", "niegustowny", "nieatrakcyjny", "nieelegancki", "nieapetyczny", "żałosny", "nieestetyczny", "zły", "polityczny", "poczwarny", "potworkowaty", "koszmarkowaty", "obmierzły", "zielony", "paskudny", "szkaradny", "koszmarny", "ohydny", "wstrętny", "przerośnięty", "mokry", "oślizgły", "niepiękny", "szpetny", "okropny", "przeokropny", "podeptany", "arogancki", "popierwiastkowany", "nieładny", "głupi", "popaprany", "porąbany", "młodociany", "pokraczny", "osobliwy", "obrzydliwy", "brudny"};
            string[] imieslow = {"frustrujący", "staczający się", "prymitywiejący", "fermentujący", "tęchnący", "jełczejący", "rozsypujący się", "próżnujący", "marniejący", "degenerujący się", "rozkładający się", "gnuśniejący", "gnijący", "parszywiejący", "psujący się", "rażący", "krępujący", "wkurzający", "wnerwiający", "irytujący", "drażniący", "zawadzający", "odstraszający", "pleśniejący", "knujący", "brudzący", "babrający się", "odpychający", "butwiejący", "odstręczający", "żenujący", "odrażający", "śmierdzący", "bulwersujący", "plujący", "denerwujący"};
            string[] rzeczownik = {"ciołek", "robak", "troglodyta", "karzeł", "gnom", "troll", "homonim", "dyletant", "impertynent", "niedorajda", "gapa", "gamoń", "patafian", "wałkoń", "jełop", "warchoł", "grzyb", "fajtłapa", "huncwot", "obwieś" , "ananas", "ancymon", "czarny charakter", "drapichrust", "gagatek", "hultaj", "łapserdak", "łobuz", "łobuziak", "łotr", "nicpoń", "rozrabiaka", "urwipołeć", "niecnota", "łajdak", "błazen", "chłystek", "małolat", "chuligan", "prostak", "barbarzyńca", "drań", "margines społeczny", "obibok", "wandal", "nikczemnik"};

            // Generate random indexes for pet names.
            int pIndex = los.Next(0, przymiotnik.Length);
            int iIndex = los.Next(0, imieslow.Length);
            int rIndex = los.Next(0, rzeczownik.Length);

            textBox1.Text = string.Concat(przymiotnik[pIndex]," ",imieslow[iIndex]," ",rzeczownik[rIndex]);
        }
    }
}
