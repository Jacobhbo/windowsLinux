using windowsLinux.Interface;

namespace windowsLinux.Opgave
{
    internal class Linux : OS, IOS
    {

        public Linux(string userFullName) : base(userFullName)
        {
        }

        public string ShowOSType()
        {
            return $"Welcome {UserFullName} to Linux!";
        }


    }
}
