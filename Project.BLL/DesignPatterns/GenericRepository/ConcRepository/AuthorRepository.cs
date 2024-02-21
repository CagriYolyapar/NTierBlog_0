using Project.BLL.DesignPatterns.GenericRepository.EFBaseRepository;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRepository
{
    public class AuthorRepository : BaseRepository<Author>
    {
        /// <summary>
        /// Bu metot Author'i eklerken beraberinde o Author'a ait özel iki makale daha ekler...
        /// </summary>
        public void SpecialAdd(Author item)
        {

            Article ar = new Article
            {
                Title = "Test"
            };

            Article ar2 = new Article
            {
                Title = "Test2"
            };

            item.Articles.Add(ar);
            item.Articles.Add(ar2);

            _db.Authors.Add(item);
            Save();





            //_db.Authors diyerek sadece authora ait işlemleri burada gerçekleştirebilirsiniz.

        }
    }
}
