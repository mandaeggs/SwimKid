using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SwimKids.Data
{
    public class LessonRepository: ILessonRepository
    {
        private readonly SwimKidsContext _swimKidsContext;

        public LessonRepository(SwimKidsContext swimKidsContext)
        {
            _swimKidsContext = swimKidsContext;
        }

        public async Task<IEnumerable<Lesson>> AllLessons()
        {
            return await Task.FromResult(_swimKidsContext.Lessons);
        }
    }
}
