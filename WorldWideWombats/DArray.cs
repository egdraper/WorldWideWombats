using System;
using System.Collections;
using System.Collections.Generic;

namespace WorldWideWombats
{
    public class DArray : IEnumerable, IEnumerator
    {
        //Consts
        private const int START_CAPACITY = 4;
        private const int START_INDEX = -1;
        private const int GROWTH_AMOUNT = 2;
        private const int START_TOP = 0;

        //Private
        private int _AIndex = START_INDEX;
        private int _Capacity = START_CAPACITY;
        private int _Top = START_TOP;

        private Employee[] _tempArray;
        private Employee[] _employees;

        private static DArray instance;

        //public
        public object Current { get { return _employees[_AIndex]; } }
        
        /// <summary>
        /// Instantiates the array
        /// </summary>
        private DArray()
        {
            this._employees = new Employee[START_CAPACITY];
        }


        /// <summary>
        /// Instaniates an instance of the object
        /// </summary>
        /// <returns></returns>
        public static DArray Instantiate()
        {
            if (instance == null)
            {
                instance = new DArray();
                return instance;
            }
            else
            {
                return instance;
            }
        }

        /// <summary>
        /// resizes the array
        /// </summary>
        private void Resize()
        {
            _tempArray = _employees;
            _Capacity *= GROWTH_AMOUNT;
            _employees = new Employee[_Capacity];
            for(int i = 0; i < _tempArray.Length; i++)
            {
                _employees[i] = _tempArray[i];
            }
            _tempArray = null;
        }


        /// <summary>
        /// Adds and Employee to the Collection
        /// </summary>
        /// <param name="employee">new employee</param>
        public void AddValue(Employee employee)
        {
            this._employees[_Top] = employee;
            _Top++;

            if (_Top == _Capacity)
            {
                this.Resize();
            }

        }

        /// <summary>
        /// Gets the current Employee
        /// </summary>
        /// <returns>Returns and Employee</returns>
        public Employee GetValue()
        {
            return (Employee)Current;
        }

        /// <summary>
        /// This moves to the next employee for the itterator 
        /// </summary>
        /// <returns>Returns a bool value to determine if there is a next</returns>
        public bool MoveNext()
        {
            //moves next if there is a value to move to
            _AIndex++;
            return (_AIndex < _employees.Length);  
        }
        
        /// <summary>
        /// Resets the index back to 0;
        /// </summary>
        public void Reset()
        {
            _AIndex = START_INDEX;
        }


        /// <summary>
        /// This returns the Enumerated object
        /// </summary>
        /// <returns>IEnumerator</returns>
        public IEnumerator GetEnumerator()
        {
            return this;
        }
       

    }
}
