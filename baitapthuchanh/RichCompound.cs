using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static baitapthuchanh.ChemicalDatabank;

namespace baitapthuchanh
{
    internal class RichCompound : Compound
    {
        private readonly ChemicalDatabank bank = new();
        // Constructor
        public RichCompound(Chemical chemical)
        {
            Chemical = chemical;
        }
        public override void Display()
        {
            // Adaptee request methods
            BoilingPoint = bank.GetCriticalPoint(Chemical, State.Boiling);
            MeltingPoint = bank.GetCriticalPoint(Chemical, State.Melting);
            MolecularWeight = bank.GetMolecularWeight(Chemical);
            MolecularFormula = bank.GetMolecularStructure(Chemical);
            WriteLine($"\nCompound: {Chemical} ------ ");
            WriteLine($" Formula: {MolecularFormula}");
            WriteLine($" Weight : {MolecularWeight}");
            WriteLine($" Melting Pt: {MeltingPoint}");
            WriteLine($" Boiling Pt: {BoilingPoint}");
        }
    }
}
