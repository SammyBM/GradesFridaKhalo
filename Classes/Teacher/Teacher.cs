using System;

namespace Teacher
{
    public class Teacher
    {
        string FirstName, SecondName,FirstLastName, SecondLastName, StateOfBirth, RFC, CURP;
        bool Base; //If in 1 the teacher is a base teacher, if not they are a subject teacher 
        bool Gender; //If 1 the teacher is male, if 0 the teacher is female
        byte Age;
        ushort PayrollID;
        DateTime DateOfBirth;
        List<Subject> TeachingClasses;

        private string generateCURP(){
            string CURP = FirstLastName[0];
            char temp;
            foreach (char letter in FirstLastName.ToUpper)
            {
                if(letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U'){
                    CURP += letter;
                    break;
                }
            }
            CURP += SecondLastName[0];
            if (SecondName == null || (FirstName.ToUpper != "JOSE" && FirstName.ToUpper != "MARIA"))
            {
                CURP += FirstName[0];
            }
            else
            {
                CURP += SecondName[0];
            }
            CURP += (DateOfBirth.Year.ToString)[2];
            CURP += (DateOfBirth.Year.ToString)[3];
            if (DateOfBirth.Month <= 9)
                CURP += '0';
            CURP += (DateOfBirth.Month.ToString);
            if (DateOfBirth.Day <= 9)
                CURP += '0';
            CURP += (DateOfBirth.Day.ToString); 
            if (Gender)
                CURP += 'H';
            else
                CURP += 'M';
            

        }



    }
}
