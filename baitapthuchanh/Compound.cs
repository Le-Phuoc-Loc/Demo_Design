using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static baitapthuchanh.ChemicalDatabank;

namespace baitapthuchanh
{
    internal class Compound
    {
        public Chemical Chemical { get; protected set; }
        public float BoilingPoint { get; protected set; }
        public float MeltingPoint { get; protected set; }
        public double MolecularWeight { get; protected set; }
        public string? MolecularFormula { get; protected set; }
        public virtual void Display()
        {
            WriteLine("\nCompound: Unknown ------ ");
        }

        private void WriteLine(string v)
        {
            throw new NotImplementedException();
        }
    }
}
