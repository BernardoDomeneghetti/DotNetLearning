using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClickToStudy.CommonLib.Models;
using ClickToStudy.WorkerLib.Interfaces;

namespace ClickToStudy.WorkerLib.Repositories;

public class NoteRepository: INoteRepository
{
    public async Task<Note> Insert (Note note){
        throw new Exception("fuckOff let me do what i want");
    }
}
