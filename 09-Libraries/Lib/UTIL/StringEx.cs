namespace Lib.UTIL
{
    public static class StringEx
    {
        public static string fmt(this String that, params object[] o) 
            => String.Format(that, o);
        public static string xml(this String that, string tag)
            => $"<{tag}>{that}</{tag}>\n";
        public static string xml(this String that, string tag, string attrname, string attr)
            => $"<{tag} {attrname}='{attr}'>{that}</{tag}>\n";
        public static string prolog(this String doc) 
            => "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" + doc;
    }
}
