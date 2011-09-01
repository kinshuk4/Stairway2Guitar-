using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarK2.GuitarData
{
    public class Scale
    {

        public Note[] ScaleNotes { get; set; }

        public int nNotes { get; set; }
        public string ScaleName { get; set; }

        public static Scale getMajorScaleForNote(Note _note)
        {
            return new Scale(); 
        }

        public static Scale getMinorScaleForNote(Note _note)
        {
            return new Scale();
        }
        public static Scale getPentatonicScaleForNote(Note _note)
        {
            return new Scale();
        }
        public static Scale getChromaticScaleForNote(Note _note)
        {
            return new Scale();
        }


    }
}
