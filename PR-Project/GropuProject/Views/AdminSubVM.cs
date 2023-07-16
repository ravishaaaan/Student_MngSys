using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace GropuProject.Views
{
    public partial class AdminSubVM : ObservableObject
    {
        [ObservableProperty]
        public int id;

        [ObservableProperty]
        public string stName;
        [ObservableProperty]
        public string address;
        [ObservableProperty]
        public int birthDay;
        [ObservableProperty]
        public int age;
        [ObservableProperty]
        public int contNo;
        [ObservableProperty]
        ObservableCollection<Person> persons;
        public Person SelectedPerson { get; set; }



        [RelayCommand]
        public void InsertPerson()
        {
            Person p = new Person() {Id = Id, StName = StName, Address = Address, BirthDay = BirthDay , Age = Age ,ContNo = ContNo };
            using (var db = new PersonContext())
            {
                db.Persons.Add(p);
                db.SaveChanges();
                Id = 0;
                StName = "";
                Address = "";
                BirthDay= 0;
                Age = 0;
                ContNo = 0;
            }
            LoadPerson();


        }


        [RelayCommand]
        public void UpdatePerson()
        {
            if (SelectedPerson == null)
            {
                MessageBox.Show("Please select a person to update.");
                return;
            }
            using (var db = new PersonContext())
            {
               
                var selectedPerson = db.Persons.FirstOrDefault(p => p.Id == SelectedPerson.Id);

                if (selectedPerson != null)
                {
                   
                    selectedPerson.StName = StName;
                    selectedPerson.Address = Address;
                    selectedPerson.BirthDay = BirthDay;
                    selectedPerson.Age = Age;
                    selectedPerson.ContNo = ContNo;

                   
                    db.SaveChanges();
                    Id = 0;
                    StName = "";
                    Address = "";
                    BirthDay= 0;
                    Age = 0;
                    ContNo = 0;

                    LoadPerson();
                }
                else
                {
                    MessageBox.Show("Selected person not found in database.");
                }
            }
        }
        [RelayCommand]
        public void DeletePerson()
        {
            if (SelectedPerson == null)
            {
                MessageBox.Show("Please select a person to delete.");
                return;
            }

            using (var db = new PersonContext())
            {
               
                var selectedPerson = db.Persons.FirstOrDefault(p => p.Id == SelectedPerson.Id);

                if (selectedPerson != null)
                {
                    
                    db.Persons.Remove(selectedPerson);

                    
                    db.SaveChanges();

                   
                    LoadPerson();
                }
                else
                {
                    MessageBox.Show("Selected person not found in database.");
                }
            }
        }
        
        public Person GetPersonById(int id)
        {
            using (var db = new PersonContext())
            {
                return db.Persons.FirstOrDefault(p => p.Id == id);
            }
        }
        [RelayCommand]
        private void ReadPerson()
        {
            if (id == 0)
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            Person person = GetPersonById(id);

            if (person != null)
            {
                MessageBox.Show($"Id: {person.Id}\nStName: {person.StName}\nAddress: {person.Address}\nBirthDay: {person.BirthDay}\nAge: {person.Age}\nContNo: {person.ContNo}");
            }
            else
            {
                MessageBox.Show("Person not found.");
            }
        }





        public void LoadPerson()
        {
            using (var db = new PersonContext())
            {
                var list = db.Persons.OrderByDescending(p => p.Id).ToList();
                Persons = new ObservableCollection<Person>(list);
            }
        }

        public ObservableCollection<Module> Modules { get; set; }

        public void LoadModules()
        {
            using (var context = new Person1Context())
            {
                Modules = new ObservableCollection<Module>(context.Modules.ToList());
            }
        }

        public static List<Module> GetModules()
        {
            List<Module> modules;

            using (var context = new Person1Context())
            {
                modules = context.Modules.ToList();
            }

            return modules;
        }

        public static void RegisterStudentToModules(Person student)
        {
            List<Module> modules = GetModules();

            if(student != null)
            {
                using (var context = new Person1Context())
                {
                    foreach (Module module in modules)
                    {
                        StudentModule studentModule = new StudentModule
                        {
                            StudentId = student.Id,
                            ModuleId = module.Id
                        };
                        context.StudentModules.Add(studentModule);
                    }

                    context.SaveChanges();

                }
            }
        }

        public AdminSubVM()
        {
            Persons = new ObservableCollection<Person>();
            LoadPerson();
            LoadModules();
            int id = 1;
            RegisterStudentToModules(GetPersonById(id));
            
        }
    }
}
