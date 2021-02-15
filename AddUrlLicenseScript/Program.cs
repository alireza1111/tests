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
                "public-domain",
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
                "https://creativecommons.org/publicdomain/mark/1.0/",
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

            var descs = new string[,]
            {
                {"Det här verket har identifierats som fritt från kända upphovsrättsliga restriktioner, inklusive alla relaterade närstående rättigheter.", "This work has been identified as being free of known restrictions under copyright law, including all related and neighboring rights."},
{"Personen som associerat ett verk med detta dokument har dedikerat verket till public domain genom att avsäga sig sina rättigheter till verket i hela världen enligt upphovsrättslagstiftningen, inklusive alla relaterade och närstående rättigheter, så lågt lagen tillåter. ", "The person who associated a work with this deed has dedicated the work to the public domain by waiving all of his or her rights to the work worldwide under copyright law, including all related and neighboring rights, to the extent allowed by law. "},
{"Du har tillstånd att: Dela — kopiera och vidaredistribuera materialet oavsett medium eller format. Bearbeta — remixa, transformera, och bygg vidare på materialet för alla ändamål, även kommersiellt. ", "You are free to: Share — copy and redistribute the material in any medium or format. Adapt — remix, transform, and build upon the material for any purpose, even commercially. "},
{"Du har tillstånd att: Dela — kopiera och vidaredistribuera materialet oavsett medium eller format. Bearbeta — remixa, transformera, och bygg vidare på materialet .", "You are free to: Share — copy and redistribute the material in any medium or format. Adapt — remix, transform, and build upon the material."},
{"Du har tillstånd att: Dela — kopiera och vidaredistribuera materialet oavsett medium eller format.", "You are free to: Share — copy and redistribute the material in any medium or format."},
{"Du har tillstånd att: Dela — kopiera och vidaredistribuera materialet oavsett medium eller format. Bearbeta — remixa, transformera, och bygg vidare på materialet.", "You are free to: Share — copy and redistribute the material in any medium or format. Adapt — remix, transform, and build upon the material."},
{"Du har tillstånd att: Dela — kopiera och vidaredistribuera materialet oavsett medium eller format för alla ändamål, även kommersiellt.", "You are free to: Share — copy and redistribute the material in any medium or format for any purpose, even commercially. "},
{"Du har tillstånd att: Dela — kopiera och vidaredistribuera materialet oavsett medium eller format. Bearbeta — remixa, transformera, och bygg vidare på materialet för alla ändamål, även kommersiellt.", "You are free to: Share — copy and redistribute the material in any medium or format. Adapt — remix, transform, and build upon the material for any purpose, even commercially."},
                {"",""},
                {"",""},
                                {"",""}
            };

            var labels = new string[,]
            {
                {"Public domain-märke 1.0", "Public Domain Mark 1.0"},
{"Creative Commons  Public domain-dedikation  (CC0 1.0)", "Creative Commons  Public Domain Dedication (CC0 1.0)"},
{"Creative Commons  Erkännande 4.0 Internationell (CC BY 4.0)", "Creative Commons  Attribution 4.0 International (CC BY 4.0)"},
{"Creative Commons  Erkännande-Icke Kommersiell 4.0 Internationell (CC BY-NC 4.0)", "Creative Commons Attribution-NonCommercial 4.0 International (CC BY-NC 4.0)"},
{"Creative Commons  Erkännande-Icke kommersiell-Inga Bearbetningar 4.0 Internationell (CC BY-NC-ND 4.0)", "Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International (CC BY-NC-ND 4.0)"},
{"Creative Commons  Erkännande-Icke Kommersiell-Dela Lika 4.0 Internationell (CC BY-NC-SA 4.0)", "Creative Commons  Attribution-NonCommercial-ShareAlike 4.0 International (CC BY-NC-SA 4.0)"},
{"Creative Commons  Erkännande-Inga Bearbetningar 4.0 Internationell (CC BY-ND 4.0)", "Creative Commons  Attribution-NoDerivatives 4.0 International (CC BY-ND 4.0)"},
{"Creative Commons  Erkännande-Dela Lika 4.0 Internationell (CC BY-SA 4.0)", "Creative Commons  Attribution-ShareAlike 4.0 International (CC BY-SA 4.0)"},
{"Open Data Commons Open Database License (ODbL 1.0)", "Open Data Commons Open Database License (ODbL 1.0)"},
{"Open Data Commons Public Domain Dedication and License (PDDL 1.0)", "Open Data Commons Public Domain Dedication and License (PDDL 1.0)"},
{"Open Data Commons Attribution License (ODC-By 1.0)", "Open Data Commons Attribution License (ODC-By 1.0)"},
{"", ""},
                {"",""},
                {"",""}
            };

            writer.WriteLine("START TRANSACTION;");
            writer.WriteLine();
            for (int i =0; i<lic.Count; i++)
            writer.WriteLine(string.Format("UPDATE cv SET identifier = '{0}', description_sv = '{1}', description_en = '{2}', text_sv = '{3}', text_en = '{4}'  WHERE slug = '{5}';", url[i], descs[i, 0], descs[i, 1], labels[i, 0], labels[i, 1], lic[i]));

            writer.WriteLine();
            writer.WriteLine("COMMIT;");
        }
    }
}
