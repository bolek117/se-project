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
    public class CategoriesList : ICategoriesList
    {
        /// <summary>
        /// List storing categories list.
        /// </summary>
        protected List<IFileCategory> categoriesList;

        /// <summary>
        /// Internal value storing actual position in the list.
        /// </summary>
        protected List<IFileCategory>.Enumerator position;

        /// <summary>
        /// Default constructor. Initializes internal variables.
        /// </summary>
        public CategoriesList()
        {
            categoriesList = new List<IFileCategory>();
            position = categoriesList.GetEnumerator();
        }

        public List<IFileCategory> GetCategoriesList()
        {
            return categoriesList;
        }

        public bool ClearCategoriesList()
        {
            categoriesList.Clear();
            return true;
        }

        public IFileCategory GetCategory(int id)
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

        public IFileCategory GetNextCategory()
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

        public bool AddCategory(IFileCategory category)
        {
            categoriesList.Add(category);
            return true;
        }

        public bool RemoveCategory(IFileCategory category)
        {
            return categoriesList.Remove(category);
        }

        public bool RemoveCategory(int id)
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
