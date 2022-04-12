<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    internal class Calculator
    {
        private double sum = 0;
        private int n = 0;
        private double max = 0;
        private double min = 2;
        private string name = string.Empty; // ""
        private string alldata = string.Empty;

        /// <summary>
        /// Add new GPA to class
        /// </summary>
        /// <param name="gpa">gpa score</param>
        public void addGPA(double gpa, string name)
        {
            this.sum += gpa;
            this.n++;
            this.alldata += name + " " + gpa;

            if (this.max < gpa)
            {
                this.max = gpa;
                this.name = name;
            }
            if (this.min > gpa)
            {
                this.min = gpa;
                this.name = name;
            }
        }
        /// <summary>
        /// Return GPAx of class
        /// </summary>
        /// <returns>GPAx</returns>
        public double getGPAx()
        {
            double result = this.sum / this.n;
            return result;
        }
        public double getMax()
        {
            return this.max;
        }
        public string getMaxName()
        {
            return name;
        }
        public double getMin()
        {
            return this.min;
        }
        public string getMinName()
        {
            return name;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    internal class Calculator
    {
        private double sum = 0;
        private int n = 0;
        private double max = 0;
        private double min = 2;
        private string name = string.Empty; // ""
        private string alldata = string.Empty;

        /// <summary>
        /// Add new GPA to class
        /// </summary>
        /// <param name="gpa">gpa score</param>
        public void addGPA(double gpa, string name)
        {
            this.sum += gpa;
            this.n++;
            this.alldata += name + " " + gpa;

            if (this.max < gpa)
            {
                this.max = gpa;
                this.name = name;
            }
            if (this.min > gpa)
            {
                this.min = gpa;
                this.name = name;
            }
        }
        /// <summary>
        /// Return GPAx of class
        /// </summary>
        /// <returns>GPAx</returns>
        public double getGPAx()
        {
            double result = this.sum / this.n;
            return result;
        }
        public double getMax()
        {
            return this.max;
        }
        public string getMaxName()
        {
            return name;
        }
        public double getMin()
        {
            return this.min;
        }
        public string getMinName()
        {
            return name;
        }
    }
}
>>>>>>> 0562862f618c5f1f45062cae48225ad01025ab61
