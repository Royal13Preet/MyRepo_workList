using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using OfficeOpenXml;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ResumeFiltering
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputFolder = @"C:\Users\preethu\Downloads\OneDrive_1_17-12-2024"; // Folder with resumes
            string outputExcel = @"C:\Users\preethu\Output\ResumeData.xlsx"; // Output Excel file
            List<(string Name, List<string> CompanyNames)> resumeData = new List<(string Name, List<string> CompanyNames)>();

            // Iterate over the files in the folder
            foreach (var file in Directory.GetFiles(inputFolder))
            {
                if (file.EndsWith(".pdf"))
                {
                    string content = ReadPdfWithIText(file); // Read PDF content
                    var (name, companyNames) = ExtractData(content); // Extract Name and Company Names
                    resumeData.Add((name, companyNames)); // Add data to list
                }
                else if (file.EndsWith(".docx") || file.EndsWith(".doc"))
                {
                    string content = ReadWord(file); // Read Word file content
                    var (name, companyNames) = ExtractData(content); // Extract Name and Company Names
                    resumeData.Add((name, companyNames)); // Add data to list
                }
            }

            // Export extracted data to Excel
            ExportToExcel(resumeData, outputExcel);
        }

        static string ReadPdfWithIText(string filePath)
        {
            using (PdfReader pdfReader = new PdfReader(filePath))
            using (PdfDocument pdfDoc = new PdfDocument(pdfReader))
            {
                string content = "";
                for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
                {
                    content += PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(i)); // Extract text from PDF
                }
                return content;
            }
        }

        static string ReadWord(string filePath)
        {
            Document document = new Document();
            document.LoadFromFile(filePath); // Read content from Word file
            return document.GetText();
        }

        static (string Name, List<string> CompanyNames) ExtractData(string content)
        {
            string name = "Unknown";
            List<string> companyNames = new List<string>();

            string[] lines = content.Split('\n');
            if (lines.Length > 0)
            {
                name = lines[0].Trim(); // Assuming the first line is the name
            }

            // Define a regex pattern to extract company names
            string companyPattern = @"\b([A-Za-z0-9&]+(?:\s+[A-Za-z0-9&]+)*\s*(?:Ltd|Inc|Technologies|Systems|Private\s+Limited|Pvt\s+Ltd|P.V.T\s*L.T.D|PVT\s*LTD)\b)";
            Regex regex = new Regex(companyPattern, RegexOptions.IgnoreCase);

            MatchCollection matches = regex.Matches(content); // Find all matches

            foreach (Match match in matches)
            {
                string company = match.Value.Trim();

                // Debugging: print out each company name matched
                Console.WriteLine($"Matched Company: {company}");

                // Clean company names: remove non-company-related terms
                if (!string.IsNullOrWhiteSpace(company) && !IsIrrelevantCompany(company))
                {
                    companyNames.Add(company); // Add valid company name
                }
            }

            // Remove duplicates and unnecessary entries
            companyNames = companyNames.Distinct().ToList();

            return (name, companyNames); // Return name and clean company names
        }

        static bool IsIrrelevantCompany(string company)
        {
            // Define a list of irrelevant terms or companies to ignore
            var irrelevantTerms = new List<string> { "Mobile", "Evaluation Warning", "India", "Ltd", "Technologies" };

            foreach (var term in irrelevantTerms)
            {
                if (company.IndexOf(term, StringComparison.OrdinalIgnoreCase)>=0)
                {
                    return true;
                }
            }

            return false;
        }


        static void ExportToExcel(List<(string Name, List<string> CompanyNames)> data, string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            if (file.Exists) file.Delete(); // Delete the existing file if it exists

            using (ExcelPackage excel = new ExcelPackage(file))
            {
                var sheet = excel.Workbook.Worksheets.Add("Resume Data");
                sheet.Cells[1, 1].Value = "Name";
                sheet.Cells[1, 2].Value = "Company Names"; // Column headers

                int row = 2;
                foreach (var entry in data)
                {
                    sheet.Cells[row, 1].Value = entry.Name; // Write name
                    sheet.Cells[row, 2].Value = string.Join(", ", entry.CompanyNames); // Write company names
                    row++;
                }

                excel.Save(); // Save the Excel file
            }
        }
    }
}
