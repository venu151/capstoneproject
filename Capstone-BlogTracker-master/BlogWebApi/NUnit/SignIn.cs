namespace NUnit
{
    public class SignIn
    {
        public string Authenticate(string userEmail, string password)
        {
            string result = "";
            if (string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(password))
            {
                result = "Please Provide username and password";
            }
            else
            {
                if (userEmail == "Admin1@gmail.com" && password == "admin@123")
                {
                    result = "Authentication Pass";
                }
                else
                {
                    result = "authentication Fail";
                }
            }
            return result;
        }
    }
}
