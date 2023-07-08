namespace MovieStore.Repositories.Abstract
{
    public interface IFile
    {
        public Tuple<int, string> SaveImage(IFormFile imageFile);
        public bool DeleteImage(string imageFileName);
    }
}