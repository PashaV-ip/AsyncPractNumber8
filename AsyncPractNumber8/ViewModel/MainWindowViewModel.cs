using AsyncPractNumber8.Command;
using AsyncPractNumber8.Core;
using AsyncPractNumber8.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AsyncPractNumber8.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<Teacher> _teachersList;
        private Teacher _teacher;
        public Teacher Teacher
        {
            get => _teacher;
            set
            {
                _teacher = value;
                OnPropertyChanged(nameof(Teacher));
            }
        }
        public ObservableCollection<Teacher> TeacherList
        {
            get => _teachersList;
            set
            {
                _teachersList = value;
                OnPropertyChanged(nameof(TeacherList));
            }
        }
        public async void ReadFile()
        {
            TeacherList = await FileReader.FileReadTeacher();
        }
        public void EqualsLINQ(object Object)
        {
            if (_teachersList.FirstOrDefault(x => x.FirstName == _teacher.FirstName && x.Login == _teacher.Login) != null)
            {
                MessageBox.Show("Такой пользователь есть!", "Ура..", MessageBoxButton.OK);
            }
            else MessageBox.Show("Такого пользователя нету!", "Проблема..", MessageBoxButton.OK);
        }
        public ICommand EqualsLINQCommand { get; }
        public MainWindowViewModel()
        {
            _teacher = new Teacher();
            EqualsLINQCommand = new RelativCommand(EqualsLINQ);
        }
    }
}
