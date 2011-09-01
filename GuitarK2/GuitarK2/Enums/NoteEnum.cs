using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GuitarK2.Utils;


namespace GuitarK2.Enums
{
    public enum NoteEnum
    {
        [StringValue("C")]
        Note_C = 1,
        [StringValue("C#")]
        Note_CSharp = 2,
        [StringValue("D")]
        Note_D = 3,
        [StringValue("D#")]
        Note_DSharp = 4,
        [StringValue("E")]
        Note_E = 5,
        [StringValue("F")]
        Note_F = 6,
        [StringValue("F#")]
        Note_FSharp,
        [StringValue("G")]
        Note_G,
        [StringValue("G#")]
        Note_GSharp,
        [StringValue("A")]
        Note_A,
        [StringValue("A#")]
        Note_ASharp,
        [StringValue("B")]
        Note_B,

    }


}
