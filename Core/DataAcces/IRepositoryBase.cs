using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAcces
{

    public interface IRepositoryBase<TEntity>
    where TEntity : class, IEntity
    {
        /*
        ! Biz burada deyirik ki Sene Tentity tipinden yeni istenilen bir class gelecek ancaq sen onalara bax ki onlar IEntiy classindan inherit alir bu sertleri odeyen bize classlar lazimdi 
    */
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        /*
            todo Bunu yazmagimizin sebebi (x=>x.Id == id) yazmaq ucun istifade edirik cunki bura her tipden birsey gele biler Bunu  butun modellere ve prop lari gondermek ucun generik tipden bir sey yazmaliyiq buunu ucun yaziriq bunu  

        */
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        /*
            ? Butun melumatlari getirmek ucun yazilir bu 
            ! burada sert veririk ki eger ki sirf secilen mehsul gelsin 
            * default olaraq da == null a beraber etmeyimizin sebebi budur sert yoxdursa yeni null di sa bu zaman bize butun melumatlari getirsin 
        */
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);

    }
}