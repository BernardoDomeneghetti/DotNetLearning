using PocAsyncDll.Common.Model;

namespace PocAsyncDll.IO
{
    internal class DocumentsIO
    {
        public static DocumentModel VerifyDocumentSync(string docmentName)
        {
            Thread.Sleep(5000);
            var documentContent = new Random().Next().ToString();
            return new DocumentModel()
            {
                Name = docmentName,
                Content = documentContent
            };
        }

        public static async Task<DocumentModel> VerifyDocumentAsync(string docmentName)
        {
            await Task.Delay(5000);
            var documentContent = new Random().Next().ToString();
            return new DocumentModel()
            {
                Name = docmentName,
                Content = documentContent
            };
        }
    }
}
