namespace WindowsFormsApp2023_Final
{
    internal class UserSession
    {
        // Singleton instance
        private static UserSession instance;

        // Properties for user information
        public string Username { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public string selectedVoice { get; set; }

        // Private constructor for the singleton pattern
        private UserSession() { }

        // Get the singleton instance
        public static UserSession Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserSession();
                return instance;
            }
        }

        // Method to check if the user is logged in
        public bool IsLoggedIn()
        {
            return !string.IsNullOrEmpty(Username);
        }
    }
}