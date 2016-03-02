using System;

namespace SettingPropertiesDynamically_Alternative
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            for (var i = 0; i < 4; i++)
                subject.AddEvent(DateTime.Now.Date.AddDays(10 - i));

            Console.WriteLine("Subject: {0}", string.Join("\r\n", subject.Dates));

            var subjectDto = new SubjectToSubjectDTOTransformer().Transform(subject);

            Console.WriteLine("SubjectDTO: \r\n{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}"
                , subjectDto.Date1, subjectDto.Date2, subjectDto.Date3, subjectDto.Date4, subjectDto.Date5);

            Console.ReadKey();
        }
    }
}
