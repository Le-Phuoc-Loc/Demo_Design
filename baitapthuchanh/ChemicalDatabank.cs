using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapthuchanh
{
    internal class ChemicalDatabank
    {
        public float GetCriticalPoint(Chemical compound, State point)
        {
            // Melting Point
            if (point == State.Melting)
            {
                return compound switch
                {
                    Chemical.Water => 0.0f,
                    Chemical.Benzene => 5.5f,
                    Chemical.Ethanol => -114.1f,
                    _ => 0f,
                };
            }
            // Boiling Point
            else
            {
                return compound switch
                {
                    Chemical.Water => 100.0f,
                    Chemical.Benzene => 80.1f,
                    Chemical.Ethanol => 78.3f,
                    _ => 0f,
                };
            }
        }
        public enum Chemical
        {
            Water,
            Benzene,
            Ethanol
        }
        public enum State
        {
            Boiling,
            Melting
        }
    }
    }
