using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocalyz.Notes
{
    public class Note
    {
		//public const int SOUND_SPEED = 345; // Speed of sound (m/s) ------------> Moved to NotesManager as it's the same value for every notes.

        public string SymbolUS { get; private set; }

        public string SymbolFR { get; private set; }

		public double RefFrequency { get; private set; } // Note frequency (Hertz)

		public double RefWaveLenght { get; private set; } // Note wavelenght (cm)

        public Note(string symbolus,string symbolfr, double frequency,double wavelenght)
        {
            this.SymbolUS = symbolus;
            this.SymbolFR = symbolfr;
            this.RefFrequency = frequency;
            this.RefWaveLenght = wavelenght;
        }

		public double GetOctaveFrequency(int octave)
		{
			if (octave > 9)
			{
				return 1; // Octave not in audible range.
			}

			return (RefFrequency * Math.Pow (2, octave));
		}

		public double GetOctaveWavelenght(int octave)
		{
			if (octave > 9)
			{
				return 1; // Octave not in audible range.
			}

			return (RefWaveLenght / Math.Pow (2, octave));
		}
    }
}
