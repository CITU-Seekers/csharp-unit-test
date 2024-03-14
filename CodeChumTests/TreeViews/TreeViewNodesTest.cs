namespace CodeChum.Tests
{
    public class TreeViewNodesTests
    {
        TreeViewNodes? form;
        TreeView? mainTreeView;
        TextBox? nameTextBox;
        CheckBox? mainNodeCheckBox;
        Button? addNodeButton, removeNodeButton;

        public TreeViewNodesTests()
        {
            form = new TreeViewNodes();
            form.Show();
            mainTreeView = (TreeView)TestUtils.GetControlNamed(form, "mainTreeView", true);
            nameTextBox = (TextBox)TestUtils.GetControlNamed(form, "nameTextBox", true);
            mainNodeCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "mainNodeCheckBox", true);
            addNodeButton = (Button)TestUtils.GetControlNamed(form, "addNodeButton", true);
            removeNodeButton = (Button)TestUtils.GetControlNamed(form, "removeNodeButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(mainTreeView);
            Assert.NotNull(nameTextBox);
            Assert.NotNull(mainNodeCheckBox);
            Assert.NotNull(addNodeButton);
            Assert.NotNull(removeNodeButton);
        }

        [Fact]
        public void ShouldAddNewNodeWithText()
        {
            string test = "test";

            nameTextBox.Text = test;
            addNodeButton.PerformClick();

            Assert.Equal(test, mainTreeView.Nodes[0].Text);
        }

        [Fact]
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
        public void ShouldRemoveSelectedNode()
        {
            string test = "test";

            mainTreeView.Nodes.Add(test);
            mainTreeView.SelectedNode = mainTreeView.Nodes[0];
            removeNodeButton.PerformClick();

            Assert.Empty(mainTreeView.Nodes);
        }

        [Fact]
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
    }
}