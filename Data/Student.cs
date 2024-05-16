﻿using System;
using System.Collections.Generic;

namespace SchoolManagementApp.mvc.Data;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime? Dob { get; set; }
}