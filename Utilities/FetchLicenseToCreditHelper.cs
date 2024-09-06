using System;
using System.IO;

namespace Template.Template.CSharpUtils.Utilities;

public class LicenseFetcher
{
    public static void FetchLicensesAndUpdateCredits()
    {
        string projectDirectory = Directory.GetCurrentDirectory();
        string[] licenseFiles = Directory.GetFiles(projectDirectory, "license.txt", SearchOption.AllDirectories);
        string creditsFilePath = Path.Combine(projectDirectory, "credits.txt");

        using (StreamWriter creditsFile = new StreamWriter(creditsFilePath, append: true))
        {
            foreach (string licenseFile in licenseFiles)
            {
                string[] licenseContent = File.ReadAllLines(licenseFile);
                foreach(var line in licenseContent)
                {
                    creditsFile.WriteLine(line);
                }

                creditsFile.WriteLine();
            }
        }

        Console.WriteLine("All licenses have been appended to credits.txt.");
    }
}
