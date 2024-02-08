using System.ComponentModel.DataAnnotations;

namespace BucStop.FlatFile
{
    public static class FFAPI
    {
        //file pointer = flatfile;
        public static void addUser(string username) {

            if (!userExists(username))
            {
                // todo: add user
            }
            else
            {
                // error, user already present
            }

        }

        public static void updateRole (string username, string role)
        {

            if (!userExists(username))
            {
                this.role = role;
                // todo: add user
            }
        }

        public
    }
}