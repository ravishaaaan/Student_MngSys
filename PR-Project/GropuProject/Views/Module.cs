﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GropuProject.Views
{
    public class Module
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string ModuleName { get; set; }
        public int Credits { get; set; }

        public Module(int id, string code, string moduleName, int credits)
        {
            Id = id;
            Code = code;
            ModuleName = moduleName;
            Credits = credits;
        }

        public Module() {
        
        }
    }
}
