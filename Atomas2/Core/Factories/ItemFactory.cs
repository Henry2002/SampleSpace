
using Atomas2.Contracts.Items;
using Atomas2.Models.Items;
using System;
using System.Linq.Expressions;

namespace Atomas2.Core.Factories
{
    internal class ItemFactory
    {

        public static Item Create(int Number)
        {
            if (Items.ContainsKey(Number))
            {
                var ItemDetails = Items[Number];

                if(Number > 0)
                {
                    return new Atom
                    {
                        Number = Number,
                        Name = ItemDetails.Name,
                        Symbol = ItemDetails.Symbol
                    };
                } else
                {
                    return new Power
                    {
                        Number = Number,
                        Symbol = ItemDetails.Symbol,
                        Name = ItemDetails.Name,
                    };
                }

                
            }
            else
            {
                throw new ArgumentException("Item with that number does not exist");
            }
        }

        private static readonly Dictionary<int, (string Name, string Symbol)> Items = new Dictionary<int, (string Name, string Symbol)>()
        {
            {0, ("Plus", "+") },
            {-1, ("Minus", "-") },
            {-2, ("Dark Plus", "+") },
            {-3, ("Dark Minus", "-") },
            {-4, ("Neutrino", "") },
            {-5, ("AntiMatter","")},

            {1, ("Hydrogen", "H") },
            {2, ("Helium", "He") },
            {3, ("Lithium", "Li") },
            {4, ("Beryllium", "Be") },
            {5, ("Boron", "B") },
            {6, ("Carbon", "C") },
            {7, ("Nitrogen", "N") },
            {8, ("Oxygen", "O") },
            {9, ("Flourine", "F") },
            {10, ("Neon", "Ne") },
            {11, ("Sodium", "Na") },
            {12, ("Magnesium", "Mg") },
            {13, ("Aluminium", "Al") },
            {14, ("Silicon", "Si") },
            {15, ("Phosphorous", "P") },
            {16, ("Sulfur", "S") },
            {17, ("Chlorine", "Cl") },
            {18, ("Argon", "Ar") },
            {19, ("Potassium", "K") },
            {20, ("Calcium", "Ca") },
            {21, ("Scandium", "Sc") },
            {22, ("Titanium", "Ti") },
            {23, ("Vanadium", "V") },
            {24, ("Chromium", "Cr") },
            {25, ("Manganese", "Mn") },
            {26, ("Iron", "Fe") },
            {27, ("Cobalt", "Co") },
            {28, ("Nickel", "Ni") },

        };
    }
}
