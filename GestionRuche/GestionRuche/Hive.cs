﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRuche
{
    class Hive
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int InitWeight { get; set; }
        public bool Active { get; set; }
        public User UserId { get; set; }


    }
}
