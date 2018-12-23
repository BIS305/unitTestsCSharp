using System;

//ouut (Object Under Unit Test)
namespace ouut
{
    public class StringStuff 
    {
        public string GetFirstNameFromFullName(string fullName){
            return fullName.Substring(0, fullName.IndexOf(" "));
        }
    }
}