﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------
using MaterialSkin.Controls;
using CloudDesktopApp.Helper;

namespace CloudDesktopApp
{
    public partial class Regsiter : MaterialForm
    {
        public Regsiter()
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
        }
    }
}