﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    internal class Groups
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Lessons> Lessons { get; set; }

        public ICollection<Students> Students { get; set; }
    }
}