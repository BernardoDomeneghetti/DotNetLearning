using PocAsyncDll.IO;
using PocAsyncDll.Common.Model;
using PocAsyncDll.Worker.Interfaces;

namespace PocAsyncDll.Worker
{
    internal class DocumentWorker: IDocumentWorker
    {
        public IEnumerable<DocumentModel> VerifyDocumentsSync(IProgress<DocumentModel> progress)
        {
            var names = GenerateDocumentNames(5);
            var verifiedDocuments = new List<DocumentModel>();
            foreach (var name in names)
            {
                var verifiedDocument = DocumentsIO.VerifyDocumentSync(name);
                verifiedDocuments.Add(verifiedDocument);
                progress.Report(verifiedDocument);
            }
            return verifiedDocuments;
        }

        public async Task<IEnumerable<DocumentModel>> VerifyDocumentsBadAsync(IProgress<DocumentModel> progress)
        {
            var names = GenerateDocumentNames(5);
            var verifiedDocuments = new List<DocumentModel>();
            foreach (var name in names)
            {
                var verifiedDocument = await DocumentsIO.VerifyDocumentAsync(name);
                verifiedDocuments.Add(verifiedDocument);
                progress.Report(verifiedDocument);
            }
            return verifiedDocuments;
        }

        public async Task<IEnumerable<DocumentModel>> VerifyDocumentsParallelAsync()
        {
            var names = GenerateDocumentNames(5);
            var verifiedDocuments = new List<DocumentModel>();
            var tasks = new List<Task<DocumentModel>>();
            foreach (var name in names)
            {
                tasks.Add(DocumentsIO.VerifyDocumentAsync(name));
            }

            await Task.WhenAll(tasks);

            return tasks.Select(x => x.Result);
        }

        public IEnumerable<DocumentModel> VerifyDocumentsPArallelAsyncV2(IProgress<DocumentModel> progress)
        {
            var names = GenerateDocumentNames(5);
            var verifiedDocuments = new List<DocumentModel>();
            Parallel.ForEach(names, (name) =>
            {
                var verifiedDocument = DocumentsIO.VerifyDocumentSync(name);
                verifiedDocuments.Add(verifiedDocument);
                progress.Report(verifiedDocument);
            });

            return verifiedDocuments;
        }

        private static IEnumerable<string> GenerateDocumentNames(int amount)
        {
            var names = new List<string>();

            for (int i = 0; i < amount; i++)
            {
                string name = "";
                for (int j = 0; j < 5; j++)
                {
                    name += new Random().Next().ToString();
                }
                names.Add(name);
            }
            return names;
        }
    }
}