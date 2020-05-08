namespace System {
   static class StringExtensions {

        public static string Cut(this string thisObj, int n) {
            return (thisObj.Length <= n) ? thisObj : thisObj.Substring(0, n) + "...";
        }
    }
}
