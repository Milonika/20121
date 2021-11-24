﻿using System;
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

namespace ComputerClub.Pages
{
    /// <summary>
    /// Логика взаимодействия для BookingPage.xaml
    /// </summary>
    public partial class BookingPage : Page
    {

        public BookingPage(string mesto, string zona)
        {
            InitializeComponent();

            MestoTB.Text = mesto.ToString();
            zonaTB.Text = zona;
            //CPUL.Content = //////
            //GPUL.Content = //
            //MotherboardL.Content = ///
            //RAML.Content = //////


        }


    }
}
