using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JungleLangApp
{
    public partial class toJungle : Form
    {
        public toJungle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vowels = "aeiou";
            string consonants = "bcdfghjklmnpqrstvwxyz";
            string translation = englishPh.Text;
            translateEP.Text = translation;

            foreach (char letter in translation)
            {
                if (consonants.Contains(letter.ToString().ToLower()))
                {
                    translation += letter.ToString() + "a";
                }
                else if (vowels.Contains(letter.ToString().ToLower()))
                {
                    int index = vowels.IndexOf(letter.ToString().ToLower()) + 1;
                    translation += index.ToString();
                }
                else
                {
                    translation += letter;
                }
            }
         //   return translation;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void englishPh_TextChanged(object sender, EventArgs e)
        {

        }

        private void backTE_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void translateEP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toJungle_Load(object sender, EventArgs e)
        {
           // translateEP.Text = 
        }
    }
}
