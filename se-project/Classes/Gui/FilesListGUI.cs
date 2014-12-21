using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using se_project.Interfaces.Files;
using se_project.Classes.Files;

namespace se_project.Classes.Gui
{
    class FilesListGUI
    {
        protected static ICategoriesList _categoriesList { get; set; }
        protected static int categoryIndex = 0;

        public FilesListGUI(ICategoriesList categoriesList)
        {
            if (categoriesList == null) throw new Exception("Categories list cannot be null");
            else
            {
                _categoriesList = categoriesList;
            }
        }

        public void loadFiles()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp, *.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            dialog.Title = "Load images to the new category...";
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int categoryId = categoryIndex++;
                
                IFileCategory category = new FileCategory();
                category.SetId(categoryId);
                category.SetName("Category " + categoryId);

                IFileList fileList = new FileList();
                int fileId = 0;
                foreach (String filePath in dialog.FileNames)
                {
                    IFile file = new File();
                    file.SetPath(filePath);
                    file.SetId(fileId++);

                    fileList.AddFile(file);
                }
                
                category.SetFileList(fileList);
                _categoriesList.AddCategory(category);
            }
        }

        public void updateGui(Form frm)
        {

        }
    }
}

