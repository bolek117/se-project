using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using se_project.Interfaces.Files;

namespace se_project.Classes.Files
{
    /// <summary>
    /// Class storing categories list.
    /// </summary>
    class CategoriesList : ICategoriesList
    {
        /// <summary>
        /// List storing categories list.
        /// </summary>
        protected List<IFileCategory> categoriesList;

        /// <summary>
        /// Internal value storing actual position in the list.
        /// </summary>
        private List<IFileCategory>.Enumerator position;

        /// <summary>
        /// Default constructor. Initializes internal variables.
        /// </summary>
        CategoriesList()
        {
            position = categoriesList.GetEnumerator();
        }

        List<IFileCategory> GetCategoriesList()
        {
            return categoriesList;
        }

        bool ClearCategoriesList()
        {
            categoriesList.Clear();
            return true;
        }

        IFileCategory GetCategoryById(int id)
        {
            foreach(IFileCategory fc in categoriesList)
            {
                if (fc.GetId() == id)
                {
                    return fc;
                }
            }

            return null;
        }

        IFileCategory GetNextCategory()
        {
            if (position.MoveNext())
            {
                return position.Current;
            }
            else
            {
                return null;
            }
        }

        bool AddCategory(IFileCategory category)
        {
            categoriesList.Add(category);
            return true;
        }

        bool RemoveCategory(IFileCategory category)
        {
            return categoriesList.Remove(category);
        }

        bool RemoveCategory(int id)
        {
            foreach (IFileCategory fc in categoriesList)
            {
                if (fc.GetId() == id)
                {
                    return categoriesList.Remove(fc);
                }
            }

            return false;
        }
    }
}
