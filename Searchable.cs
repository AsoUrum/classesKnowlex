using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowlexClasses
{
    public interface Searchable
    {
        Category Category { get; set; }
        Skill Skill { get; set; }
        string searchByName { get; set; }
        string searchByGender { get; set; }
        int searchBy { get; set; }
    }
}