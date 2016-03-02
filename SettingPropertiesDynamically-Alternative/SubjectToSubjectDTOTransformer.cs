using System.Linq;
using System.Reflection;

namespace SettingPropertiesDynamically_Alternative
{
    class SubjectToSubjectDTOTransformer
    {
        PropertyInfo[] _dtoProperties = typeof(SubjectDTO).GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .OrderBy(p => p.Name).ToArray();

        public SubjectDTO Transform(Subject subject)
        {
            var result = new SubjectDTO();

            for (var i = 0; i < _dtoProperties.Length; i++)
            {
                if (subject.Dates.Count() > i)
                {
                    _dtoProperties[i].SetValue(result, subject.Dates.Skip(i).First());
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}
