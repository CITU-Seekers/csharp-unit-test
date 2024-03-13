namespace CodeChum.Tests
{
    public class TwoTreesTest
    {
        TwoTrees? form;
        TreeView? leftTreeView, rightTreeView;
        TextBox? nodeNameTextBox;
        Button? addButton, updateButton, moveButton, deleteButton;

        public TwoTreesTest()
        {
            form = new TwoTrees();
            form.Show();

            leftTreeView = (TreeView)TestUtils.GetControlNamed(form, "leftTreeView", true);
            rightTreeView = (TreeView)TestUtils.GetControlNamed(form, "rightTreeView", true);
            nodeNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "nodeNameTextBox", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
            updateButton = (Button)TestUtils.GetControlNamed(form, "updateButton", true);
            moveButton = (Button)TestUtils.GetControlNamed(form, "moveButton", true);
            deleteButton = (Button)TestUtils.GetControlNamed(form, "deleteButton", true);
        }

        [Fact]
        // Description: Should have all the controls `leftTreeView`, `rightTreeView`, `nodeNameTextBox`, `addButton`, `updateButton`, and `deleteButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(form);
            Assert.NotNull(leftTreeView);
            Assert.NotNull(rightTreeView);
            Assert.NotNull(nodeNameTextBox);
            Assert.NotNull(addButton);
            Assert.NotNull(updateButton);
            Assert.NotNull(deleteButton);
        }

        [Fact]
        // Description: Should add a node to the `leftTreeView` when the `addButton` is clicked.
        public void ShouldAddNodeToleftTreeViewOnaddButtonClick()
        {
            nodeNameTextBox.Text = "Test Node";
            //Select a node from treeview1
            leftTreeView.SelectedNode = leftTreeView.Nodes[0];

            addButton?.PerformClick();

            // Assert
            Assert.Equal("Test Node", leftTreeView.SelectedNode.Text);
        }

        [Fact]
        // Description: Should add a node to the `rightTreeView` when the `addButton` is clicked.
        public void ShouldAddNodeTorightTreeViewOnAddButtonClick()
        {
            nodeNameTextBox.Text = "Test Node";
            //Select a node from treeview1
            rightTreeView.SelectedNode = rightTreeView.Nodes[0];

            addButton?.PerformClick();

            // Assert
            Assert.Equal("Test Node", rightTreeView.SelectedNode.Text);
        }

        [Fact]
        // Description: Should update a node in the `leftTreeView` when the `updateButton` is clicked.
        public void ShouldUpdateNodeInleftTreeViewOnupdateButtonClick()
        {
            nodeNameTextBox.Text = "Test Node";
            //Select a node from treeview1
            leftTreeView.SelectedNode = leftTreeView.Nodes[0];

            updateButton.PerformClick();

            Assert.Equal("Test Node", leftTreeView.SelectedNode.Text);
        }

        [Fact]  
        // Description: Should update a node in the `rightTreeView` when the `updateButton` is clicked.
        public void ShouldUpdateNodeInrightTreeViewOnupdateButtonClick()
        {
            nodeNameTextBox.Text = "Test Node";
            //Select a node from treeview1
            rightTreeView.SelectedNode = rightTreeView.Nodes[0];

            updateButton.PerformClick();

            Assert.Equal("Test Node", rightTreeView.SelectedNode.Text);
        }

        [Fact]
        // Description: Should move a node from the `leftTreeView` to the `rightTreeView` when the `moveButton` is clicked.
        public void ShouldMoveNodeFromLeftToRightTreeViewOnMoveButtonClick()
        {
            //Select a node from treeview1
            leftTreeView.SelectedNode = leftTreeView.Nodes[0];

            int count = rightTreeView.Nodes.Count;

            moveButton.PerformClick();

            Assert.Equal(count + 1, rightTreeView.Nodes.Count);
        }

        [Fact]
        // Description: Should move a node from the `rightTreeView` to the `leftTreeView` when the `moveButton` is clicked.
        public void ShouldDeleteNodeInleftTreeViewOndeleteButtonClick()
        {
            //Select a node from treeview1
            leftTreeView.SelectedNode = leftTreeView.Nodes[0];

            int count = leftTreeView.Nodes.Count;

            deleteButton.PerformClick();

            Assert.Equal(count - 1, leftTreeView.Nodes.Count);
        }

        [Fact]
        // Description: Should delete a node from the `rightTreeView` when the `deleteButton` is clicked.
        public void ShouldDeleteNodeInrightTreeViewOndeleteButtonClick()
        {
            //Select a node from treeview1
            rightTreeView.SelectedNode = rightTreeView.Nodes[0];

            int count = rightTreeView.Nodes.Count;

            deleteButton.PerformClick();

            Assert.Equal(count - 1, rightTreeView.Nodes.Count);
        }
    }
}
