using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocalyz.Notes
{
    class NotesManager
    {
		public const int SOUND_SPEED = 345; // Speed of sound (m/s)

		public static List<Note> Notes = new List<Note>(); // All Notes (octaves frequencies and wavelenght can be found by calling GetOctaveFrequency(octave) & GetOctaveWavelenght(ocatve))

        static NotesManager()
        {
            Notes.Add(new Note("C", string.Empty, 16.35, 2109.89));
            Notes.Add(new Note(" C#/Db  ", string.Empty, 17.32, 1991.47));
            Notes.Add(new Note("D", string.Empty, 18.35, 1879.69));
            Notes.Add(new Note(" D#/Eb  ", string.Empty, 19.45, 1774.2));
            Notes.Add(new Note("E", string.Empty, 20.6, 1674.62));
            Notes.Add(new Note("F", string.Empty, 21.83, 1580.63));
            Notes.Add(new Note(" F#/Gb  ", string.Empty, 23.12, 1491.91));
            Notes.Add(new Note("G", string.Empty, 24.5, 1408.18));
            Notes.Add(new Note(" G#/Ab  ", string.Empty, 25.96, 1329.14));
            Notes.Add(new Note("A", string.Empty, 27.5, 1254.55));
            Notes.Add(new Note(" A#/Bb  ", string.Empty, 29.14, 1184.13));
            Notes.Add(new Note("B", string.Empty, 30.87, 1117.67));
        }

        public static Note GetNoteByFrequency(double frequency)
        {
            if (frequency== 524)
            {

            }

			return Notes.Find(x => x.RefFrequency == frequency -1 || x.RefFrequency == frequency+1 || x.RefFrequency == frequency);
        }
      
      
    }
    
}
