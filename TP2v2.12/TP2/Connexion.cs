using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP2
{
    public class Connexion
    {
        private String userName;
        private String password;

        public String getUsername()
        { return userName; }  
       
        public void setUserName(String value )
        { userName = value; }
        public String getPassword()
        { return password; }

        public void setPassword(String value)
        { password = value; }
        public String nameValidation(String name) {

            String caractere = "true"; 
            {   
                if (name.Contains("@")) //validation si contient @
                {  
                    return caractere; 
                }

            } caractere = " le caractere '@' est obligatoire dans le username";  return caractere;
        }
        public String psswValidation(String psw ,String psw2)
        {
            String caractere = "true";
            if (psw.Equals(psw2))
            {
               
                if (psw.Length >= 3) //validation plus grand que 3 caracteres
                {
                    return caractere;
                }
                caractere = "   le mot de passe doit contenir au moins 3 caracteres";
                return caractere;
            }
            caractere = "   les champs password ne sont pas égaux";
            return caractere;
        }
    }
}