﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
    static class Program {
        static void Main() {
            using (var game = new HelloGame()) {
                game.Run();
            }
        }
    }
}
