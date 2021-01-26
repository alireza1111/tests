using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddUrlLicenseScript
{
    class Program
    {
        static void Main(string[] args)
        {
            using var writer = new StreamWriter("ccUrlScript.sql", false, new UTF8Encoding(false));
            GetScript(writer);
        }

        private static void GetScript(TextWriter writer)
        {
            var lic = new List<string>
            {
                "cc0",
                "cc-by-40",
                "cc-by-nc-40",
                "cc-by-nc-nd-40",
                "cc-by-nc-sa-40",
                "cc-by-nd-40",
                "cc-by-sa-40",
                "odbl-10",
                "pddl-10",
                "odc-by-10"
            };

            var url = new List<string>
            {
                "https://creativecommons.org/publicdomain/zero/1.0/",
                "https://creativecommons.org/licenses/by/4.0/",
                "https://creativecommons.org/licenses/by-nc/4.0/",
                "https://creativecommons.org/licenses/by-nc-nd/4.0/",
                "https://creativecommons.org/licenses/by-nc-sa/4.0/",
                "https://creativecommons.org/licenses/by-nd/4.0/",
                "https://creativecommons.org/licenses/by-sa/4.0/",
                "https://opendatacommons.org/licenses/odbl/1-0/",
                "https://opendatacommons.org/licenses/pddl/1-0/",
                "https://opendatacommons.org/licenses/by/1-0/"
            };

            writer.WriteLine("START TRANSACTION;");
            writer.WriteLine();
            for (int i =0; i<lic.Count; i++)
            writer.WriteLine(string.Format("UPDATE cv SET identifier = '{0}' WHERE slug = '{1}';", url[i], lic[i]));

            writer.WriteLine();
            writer.WriteLine("COMMIT;");
        }
    }
}
