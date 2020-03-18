using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Entites
{

    public interface IAuditTable02
    {

    }

    public class Student : IAuditTable02
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StudentNumber { get; set; }

    }

    public class DataChangeHistory
    {

        public int DataChangeHistoryId { get; set; }

        public string EntityType { get; set; }

        public string EntityId { get; set; }

        public string SerilzeDate { get; set; }

        public DateTime RegsiterationDate { get; set; }


    }


    public interface Audittable
    {
        int InsertBy { get; set; }
        int UpdateBy { get; set; }
        DateTime InsertTime { get; set; }
        DateTime UpdateTime { get; set; }
    }


    public class Teacher:Audittable
    {

        public int TeacherId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public int InsertBy { get; set; }
        public int UpdateBy { get; set; }
        public DateTime InsertTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
    public class Person
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Contact> Contacts { get; set; }

        public JobData JobData { get; set; }
    }


    public class Contact
    {
        public int ContactId { get; set; }

        public Person Person { get; set; }

        public int PersonId { get; set; }

        public string Con { get; set; }

    }

    public class JobData
    {

        public int JobDataId { get; set; }

        public string JobTitle { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

    }


    //public class Car : INotifyPropertyChanged,INotifyPropertyChanging
    //{

    //    private int _carId;

    //    public int CarId { get { return _carId; } set {
    //            if (_carId!=value)
    //            {
    //                //PropertyChanging
    //                _carId = value;
    //                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("_carId"));
    //            }

              
            
    //        } }
    //    public event PropertyChangedEventHandler PropertyChanged;
    //    public event PropertyChangingEventHandler PropertyChanging;
    //}

}
