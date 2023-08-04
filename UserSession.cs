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
        // Add more user-specific properties as needed

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

        // Method to clear user session data on logout or application close
        public void ClearSession()
        {
            Username = null;
            UserId = 0;
            // Clear other user-specific data
        }
    }
}