///Unit 1 Austin
/// 3/6/2018
///This program shows important details from the click of 4 Buttons labeled to what important information they show


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

namespace u1_004_Austin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void BtnI_ROR_Click(object sender, RoutedEventArgs e)
        
        {
            ///Important Recomendations Or Requirements
            LblOutput.FontSize = 12;
            LblOutput.Content = "Current Ontario secondary school students must complete the Ontario Secondary School" + "\n" + "Diploma (OSSD) with six 4U or 4M credits including:" + "\n" + "-" + "\n" + "English (ENG4U)" + "\n" + "Advanced Functions (MHF4U)" + "\n" + "and one of Calculus and Vectors (MCV4U), Physics (SPH4U) or Computer Science (ICS4U)" + "\n" + "In addition, a combined minimum 70 per cent average in prerequisite computer science, math" + "\n" + "and science courses is required" + "\n" + "-" + "\n" + "It is recomended that all three MCV4U, ICS4U and SPH4U be taken";

                
        }

        private void BtnPotentials_Click(object sender, RoutedEventArgs e)
        {
            ///Potential Careers
            LblOutput.FontSize = 15;
            LblOutput.Content = "Computer Science opens the door to a variety of lucrative careers, including" + "\n" + "Computer consultancy" + "\n" + "Computer programming" + "\n" + "Software houses" + "\n" + "Gaming and media sectors" + "\n" + "Systems analysis" + "\n" + "Technical support analysis";
        }

        private void BtnExpect_Click(object sender, RoutedEventArgs e)
        {
            ///Expectations
            LblOutput.FontSize = 13;
            LblOutput.Content = "Welcome to University of Ontario Institute of Technolgy's Computer Science Course" + "\n" + "The OUAC code is DSD" + "\n" + "Be warned that this course is moderately competitive to get into" + "\n" + "The campus is in north Oshawa, and downtown Oshawa";
        }

        private void BtnTime_Click(object sender, RoutedEventArgs e)
        {
            ///How Long You Will Be Here
            LblOutput.FontSize = 15;
            LblOutput.Content = "This program will last 4-5 years, as a full time course";
        }
    }
}
