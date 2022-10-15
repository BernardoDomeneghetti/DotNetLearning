using ClickToStudy.CommonLib.Models;

namespace ClickToStudy.WorkerLib.Interfaces;

public interface INoteRepository
{
    Task<Note> Insert (Note note);
}
