namespace CodeChum.Tests
{
    public class DragDropTest
    {
        DragDrop? form;
        TreeView? TreeView1, TreeView2;
        TextBox? txtNodeName;
        Button? AddButton, UpdateButton, DeleteButton;

        public DragDropTest()
        {
            form = new DragDrop();
            form.Show();
            TreeView1 = (TreeView)TestUtils.GetControlNamed(form, "TreeView1", true);
            TreeView2 = (TreeView)TestUtils.GetControlNamed(form, "TreeView2", true);
            txtNodeName = (TextBox)TestUtils.GetControlNamed(form, "txtNodeName", true);
            AddButton = (Button)TestUtils.GetControlNamed(form, "AddButton", true);
            UpdateButton = (Button)TestUtils.GetControlNamed(form, "UpdateButton", true);
            DeleteButton = (Button)TestUtils.GetControlNamed(form, "DeleteButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(form);
            Assert.NotNull(TreeView1);
            Assert.NotNull(TreeView2);
            Assert.NotNull(txtNodeName);
            Assert.NotNull(AddButton);
            Assert.NotNull(UpdateButton);
            Assert.NotNull(DeleteButton);
        }

        [Fact]
        public void ShouldAddNodeToTreeView1OnAddButtonClick()
        {
            txtNodeName.Text = "Test Node";
            //Select a node from treeview1
            TreeView1.SelectedNode = TreeView1.Nodes[0];

            AddButton?.PerformClick();

            // Assert
            Assert.Equal("Test Node", TreeView1.SelectedNode.Text);
        }

        [Fact]
        public void ShouldAddNodeToTreeView2OnAddButtonClick()
        {
            txtNodeName.Text = "Test Node";
            //Select a node from treeview1
            TreeView2.SelectedNode = TreeView2.Nodes[0];

            AddButton?.PerformClick();

            // Assert
            Assert.Equal("Test Node", TreeView2.SelectedNode.Text);
        }

        [Fact]
        public void ShouldUpdateNodeInTreeView1OnUpdateButtonClick()
        {
            txtNodeName.Text = "Test Node";
            //Select a node from treeview1
            TreeView1.SelectedNode = TreeView1.Nodes[0];

            UpdateButton.PerformClick();

            Assert.Equal("Test Node", TreeView1.SelectedNode.Text);
        }

        [Fact]  
        public void ShouldUpdateNodeInTreeView2OnUpdateButtonClick()
        {
            txtNodeName.Text = "Test Node";
            //Select a node from treeview1
            TreeView2.SelectedNode = TreeView2.Nodes[0];

            UpdateButton.PerformClick();

            Assert.Equal("Test Node", TreeView2.SelectedNode.Text);
        }

        [Fact]
        public void ShouldDeleteNodeInTreeView1OnDeleteButtonClick()
        {
            //Select a node from treeview1
            TreeView1.SelectedNode = TreeView1.Nodes[0];

            int count = TreeView1.Nodes.Count;

            DeleteButton.PerformClick();

            Assert.Equal(count - 1, TreeView1.Nodes.Count);
        }

        [Fact]
        public void ShouldDeleteNodeInTreeView2OnDeleteButtonClick()
        {
            //Select a node from treeview1
            TreeView2.SelectedNode = TreeView2.Nodes[0];

            int count = TreeView2.Nodes.Count;

            DeleteButton.PerformClick();

            Assert.Equal(count - 1, TreeView2.Nodes.Count);
        }

        [Fact]
        public void ShouldDragAndDropNodeFromTreeView1ToTreeView2()
        {
            //Select a node from treeview1
            TreeView1.SelectedNode = TreeView1.Nodes[0];

            //Drag and drop the node to treeview2
            TreeView1.DoDragDrop(TreeView1.SelectedNode, System.Windows.Forms.DragDropEffects.Move);

            // Assert
            Assert.Equal(TreeView1.Nodes[0].Text, TreeView2.Nodes[0].Text);
        }

        [Fact]
        public void ShouldDragAndDropNodeFromTreeView2ToTreeView1()
        {
            //Select a node from treeview1
            TreeView2.SelectedNode = TreeView2.Nodes[0];

            //Drag and drop the node to treeview2
            TreeView2.DoDragDrop(TreeView2.SelectedNode, System.Windows.Forms.DragDropEffects.Move);

            // Assert
            Assert.Equal(TreeView2.Nodes[0].Text, TreeView1.Nodes[0].Text);
        }
    }
}
