using windowsLinux.Interface;

namespace windowsLinux.Opgave
{
    internal class Windows : OS, IOS
    {
        public Windows(string UserFullName) : base(UserFullName)
        {
        }

        public string ShowOSType()
        {
            return $"Welcome {UserFullName} to Windows!";
        }
    }
}
