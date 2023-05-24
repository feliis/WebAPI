
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi.Models
{
    public class Genre
    {

        [Key] 
        public int id_genre { get; set; }

        public string name_genre { get; set; }

        public virtual int NewIndex()
        {
            using (ContextDB DB = new ContextDB())
            {
                int Max = -1;
                var GenreList = DB.genre.ToList();
                foreach (Genre p in GenreList)
                {
                    if (p.id_genre > Max) Max = p.id_genre;
                }
                return (Max + 1);
            }
        }
    }
}
