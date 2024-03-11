namespace CodeChum.Tests
{
    public class TreeViewNodesCRUDTests
    {
        TreeViewNodesCRUD? form;
        TreeView? MainTreeView;
        TextBox? NameTextBox;
        CheckBox? MainNodeCheckBox;
        Button? AddNodeButton, RemoveNodeButton, UpdateNodeButton;
        Label? PathLabel;

        public TreeViewNodesCRUDTests()
        {
            form = new TreeViewNodesCRUD();
            form.Show();
            MainTreeView = (TreeView)TestUtils.GetControlNamed(form, "MainTreeView", true);
            NameTextBox = (TextBox)TestUtils.GetControlNamed(form, "NameTextBox", true);
            MainNodeCheckBox = (CheckBox)TestUtils.GetControlNamed(form, "MainNodeCheckBox", true);
            AddNodeButton = (Button)TestUtils.GetControlNamed(form, "AddNodeButton", true);
            RemoveNodeButton = (Button)TestUtils.GetControlNamed(form, "RemoveNodeButton", true);
            UpdateNodeButton = (Button)TestUtils.GetControlNamed(form, "UpdateNodeButton", true);
            PathLabel = (Label)TestUtils.GetControlNamed(form, "PathLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(MainTreeView);
            Assert.NotNull(NameTextBox);
            Assert.NotNull(MainNodeCheckBox);
            Assert.NotNull(AddNodeButton);
            Assert.NotNull(RemoveNodeButton);
            Assert.NotNull(UpdateNodeButton);
            Assert.NotNull(PathLabel);
        }

        [Fact]
        public void ShouldAddNewNodeWithText()
        {
            string test = "test";

            NameTextBox.Text = test;
            AddNodeButton.PerformClick();

            Assert.Equal(test, MainTreeView.Nodes[0].Text);
        }

        [Fact]
        public void ShouldAddNewNodeOnTopIfCheckBoxIsToggled()
        {
            string test = "test";
            string test0 = "test0";

            NameTextBox.Text = test;
            AddNodeButton.PerformClick();
            MainNodeCheckBox.Checked = true;
            NameTextBox.Text = test0;
            AddNodeButton.PerformClick();

            Assert.Equal(test0, MainTreeView.Nodes[0].Text);
        }

        [Fact]
        public void ShouldAddChildNodeOnSelectedNode()
        {
            string test = "test";
            string test0 = "test0";

            NameTextBox.Text = test;
            AddNodeButton.PerformClick();
            MainTreeView.SelectedNode = MainTreeView.Nodes[0];
            NameTextBox.Text = test0;
            AddNodeButton.PerformClick();

            Assert.Equal(test0, MainTreeView.Nodes[0].Nodes[0].Text);
        }

        [Fact]
        public void ShouldRemoveSelectedNode()
        {
            string test = "test";

            NameTextBox.Text = test;
            AddNodeButton.PerformClick();
            MainTreeView.SelectedNode = MainTreeView.Nodes[0];
            RemoveNodeButton.PerformClick();

            Assert.Empty(MainTreeView.Nodes);
        }

        [Fact]
        public void ShouldRemoveSelectedChildNode()
        {
            string test = "test";
            string test0 = "test0";

            MainTreeView.Nodes.Add(test);
            MainTreeView.SelectedNode = MainTreeView.Nodes[0];
            MainTreeView.SelectedNode.Nodes.Add(test);
            MainTreeView.SelectedNode = MainTreeView.Nodes[0].Nodes[0];
            RemoveNodeButton.PerformClick();

            Assert.True(MainTreeView.Nodes[0].Nodes.Count == 0, "The child node should have been deleted.");
        }

        [Fact]
        public void ShouldUpdateSelectedNode()
        {
            string test = "test";
            string test0 = "test0";

            NameTextBox.Text = test;
            AddNodeButton.PerformClick();
            NameTextBox.Text = test0;
            MainTreeView.SelectedNode = MainTreeView.Nodes[0];
            UpdateNodeButton.PerformClick();

            Assert.Equal(test0, MainTreeView.Nodes[0].Text);
        }

        [Fact]
        public void ShouldUpdatePathLabelOnSelect()
        {
            string test = "test";

            MainTreeView.Nodes.Add(test);
            MainTreeView.SelectedNode = MainTreeView.Nodes[0];

            Assert.Equal(test, PathLabel.Text);
        }

        [Fact]
        public void ShouldUpdatePathLabelForChildNodes()
        {
            string test = "test";
            string expectedPath = "test\\test";

            MainTreeView.Nodes.Add(test);
            MainTreeView.SelectedNode = MainTreeView.Nodes[0];
            MainTreeView.SelectedNode.Nodes.Add(test);
            MainTreeView.SelectedNode = MainTreeView.Nodes[0].Nodes[0];

            Assert.Equal(expectedPath, PathLabel.Text);
        }
    }
}