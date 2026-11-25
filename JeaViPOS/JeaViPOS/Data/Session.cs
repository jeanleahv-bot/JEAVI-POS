namespace JeaViPOS
{
    public static class Session
    {
        public static int UserId;
        public static string FullName = "";
        public static string RoleName = "";

        public static void Clear() { UserId = 0; FullName = ""; RoleName = ""; }
    }
}