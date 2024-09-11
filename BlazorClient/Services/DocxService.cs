using BlazorClient.Models.Entity;

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace BlazorClient.Services
{
    public class DocxService
    {
        public static async Task WritePatientDocumentPD(Patient patient)
        {
            var pathDocuments = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documents");
            var pathOriginalDocumentPD = Path.Combine(pathDocuments, "Согласие на обработку ПД.docx");
            var memoryDocumentPD = new MemoryStream(await File.ReadAllBytesAsync(pathOriginalDocumentPD));
            var documentPD = WordprocessingDocument.Open(memoryDocumentPD, true);

            Directory.CreateDirectory(pathDocuments);

            var dataKeysPatient = new Dictionary<string, string>()
            {
                ["startfio"] = patient.FIO
            };

            try
            {
                foreach (var openXmlElement in documentPD.MainDocumentPart.Document.Body.ChildElements)
                {
                    if (openXmlElement is Paragraph paragraph)
                    {
                        foreach (var run in paragraph.Elements<Run>())
                        {
                            foreach (var text in run.Elements<Text>())
                            {
                                foreach (var keyValuePair in dataKeysPatient)
                                {
                                    if (text.Text.Contains(keyValuePair.Key))
                                    {
                                        text.Text = keyValuePair.Value;
                                    }
                                }
                            }
                        }
                    }
                }

                documentPD.Save();

                var pathSave = Path.Combine(pathDocuments, patient.PatientId + "_PD.docx");
                await File.WriteAllBytesAsync(pathSave, memoryDocumentPD.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
