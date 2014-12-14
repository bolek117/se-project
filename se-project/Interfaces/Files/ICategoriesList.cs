using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace se_project.Interfaces.Files
{
    interface ICategoriesList
    {
        /// <summary>
        /// Returns categories list.
        /// </summary>
        /// <returns>Categories list.</returns>
        public List<IFileCategory> GetCategoriesList();

        /// <summary>
        /// Clears category list.
        /// </summary>
        /// <returns>True if cleared, else unspecified.</returns>
        public bool ClearCategoriesList();

        /// <summary>
        /// Returns category identified by ID.
        /// </summary>
        /// <param name="id">ID of category to return by method.</param>
        /// <returns>Category identified by ID or null if category not found.</returns>
        public IFileCategory GetCategory(int id);

        /// <summary>
        /// Returns next category from the list.
        /// </summary>
        /// <returns>Next category or null if next category not found.</returns>
        public IFileCategory GetNextCategory();

        /// <summary>
        /// Adds category to list.
        /// </summary>
        /// <param name="category">Category to add.</param>
        /// <returns>True if added, else false.</returns>
        public bool AddCategory(IFileCategory category);

        /// <summary>
        /// Removes categoryu from categories list.
        /// </summary>
        /// <param name="category">Category to delete.</param>
        /// <returns>True if removed, else false.</returns>
        public bool RemoveCategory(IFileCategory category);

        /// <summary>
        /// Removes category from categories list identified by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">ID of the category to remove.</param>
        /// <returns>True if removed. False if cannot remove or category not found.</returns>
        public bool RemoveCategory(int category);
    }
}
