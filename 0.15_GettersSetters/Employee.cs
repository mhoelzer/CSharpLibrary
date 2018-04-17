using System;
namespace _GettersSetters
{
    public class Employee
    {
        // Fields
        private int _id;
        private string _name;

        // Properties (Conctructors would go before and methods would go after this)
        public int EmployeeID
        {
            set
            {
                // dont want an employee to have an id of 0 
                if (EmployeeID < 1)
                    throw new Exception("The Employee ID is not valid.");
                // uses the private property from the field to capture the value to see if its there
                this._id = value;
            }
            get
            {
                // this has to match type like above, so if dont want to return the id, just put like 0 or somethign
                return this._id;
            }
        }

        //one property
        public string FullName { get; set; }

        // same thing with propfull
        // not blank 
        // private to this class; has a helper variable to help as storage in set and get 
        //private string _name; (this is commented out here b/c it should be up in field)
        //assumes what type it is and does its stuff
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("The Epmployee name is not valid :(");
                // again, the this isnt necessary
                // sets value of _name but doesnt return anything so void method 
                // value is keyword related to keyword in arugement 
                this._name = value;
            }
            get
            {
                // returns stuff 
                return this._name;
            }
        }
    }
}
