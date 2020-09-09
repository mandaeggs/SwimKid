using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwimKids.Data
{
    public interface ILessonRepository
    {
        Task<IEnumerable<Lesson>> AllLessons();
    }
}
