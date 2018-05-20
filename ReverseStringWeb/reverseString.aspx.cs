/* Devin Lee 5/18/2018
 * In this web application a user can input a string they want to reverse
 * After pressing the button the inputed string will be reversed and displayed
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReverseStringWeb
{

    public partial class reverseString: System.Web.UI.Page
    {
        public static string ReverseString(string r) //method that takes in a string and reverses it using a char array
        {
            int position = 0; //placeholder variable
            char[] reversed = new char[r.Length]; //new char array to store string
            for (int i = r.Length - 1; i >= 0; i--) //loop through the string at each char and place each char in reverse order in the array
            {
                reversed[position++] = r[i]; //char at current i = position in array
            }
            return new string(reversed); //output the new reversed string 
        }


        protected void Page_Load(object sender, EventArgs e){
        }

        protected void reversedInput_TextChanged(object sender, EventArgs e){
        }

        protected void Button1_Click(object sender, EventArgs e){
            this.reversedOutput.Text = ReverseString(this.reversedInput.Text); //setting the output text label to the string input from user that was reversed using the reverseString method
        }
    }
}