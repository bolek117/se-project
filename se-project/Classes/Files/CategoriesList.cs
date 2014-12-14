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
        public CategoriesList()
        {
            position = categoriesList.GetEnumerator();
        }

        /// <summary>
        /// Returns categories list.
        /// </summary>
        /// <returns>Categories list.</returns>
        public List<IFileCategory> GetCategoriesList()
        {
            return categoriesList;
        }

        /// <summary>
        /// Clears category list.
        /// </summary>
        /// <returns>True if cleared, else unspecified.</returns>
        public bool ClearCategoriesList()
        {
            categoriesList.Clear();
            return true;
        }

        /// <summary>
        /// Returns category identified by ID.
        /// </summary>
        /// <param name="id">ID of category to return by method.</param>
        /// <returns>Category identified by ID or null if category not found.</returns>
        public IFileCategory GetCategoryById(int id)
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

        /// <summary>
        /// Returns next category from the list.
        /// </summary>
        /// <returns>Next category or null if next category not found.</returns>
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

        /// <summary>
        /// Adds category to list.
        /// </summary>
        /// <param name="category">Category to add.</param>
        /// <returns>True if added, else false.</returns>
        public bool AddCategory(IFileCategory category)
        {
            categoriesList.Add(category);
            return true;
        }

        /// <summary>
        /// Removes categoryu from categories list.
        /// </summary>
        /// <param name="category">Category to delete.</param>
        /// <returns>True if removed, else false.</returns>
        public bool RemoveCategory(IFileCategory category)
        {
            return categoriesList.Remove(category);
        }

        /// <summary>
        /// Removes category from categories list identified by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">ID of the category to remove.</param>
        /// <returns>True if removed. False if cannot remove or category not found.</returns>
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
