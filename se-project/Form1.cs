using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using se_project.Classes.Gui;

using se_project.Interfaces.Files;
using se_project.Classes.Files;

namespace se_project
{
    public partial class frmMain : Form
    {
        protected static ICategoriesList categoriesList = new CategoriesList();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void loadFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilesListGUI loader = new FilesListGUI(categoriesList);
            loader.loadFiles();
            updateFilesList();
        }

        private void updateFilesList()
        {
            // Clear actual tree view
            TreeView filesList = this.tvTypesList;
            filesList.Nodes.Clear();

            // Add new category
            IFileCategory fileCategory;
            while((fileCategory = categoriesList.GetNextCategory()) != null) {

                var files = fileCategory.GetFilesList();
                List<TreeNode> lst = new List<TreeNode>();

                IFile file;
                while ((file = files.GetNextFile()) != null)
                {
                    TreeNode node = new TreeNode(file.GetPath());
                    lst.Add(node);
                }

                TreeNode categoryNode = new TreeNode(fileCategory.GetName(), lst.ToArray());
                filesList.Nodes.Add(categoryNode);
            }
        }
    }
}


