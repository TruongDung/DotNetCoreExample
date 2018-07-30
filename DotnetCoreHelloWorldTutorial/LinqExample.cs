using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DotnetCoreHelloWorldTutorial
{
    class LinqExample
    {
        static readonly string[] Fruits = new[]
{
            "Acai",
            "Apple",
            "Apricots",
            "Banana",
            "Blackberry",
            "",
            "Blueberry",
            "Cherries",
            "Coconut",
            "Cranberry ",
            "Cucumber",
            "Currents",
            "Dates",
            "Durian",
            "Fig",
            "Goji berries",
            "Gooseberry",
            "Grapefruit",
            "Grapes",
            "Jackfruit",
            "Kiwi",
            "Kumquat",
            "Lemon",
            "Lime",
            "Lucuma",
            " Lychee",
            "Mango",
            "Mangosteen",
            "Melon",
            "",
            "Mulberry",
            "Nectarine",
            "Orange",
            "Papaya",
            "Passion Fruit",
            "Peach",
            "Pear",
            "Pineapple ",
            "Plum",
            "Pomegranate",
            "Pomelo",
            "Prickly Pear",
            "Prunes",
            "Raspberries",
            "Strawberries",
            "Tangerine",
            "Watermelon"
        };

        public void test()
        {
            var result = Fruits
                .Select(s=>s.Trim())
                .Where(w => !w.Contains(" ") && !String.IsNullOrEmpty(w.ToString()))
                .OrderByDescending(w => w.ToString().Length)
                .Select(s=>s.ToLower())
                .ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
            //Console.WriteLine(result.ToString());
        }
    }
}
