using Pocs.Packages.Common.Enums.FinView;

namespace Pocs.Packages.Common.Models.FinView
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Document { get; set; } = String.Empty;
        public UserType Type { get; set; }
    }
}
