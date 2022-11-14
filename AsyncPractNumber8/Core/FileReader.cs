using AsyncPractNumber8.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncPractNumber8.Core
{
    public static class FileReader
    {
        public async static Task<ObservableCollection<Teacher>> FileReadTeacher()
        {
            var teacherList = new ObservableCollection<Teacher>();
            using (StreamReader streamReader = new StreamReader(@"..\..\Files\Teachers.txt"))
            {
                string asyncTeacherText = await streamReader.ReadToEndAsync();
                foreach (var item in asyncTeacherText.Split('\n'))
                {
                    var arrayString = item.Split(',');
                    if (arrayString[0] != "ID")
                    {
                        Teacher teacher = new Teacher()
                        {
                            ID = int.Parse(arrayString[0]),
                            FirstName = arrayString[1],
                            LastName = arrayString[2],
                            Login = arrayString[3],
                            Password = arrayString[4]
                        };
                        teacherList.Add(teacher);
                    }
                }
            }
            return teacherList;
        }
    }
}
