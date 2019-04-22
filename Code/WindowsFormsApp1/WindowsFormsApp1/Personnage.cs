using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Personnage
    {
        public string Nom;
        public string PlayerName;
        private List<string> AcquiredClasses { get; }
        private List<short> LevelForClasses { get; }
        private short Strscore { get; set; }
        private short Dexscore { get; set; }
        private short Conscore { get; set; }
        private short Intscore { get; set; }
        private short Wisscore { get; set; }
        private short Chascore { get; set; }
        private short StrMod { get { return modifiers(Strscore); } }
        private short DexMod { get { return modifiers(Dexscore); } }
        private short ConMod { get { return modifiers(Conscore); } }
        private short IntMod { get { return modifiers(Intscore); } }
        private short WisMod { get { return modifiers(Wisscore); } }
        private short ChaMod { get { return modifiers(Chascore); } }
        private int MaxHitPoint { get; }
        private int ActualHitPoint { get => ActualHitPoint; set { if (value <= MaxHitPoint) ActualHitPoint = value; } }



        private short modifiers(short score)
        {
            return (short)((score - 10) / 2);
        }
        private void addclasse(string classe)
        {
            int index = AcquiredClasses.IndexOf(classe);
            if (index == -1)
            {
                AcquiredClasses.Add(classe);
                LevelForClasses.Add(0);
            }
            else
                LevelForClasses[index]++;
        }
    }
}
