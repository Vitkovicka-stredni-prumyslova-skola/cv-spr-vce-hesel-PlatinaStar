using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PasswordManager {
    interface IPassword {
        int PassLength();
        int MinPassLength();
        int MaxPassLength();
    }

    class Password : IPassword {
        private static int minPassLength = 8;
        public static int maxPassLength = 20;
        private string password;
        private string lowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private string upperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string nums = "1234567890";
        private string specialChars = "!@#$%^&*()_+-,./~`\\\'\"<>?§;:{}[]|´ˇ";

        public int PassLength() {
            return 0;
        }
        public int MinPassLength() {
            return minPassLength;
        }
        public int MaxPassLength() {
            return maxPassLength;
        }
        public static String PassGen() {
            string generatedPass;
            Random loop = new Random();
            Random length = new Random();
            for (int i = 0 ; i <= loop.Next(minPassLength, maxPassLength) ; i++) {
                
            }
            return generatedPass;
        }
    }
}