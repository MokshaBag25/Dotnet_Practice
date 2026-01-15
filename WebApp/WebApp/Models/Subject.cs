using System;
using System.Collections.Generic;

namespace WebApp.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
