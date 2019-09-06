using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Business.Concrete
{
    public class ClassLanguageManager : IClassLanguageService
    {
        public IClassLanguageDal _classLanguageDal;

        public ClassLanguageManager(IClassLanguageDal classLanguageDal)
        {
            _classLanguageDal = classLanguageDal;
        }

        public void Add(ClassLanguage classLanguage)
        {
            _classLanguageDal.Add(classLanguage);
        }

        public void Delete(int classLanguageId)
        {
            _classLanguageDal.Delete(new ClassLanguage { Id = classLanguageId });
        }

        public ClassLanguage Get(Expression<Func<ClassLanguage, bool>> filter = null)
        {
            return _classLanguageDal.Get(filter);
        }

        public List<ClassLanguage> GetAll()
        {
            return _classLanguageDal.GetList();
        }

        public void Update(ClassLanguage classLanguage)
        {
             _classLanguageDal.Update(classLanguage);
        }
    }
}
