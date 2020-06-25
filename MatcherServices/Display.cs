using System;
using System.Collections.Generic;

namespace Matcher.Services {
    public class Display {
        public void PrintOnScreen (Dictionary<string, List<string>> dictionary) {
            if (Validate (dictionary)) {
                foreach (var item in dictionary) {
                    foreach (var element in item.Value) {
                        Console.Write($"{element} ");
                    }
                    Console.WriteLine(" ");
                }
                return;
            }
            Console.Error.WriteLine("Invalid dictionary");
        }
        
        public string Print (Dictionary<string, List<string>> dictinoary) {
            if (Validate (dictinoary)) {
                string returned = "";
                foreach (var item in dictinoary) {
                    foreach (var element in item.Value) {
                        returned += $"{element} ";
                    }
                    returned += "\n ";
                }
                return returned;
            }
            return "Invalid dictionary";

        }
        public bool Validate (Dictionary<string, List<string>> dictinoary) {
            if (dictinoary.Count > 0)
                return true;
            return false;
        }
    }
}
