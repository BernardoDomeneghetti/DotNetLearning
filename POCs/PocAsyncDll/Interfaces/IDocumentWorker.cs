using PocAsyncDll.Common.Model;

namespace PocAsyncDll.Worker.Interfaces
{
    public interface IDocumentWorker
    {
        IEnumerable<DocumentModel> VerifyDocumentsSync(IProgress<DocumentModel> progress);
        Task<IEnumerable<DocumentModel>> VerifyDocumentsBadAsync(IProgress<DocumentModel> progress);
        Task<IEnumerable<DocumentModel>> VerifyDocumentsParallelAsync();
        IEnumerable<DocumentModel> VerifyDocumentsPArallelAsyncV2(IProgress<DocumentModel> progress);
    }
}