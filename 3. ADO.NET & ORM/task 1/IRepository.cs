using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    interface IRepository
    {
        int CreateNote(Note note);

        int EditNote(Note note);

        int DeleteNote(Note note);

        Note SelectNote(Note note);
    }
}
