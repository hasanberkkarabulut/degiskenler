﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islemler
{
    public class SanalDatabase
    {
        private ArrayList listem;
        public SanalDatabase()
        {
            listem = new ArrayList();
        }

        public void yeniKayit(int data)
        {
            listem.Add(data);
        }
    }
}
