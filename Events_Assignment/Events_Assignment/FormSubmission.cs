using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Assignment
{
    internal class FormSubmission    //publisher
    {
        public delegate void AlertHandler();
        public event AlertHandler Response;

        /// <summary>
        /// when submit button is clicked when filling a form
        /// </summary>
        public void ButtonClicked()

        {          
            Console.WriteLine("Submission in progress");

            Thread.Sleep(10000);

            ResponseReceived();
        }

        /// <summary>
        /// This method invokes the event
        /// </summary>
        protected virtual void ResponseReceived()
        {
            Response?.Invoke(); //raise event
        }
    }

    public class HumanResources  //subscriber
    {


        /// <summary>
        /// This method notifies the human resource team that a form has been submitted
        /// </summary>
        public void SubmissionProcesses()
        {
            var formSub = new FormSubmission();
            formSub.Response += FormSubmissionTasks;
            formSub.ButtonClicked();
        }

        public void FormSubmissionTasks()
        {
            Console.WriteLine("Form submitted successfully");
            Console.ReadLine();
        }
    }
}
