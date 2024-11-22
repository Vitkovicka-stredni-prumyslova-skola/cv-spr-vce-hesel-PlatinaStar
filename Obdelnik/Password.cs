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

        public int PassLength() {
            return 0;
        }
        public int MinPassLength() {
            return minPassLength;
        }
        public int MaxPassLength() {
            return maxPassLength;
        }

    }
}