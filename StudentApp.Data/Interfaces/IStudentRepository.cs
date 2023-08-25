﻿using StudentApp.Data.TransactionObjects;
using StudentApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Data.Interfaces
{
    public interface IStudentRepository
    {
        string Create(Student student, UserToStudentTO userToStudentTO);
    }
}
