namespace MAXCINA.ViewModels
{
    public class CategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MovieVM> Movies { get; set; }
    }
}
