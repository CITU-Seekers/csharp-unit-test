namespace CodeChum.Tests
{
    public class InventoryManagementTest
    {
        InventoryManagementApp? form;
        InventoryManagementForm? addModal;
        InventoryManagementFormUpdate? updateModal;

        //Inventory Management Form
        ListView? itemsListView;
        Button? addItemButton;
        Button? updateItemButton;
        Button? deleteItemButton;

        //Add Item Form
        TextBox? itemNameTextBoxAdd;
        ComboBox? itemTypeComboBoxAdd;
        TextBox? itemIDTextBoxAdd;
        NumericUpDown? itemStockNumericUpDownAdd;
        TextBox? itemPriceTextBoxAdd;
        Button? addButton;
        Button? cancelButtonAdd;

        //Update Item Form
        TextBox? itemNameTextBoxUpdate;
        ComboBox? itemTypeComboBoxUpdate;
        TextBox? itemIDTextBoxUpdate;
        NumericUpDown? itemStockNumericUpDownUpdate;
        TextBox? itemPriceTextBoxUpdate;
        Button? updateButton;
        Button? cancelButtonUpdate;

        public InventoryManagementTest()
        {
            form = new InventoryManagementApp();
            form.Show();
            itemsListView = (ListView)TestUtils.GetControlNamed(form, "itemsListView", true);
            addItemButton = (Button)TestUtils.GetControlNamed(form, "addItemButton", true);
            updateItemButton = (Button)TestUtils.GetControlNamed(form, "updateItemButton", true);
            deleteItemButton = (Button)TestUtils.GetControlNamed(form, "deleteItemButton", true);
        }

        [Fact]
        // Description: Should have all the controls `itemsListView`, `addItemButton`, `updateItemButton`, and `deleteItemButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(itemsListView);
            Assert.NotNull(addItemButton);
            Assert.NotNull(updateItemButton);
            Assert.NotNull(deleteItemButton);
        }

        [Fact]
        // Description: Should have all the controls `itemNameTextBox`, `itemTypeComboBox`, `itemIDTextBox`, `itemStockNumericUpDown`, `itemPriceTextBox`, `addButton`, and `cancelButton` in add modal.
        public void ShouldHaveAllControlsInAddModal()
        {
            addModal = new InventoryManagementForm();
            addModal.Show();

            itemNameTextBoxAdd = (TextBox)TestUtils.GetControlNamed(addModal, "itemNameTextBox", true);
            itemTypeComboBoxAdd = (ComboBox)TestUtils.GetControlNamed(addModal, "itemTypeComboBox", true);
            itemIDTextBoxAdd = (TextBox)TestUtils.GetControlNamed(addModal, "itemIDTextBox", true);
            itemStockNumericUpDownAdd = (NumericUpDown)TestUtils.GetControlNamed(addModal, "itemStockNumericUpDown", true);
            itemPriceTextBoxAdd = (TextBox)TestUtils.GetControlNamed(addModal, "itemPriceTextBox", true);
            addButton = (Button)TestUtils.GetControlNamed(addModal, "addButton", true);
            cancelButtonAdd = (Button)TestUtils.GetControlNamed(addModal, "cancelButton", true);

            Assert.NotNull(itemNameTextBoxAdd);
            Assert.NotNull(itemTypeComboBoxAdd);
            Assert.NotNull(itemIDTextBoxAdd);
            Assert.NotNull(itemStockNumericUpDownAdd);
            Assert.NotNull(itemPriceTextBoxAdd);
            Assert.NotNull(addButton);
            Assert.NotNull(cancelButtonAdd);
        }

        [Fact]
        // Description: Should have all the controls `itemNameTextBox`, `itemTypeComboBox`, `itemIDTextBox`, `itemStockNumericUpDown`, `itemPriceTextBox`, `updateButton`, and `cancelButton` in update modal.
        public void ShouldHaveAllControlsInUpdateModal()
        {
            updateModal = new InventoryManagementFormUpdate();
            updateModal.Show();

            itemNameTextBoxUpdate = (TextBox)TestUtils.GetControlNamed(updateModal, "itemNameTextBox", true);
            itemTypeComboBoxUpdate = (ComboBox)TestUtils.GetControlNamed(updateModal, "itemTypeComboBox", true);
            itemIDTextBoxUpdate = (TextBox)TestUtils.GetControlNamed(updateModal, "itemIDTextBox", true);
            itemStockNumericUpDownUpdate = (NumericUpDown)TestUtils.GetControlNamed(updateModal, "itemStockNumericUpDown", true);
            itemPriceTextBoxUpdate = (TextBox)TestUtils.GetControlNamed(updateModal, "itemPriceTextBox", true);
            updateButton = (Button)TestUtils.GetControlNamed(updateModal, "updateButton", true);
            cancelButtonUpdate = (Button)TestUtils.GetControlNamed(updateModal, "cancelButton", true);

        }

        [Fact]
        // Description: Should open add modal when `addItemButton` is clicked.
        public void ShouldOpenAddModal()
        {
            bool isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                isModalShown = form.addForm.Visible;
                form.addForm.Close();
            });

            addItemButton.PerformClick();
            registerTask.Wait();
            Assert.True(isModalShown);
        }

        [Fact]
        // Description: Should close add modal when `cancelButton` is clicked.
        public void ShouldCloseAddModal()
        {
            bool isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                cancelButtonAdd = (Button)TestUtils.GetControlNamed(form.addForm, "cancelButton", true);
                cancelButtonAdd.PerformClick();
                await Task.Delay(TimeSpan.FromSeconds(3));
                isModalShown = form.addForm.Visible;
            });

            addItemButton.PerformClick();
            registerTask.Wait();
            Assert.False(isModalShown);
        }

        [Fact]
        // Description: Should open update modal when `updateItemButton` is clicked.
        public void ShouldOpenUpdateModal()
        {
            bool isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                isModalShown = form.updateForm.Visible;
                form.updateForm.Close();
            });

            string[] sampleItem = { "Food", "001", "FunChum", "10", "10.50" };
            itemsListView.Items.Add(new ListViewItem(sampleItem));

            itemsListView.Items[0].Selected = true;

            updateItemButton.PerformClick();
            registerTask.Wait();
            Assert.True(isModalShown);
        }

        [Fact]
        // Description: Should close update modal when `cancelButton` is clicked.
        public void ShouldCloseUpdateModal()
        {
            bool isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                cancelButtonUpdate = (Button)TestUtils.GetControlNamed(form.updateForm, "cancelButton", true);
                cancelButtonUpdate.PerformClick();
                await Task.Delay(TimeSpan.FromSeconds(3));
                isModalShown = form.updateForm.Visible;
            });

            string[] sampleItem = { "Food", "001", "FunChum", "10", "10.50" };
            itemsListView.Items.Add(new ListViewItem(sampleItem));

            itemsListView.Items[0].Selected = true;

            updateItemButton.PerformClick();
            registerTask.Wait();
            Assert.False(isModalShown);
        }

        [Fact]
        // Description: Should add item with name "Test Item", type "Food", ID "123456", stock "10", and price "100" when `addButton` is clicked.
        public void ShouldAddItem()
        {
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(10));
                itemNameTextBoxAdd = (TextBox)TestUtils.GetControlNamed(form.addForm, "itemNameTextBox", true);
                itemTypeComboBoxAdd = (ComboBox)TestUtils.GetControlNamed(form.addForm, "itemTypeComboBox", true);
                itemIDTextBoxAdd = (TextBox)TestUtils.GetControlNamed(form.addForm, "itemIDTextBox", true);
                itemStockNumericUpDownAdd = (NumericUpDown)TestUtils.GetControlNamed(form.addForm, "itemStockNumericUpDown", true);
                itemPriceTextBoxAdd = (TextBox)TestUtils.GetControlNamed(form.addForm, "itemPriceTextBox", true);
                addButton = (Button)TestUtils.GetControlNamed(form.addForm, "addButton", true);
                cancelButtonAdd = (Button)TestUtils.GetControlNamed(form.addForm, "cancelButton", true);

                itemNameTextBoxAdd.Text = "Test Item";
                itemTypeComboBoxAdd.SelectedIndex = 0;
                itemIDTextBoxAdd.Text = "123456";
                itemStockNumericUpDownAdd.Value = 10;
                itemPriceTextBoxAdd.Text = "100";

                addButton.PerformClick();

                form.addForm.Close();
            });

            addItemButton.PerformClick();
            registerTask.Wait();
            Assert.Equal(1, itemsListView.Items.Count);
        }

        [Fact]
        // Description: Should show "Food" in `itemTypeComboBox`, "001" in `itemIDTextBox`, "FunChum" in `itemNameTextBox`, "10" in `itemStockNumericUpDown`, and "10.50" in `itemPriceTextBox` when click `updateItemButton`.
        public void ShouldShowItemDetailsWhenClickUpdateButton()
        {
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                itemNameTextBoxUpdate = (TextBox)TestUtils.GetControlNamed(form.updateForm, "itemNameTextBox", true);
                itemTypeComboBoxUpdate = (ComboBox)TestUtils.GetControlNamed(form.updateForm, "itemTypeComboBox", true);
                itemIDTextBoxUpdate = (TextBox)TestUtils.GetControlNamed(form.updateForm, "itemIDTextBox", true);
                itemStockNumericUpDownUpdate = (NumericUpDown)TestUtils.GetControlNamed(form.updateForm, "itemStockNumericUpDown", true);
                itemPriceTextBoxUpdate = (TextBox)TestUtils.GetControlNamed(form.updateForm, "itemPriceTextBox", true);
                updateButton = (Button)TestUtils.GetControlNamed(form.updateForm, "updateButton", true);
                cancelButtonUpdate = (Button)TestUtils.GetControlNamed(form.updateForm, "cancelButton", true);

                form.updateForm.Close();
            });

            string[] sampleItem = { "Food", "001", "FunChum", "10", "10.50" };
            itemsListView.Items.Add(new ListViewItem(sampleItem));

            itemsListView.Items[0].Selected = true;

            updateItemButton.PerformClick();

            registerTask.Wait();
            Assert.Equal("Food", itemTypeComboBoxUpdate.SelectedItem.ToString());
            Assert.Equal("001", itemIDTextBoxUpdate.Text);
            Assert.Equal("FunChum", itemNameTextBoxUpdate.Text);
            Assert.Equal(10, itemStockNumericUpDownUpdate.Value);
            Assert.Equal("10.50", itemPriceTextBoxUpdate.Text);
        }

        [Fact]
        // Description: Should update item with name "Test Item", type "Food", ID "123456", stock "10", and price "100" when `updateButton` is clicked.
        public void ShouldUpdateItem()
        {
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                itemNameTextBoxUpdate = (TextBox)TestUtils.GetControlNamed(form.updateForm, "itemNameTextBox", true);
                itemTypeComboBoxUpdate = (ComboBox)TestUtils.GetControlNamed(form.updateForm, "itemTypeComboBox", true);
                itemIDTextBoxUpdate = (TextBox)TestUtils.GetControlNamed(form.updateForm, "itemIDTextBox", true);
                itemStockNumericUpDownUpdate = (NumericUpDown)TestUtils.GetControlNamed(form.updateForm, "itemStockNumericUpDown", true);
                itemPriceTextBoxUpdate = (TextBox)TestUtils.GetControlNamed(form.updateForm, "itemPriceTextBox", true);
                updateButton = (Button)TestUtils.GetControlNamed(form.updateForm, "updateButton", true);
                cancelButtonUpdate = (Button)TestUtils.GetControlNamed(form.updateForm, "cancelButton", true);
  
                itemIDTextBoxUpdate.Text = "123456";
                itemNameTextBoxUpdate.Text = "Test Item";
                itemStockNumericUpDownUpdate.Value = 10;
                itemPriceTextBoxUpdate.Text = "100";

                updateButton.PerformClick();

                form.updateForm.Close();
            });

            string[] sampleItem = { "Food", "001", "FunChum", "10", "10.50" };
            itemsListView.Items.Add(new ListViewItem(sampleItem));

            itemsListView.Items[0].Selected = true;

            updateItemButton.PerformClick();
            registerTask.Wait();

            Assert.Equal("Food", itemsListView.Items[0].SubItems[0].Text);
            Assert.Equal("123456", itemsListView.Items[0].SubItems[1].Text);
            Assert.Equal("Test Item", itemsListView.Items[0].SubItems[2].Text);
            Assert.Equal("10", itemsListView.Items[0].SubItems[3].Text);
            Assert.Equal("100", itemsListView.Items[0].SubItems[4].Text);
        }

        [Fact]
        // Description: Should delete item when `deleteItemButton` is clicked.
        public void ShouldDeleteItem()
        {
            string[] sampleItem = { "Food", "001", "FunChum", "10", "10.50" };
            itemsListView.Items.Add(new ListViewItem(sampleItem));

            itemsListView.Items[0].Selected = true;

            deleteItemButton.PerformClick();

            Assert.Equal(0, itemsListView.Items.Count);
        }
    }
}
