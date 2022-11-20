#nullable disable

namespace AppCore.Records.Bases
{
    public abstract class RecordBase
    {
        public int Id { get; set; }
        public string Guid { get; set; } //guid tekil id oluşturma şeysi internetten bak generated unique identifier
        //bu classı veri erişim için oluşturduğumuz dataaccess class librarysinde kullanmak için oluşturduk ve kullanmak için add reference diye ekledik
    }
}
