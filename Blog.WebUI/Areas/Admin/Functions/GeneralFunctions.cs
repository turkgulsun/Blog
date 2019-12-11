using Blog.Business.Abstract;
using Blog.WebUI.Areas.Admin.Models.ListViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebUI.Areas.Admin.Functions
{
    public class GeneralFunctions
    {
        public void CreateDirectory(string dirPath, string dirName)
        {
            if (Directory.Exists(dirPath))
            {
                try
                {
                    Directory.CreateDirectory(dirPath + dirName);
                }
                catch
                {
                }
            }
        }

        private IListService _listsService;
        private IListLanguageService _listLanguageService;

        public GeneralFunctions(IListLanguageService listLanguageService, IListService listService)
        {
            _listsService = listService;
            _listLanguageService = listLanguageService;
        }

        public List<ListListVM> GetListType(string type)
        {

            var _lists = _listsService.GetAll();
            var _listInfo = _listLanguageService.GetAll();

            var listTypes = (from l in _lists
                             join li in _listInfo on l.Id equals li.Id
                             where l.Type == type
                             select new ListListVM { Id = l.Id, Type = l.Type, Value = li.Value });

            return listTypes.ToList();

        }
    }
}
