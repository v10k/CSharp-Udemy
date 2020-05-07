﻿using System;

namespace Interface_3.Devices {
    class Scanner : Device, IScanner {

        public override void ProcessDoc(string document) {
            Console.WriteLine("Scanner processing: " +document);
        }

        public string Scan() {
            return "Scanner scan result";
        }
    }
}
