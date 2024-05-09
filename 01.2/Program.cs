using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myAge = Interaction.InputBox
                ("Ваш вік?",
                "Вік");

            DateTime now = DateTime.Now;

            int age = Convert.ToInt32(myAge);

            int yearOfBirth = now.Year - age;

            MessageBox.Show($"Рік вашого народження: {yearOfBirth}", "Рік", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
