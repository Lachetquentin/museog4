using System;

namespace MuseoLibrary
{
    public static class Utils
    {
        public static bool CheckUsername(string username)
        {
            bool usernameFound = false;

            User user = DataLayer.UserData.GetUserByUsername(username);

            if (user == null) { return usernameFound; }

            if (username.Equals(user.Username)) { return usernameFound = true; }

            return usernameFound;
        }

        public static bool CheckIfItsMe(User user, int selectedUserId)
        {
            bool itsMe = false;

            if (user.UserId == selectedUserId)
            {
                return itsMe = true;
            }

            return itsMe;
        }

        public static bool CheckPhoneNumber(string number)
        {
            bool success = false;

            var phoneNumber = PhoneNumbers.PhoneNumberUtil.GetInstance();

            if (!number.StartsWith("0"))
            {
                return success;
            }

            try
            {
                success = phoneNumber.IsValidNumber(phoneNumber.Parse(number, "FR"));
            }
            catch (Exception)
            {
            }

            return success;
        }

        public static string EncryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool Login(string username, string password)
        {
            bool success = false;

            try
            {
                User user = DataLayer.UserData.GetUserByUsername(username);

                if (user == null) { return success; }

                if (user.Username.Equals(username))
                {
                    if (BCrypt.Net.BCrypt.Verify(password, user.Password)) { return success = true; }
                }
            }
            catch (Exception)
            {
                return false;
            }
            
            return success;
        }

        public static bool Checker(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}
