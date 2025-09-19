using System.Text.RegularExpressions;

namespace LeetCode.Questions
{
    public class ValidateIPAddress
    {
        public string ValidIpAddress(string queryIP)
        {
            if (string.IsNullOrEmpty(queryIP))
                return "Neither";

            if (queryIP.Contains('.'))
            {
                var segments = queryIP.Split('.');
                if (segments.Length != 4) return "Neither";

                foreach (var seg in segments)
                {
                    if (string.IsNullOrEmpty(seg) || seg[0] == '0' && seg.Length > 1)
                        return "Neither";

                    if (!int.TryParse(seg, out int num) || num > 255 || num < 0)
                        return "Neither";
                }

                return "IPv4";
            }

            if (queryIP.Contains(':'))
            {
                var segments = queryIP.Split(':');
                if (segments.Length != 8) return "Neither";

                foreach (var seg in segments)
                {
                    if (string.IsNullOrEmpty(seg) || seg.Length == 0 || seg.Length > 4)
                        return "Neither";

                    foreach (var c in seg)
                    {
                        if ((c < '0' || c > '9') && (c < 'a' || c > 'f') && (c < 'A' || c > 'F'))
                            return "Neither";
                    }
                }

                return "IPv6";
            }

            return "Neither";
        }

        //Original answer, improved above using help from using better soluitions
        //public string ValidIpAddress(string queryIP)
        //{
        //    if (string.IsNullOrEmpty(queryIP))
        //        return "Neither";

        //    if (queryIP.Count(c => c == '.') == 3)
        //    {
        //        var segments = queryIP.Split('.');

        //        if (segments.Any(x => !int.TryParse(x, out int num) || num > 255 || (x.StartsWith("0") && x.Length != 1)))
        //            return "Neither";

        //        return "IPv4";
        //    }

        //    if (queryIP.Count(c => c == ':') == 7)
        //    {
        //        var segments = queryIP.Split(':');

        //        //use regex to check if it contains a-f or A-F, could use this for the whole solution but thought this is better for my learning
        //        if (segments.Any(x => x.Length > 4 || x.Length < 1 || (!int.TryParse(x, out _) && Regex.Match(x, "[g-zG-Z]").Success)))
        //            return "Neither";

        //        return "IPv6";
        //    }

        //    return "Neither";
        //}
    }
}
