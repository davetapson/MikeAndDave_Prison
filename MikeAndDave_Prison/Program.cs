using System;

namespace MikeAndDave_Prison
{
    class Program
    {
        /*
         * Spec 1.
         * 
         * Create a Prison
         * Create Prisoners
         *  Id
         *  Name
         *  Date of Birth
         *  
         *  Functionality:
         *  1. Add prisoner by entering + Prisoner and prisoner details. e.g. "+ Prisoner Mike Tinniswood" When prisoner is added, display prisoner Id, Name
         *  2. Release prisoner by entering - Prisoner and prisoner Id e.g. "- Prisoner 1"
         *      a. If Id does not exist, display message to say so
         *      b. If Id does exist, display message saying "Prisoner Id:x Name: xxxx xxxx to be released.  Are you sure? Enter 'Y' or 'N'"
         *         For all input, allow either case to be acceptable input
         *  3. If user types "ShowMeThePrisoners" or "SMTP" a list of the current prisoners is displayed.
         *  4. If user types "How Many" or "HM" display "There are currently x prisoners in the prison"
         *  
         *  Once that is done, version 2
         *  5. Create a Crime
         *  6. On start of the program, create a list of Crimes: Id, Description e.g. 1, Murder
         *  7. Allow user to add a Crime by typing + crime and crime description.  e.g. "+ Crime Murder"  Return Crime Id to screen.
         *  8. Allow user to remove a Crime by typing - crime and crime Id e.g. "- Crime 1". Same handling as for releasing a prisoner.
         *  9. Allow user to edit a Crime by typing ~ Crime CrimeId and the new description eg: "~ Crime 1 Murder"
         *  7. Allow user to see the list of crimes by typing "Crimes?"
         *  8. Add Crime to Prisoner by adding CrimeId to Prisoner
         *  9. Change prisoner input to need a crime, or if a crime is not entered, use a default crime e.g. crime Id = 0
         *  
         *  Once that is done, version 3
         *  10. Allow user to list crimes of current prisoners by typing "CurrentCrimes" or "CC"
         *  11. Make above list DISTINCT
         *  12. Allow user to list summary of current prisoners crimes by typing "CrimeSummary" or "CS" eg: Murder 2, Robbery 3
         *  13. Add error handling so that if you try to enter a Prisoner with a crime that does not exist, a message is shown that reads "Crime does not exist"
         *  14. Allow user to find all perpertrators of a crime by typing "List CrimeName" e.g. "List Murder" - all Prisoners who have committed murder will be returned.
         *  
         *  (Pro tip: if you create a list of prisoners on startup, you will not need to keep typing in prisoners to test the functionality as you go)
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
