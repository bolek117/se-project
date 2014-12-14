using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Files
{
    interface ICategoriesList
    {
        List<IFileCategory> GetCategoriesList();

        bool ClearCategoriesList();

        IFileCategory GetCategoryById(int id);

        IFileCategory GetNextCategory();

        bool AddCategory(IFileCategory category);

        bool RemoveCategory(IFileCategory category);

        bool RemoveCategory(int category);
    }
}
