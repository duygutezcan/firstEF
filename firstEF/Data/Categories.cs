namespace firstEF.Data
{
    public class Categories:Base
    {
        // Id yi base den alıyor
        public string CategoryName { get; set; }
        public ICollection<Products> Products { get; set; }   //bağlantıyı temsil eder yani FK    //ICollection<> benzerdir List<>
    }
}
