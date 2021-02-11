using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodingTest.Core
{
    public enum SourceType
    {
        Advert,
        [Display(Name = "Word of mouth")]
        WordOfMouth,
        Other
    }
}
