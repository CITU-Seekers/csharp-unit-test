namespace CodeChum.Tests
{
    public class TreeViewNodesCRUDTests
    {
        TreeViewNodesCRUD? form;
        TreeView? mainTreeView;
        TextBox? nameTextBox;
        CheckBox? mainNodeCheckBox;
        Button? addNodeButton, removeNodeButton, updateNodeButton;
        Label? pathLabel;

        public TreeViewNodesCRUDTests()
        {
            form = new TreeViewNodesCRUD();
            form.Show();
            mainTreeView = (TreeView)TestUtils.GetControlNamed(form, "mainTreeView", true);
            nameTextBox = (TextBox)TestUtils.GetControlNamed(form, "nameTextBox", true);
            mainNodeCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "mainNodeCheckBox", true);
            addNodeButton = (Button)TestUtils.GetControlNamed(form, "addNodeButton", true);
            removeNodeButton = (Button)TestUtils.GetControlNamed(form, "removeNodeButton", true);
            updateNodeButton = (Button)TestUtils.GetControlNamed(form, "updateNodeButton", true);
            pathLabel = (Label)TestUtils.GetControlNamed(form, "pathLabel", true);
        }

        [Fact]
        // Description: Should have all the controls `mainTreeView`, `nameTextBox`, `mainNodeCheckBox`, `addNodeButton`, `removeNodeButton`, `updateNodeButton`, and `pathLabel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(mainTreeView);
            Assert.NotNull(nameTextBox);
            Assert.NotNull(mainNodeCheckBox);
            Assert.NotNull(addNodeButton);
            Assert.NotNull(removeNodeButton);
            Assert.NotNull(updateNodeButton);
            Assert.NotNull(pathLabel);
        }

        [Fact]
        // Description: Should create a node at the top level if there are no existing nodes on `addNoteButton` click.
        public void ShouldAddNewNodeWithText()
        {
            string test = "test";

            nameTextBox.Text = test;
            addNodeButton.PerformClick();

            Assert.Equal(test, mainTreeView.Nodes[0].Text);
        }

        [Fact]
        // Description: Should create a node at the top level if the `mainNodeCheckBox` is checked on `addNoteButton` click.
        public void ShouldAddNewNodeOnTopIfCheckBoxIsToggled()
        {
            string test = "test";
            string test0 = "test0";

            nameTextBox.Text = test;
            addNodeButton.PerformClick();
            mainNodeCheckBox.Checked = true;
            nameTextBox.Text = test0;
            addNodeButton.PerformClick();

            Assert.Equal(test0, mainTreeView.Nodes[0].Text);
        }

        [Fact]
        // Description: Should add a child node on the selected node on `addNodeButton` click.
        public void ShouldAddChildNodeOnSelectedNode()
        {
            string test = "test";
            string test0 = "test0";

            nameTextBox.Text = test;
            addNodeButton.PerformClick();
            mainTreeView.SelectedNode = mainTreeView.Nodes[0];
            nameTextBox.Text = test0;
            addNodeButton.PerformClick();

            Assert.Equal(test0, mainTreeView.Nodes[0].Nodes[0].Text);
        }

        [Fact]
        // Description: Should remove the selected node on `removeNodeButton` click.
        public void ShouldRemoveSelectedNode()
        {
            string test = "test";

            nameTextBox.Text = test;
            addNodeButton.PerformClick();
            mainTreeView.SelectedNode = mainTreeView.Nodes[0];
            removeNodeButton.PerformClick();

            Assert.Empty(mainTreeView.Nodes);
        }

        [Fact]
        // Description: Should remove the selected child node on `removeNodeButton` click.
        public void ShouldRemoveSelectedChildNode()
        {
            string test = "test";
            string test0 = "test0";

            mainTreeView.Nodes.Add(test);
            mainTreeView.SelectedNode = mainTreeView.Nodes[0];
            mainTreeView.SelectedNode.Nodes.Add(test);
            mainTreeView.SelectedNode = mainTreeView.Nodes[0].Nodes[0];
            removeNodeButton.PerformClick();

            Assert.True(mainTreeView.Nodes[0].Nodes.Count == 0, "The child node should have been deleted.");
        }

        [Fact]
        // Description: Should update the name of the selected node on `updateNodeButton` click.
        public void ShouldUpdateSelectedNode()
        {
            string test = "test";
            string test0 = "test0";

            nameTextBox.Text = test;
            addNodeButton.PerformClick();
            nameTextBox.Text = test0;
            mainTreeView.SelectedNode = mainTreeView.Nodes[0];
            updateNodeButton.PerformClick();

            Assert.Equal(test0, mainTreeView.Nodes[0].Text);
        }

        [Fact]
        // Description: Should display full path of the selected top level nodes in the `pathLabel`.
        public void ShouldUpdatePathLabelOnSelect()
        {
            string test = "test";

            mainTreeView.Nodes.Add(test);
            mainTreeView.SelectedNode = mainTreeView.Nodes[0];

            Assert.Equal(test, pathLabel.Text);
        }

        [Fact]
        // Description: Should display full path of the selected child nodes in the `pathLabel`.
        public void ShouldUpdatePathLabelForChildNodes()
        {
            string test = "test";
            string expectedPath = "test\\test";

            mainTreeView.Nodes.Add(test);
            mainTreeView.SelectedNode = mainTreeView.Nodes[0];
            mainTreeView.SelectedNode.Nodes.Add(test);
            mainTreeView.SelectedNode = mainTreeView.Nodes[0].Nodes[0];

            Assert.Equal(expectedPath, pathLabel.Text);
        }
    }
}