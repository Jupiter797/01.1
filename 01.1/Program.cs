using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yearOfBirth = Interaction.InputBox
                ("Рік вашого народження?",
                "Рік народження");

            DateTime now = DateTime.Now;

            int age = Convert.ToInt32(yearOfBirth);

            int years = now.Year - age;

            MessageBox.Show($"Ваш вік: {years} ", "Вік", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
