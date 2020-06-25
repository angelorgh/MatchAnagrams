using System;
using System.Collections.Generic;

namespace Matcher.Services {
    public class Display {
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