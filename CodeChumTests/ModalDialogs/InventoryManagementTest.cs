namespace CodeChum.Tests
{
    public class InventoryManagementTest
    {
        InventoryManagementApp? form;
        InventoryManagementForm? addModal;
        InventoryManagementFormUpdate? updateModal;

        //Inventory Management Form
        ListView? ItemList;
        Button? btnAddItem;
        Button? btnUpdateItem;
        Button? btnDeleteItem;

        //Add Item Form
        TextBox? txtItemName;
        ComboBox? cboItemType;
        TextBox? txtItemID;
        NumericUpDown? numericItemStock;
        TextBox? txtItemPrice;
        Button? btnAdd;
        Button? btnCancel;

        //Update Item Form
        TextBox? txtItemNameUpdate;
        ComboBox? cboItemTypeUpdate;
        TextBox? txtItemIDUpdate;
        NumericUpDown? numericItemStockUpdate;
        TextBox? txtItemPriceUpdate;
        Button? btnUpdate;
        Button? btnCancelUpdate;

        public InventoryManagementTest()
        {
            form = new InventoryManagementApp();
            form.Show();
            ItemList = (ListView)TestUtils.GetControlNamed(form, "ItemList", true);
            btnAddItem = (Button)TestUtils.GetControlNamed(form, "btnAddItem", true);
            btnUpdateItem = (Button)TestUtils.GetControlNamed(form, "btnUpdateItem", true);
            btnDeleteItem = (Button)TestUtils.GetControlNamed(form, "btnDeleteItem", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(ItemList);
            Assert.NotNull(btnAddItem);
            Assert.NotNull(btnUpdateItem);
            Assert.NotNull(btnDeleteItem);
        }

        [Fact]
        public void ShouldHaveAllControlsInAddModal()
        {
            addModal = new InventoryManagementForm();
            addModal.Show();

            txtItemName = (TextBox)TestUtils.GetControlNamed(addModal, "txtItemName", true);
            cboItemType = (ComboBox)TestUtils.GetControlNamed(addModal, "cboItemType", true);
            txtItemID = (TextBox)TestUtils.GetControlNamed(addModal, "txtItemID", true);
            numericItemStock = (NumericUpDown)TestUtils.GetControlNamed(addModal, "numericItemStock", true);
            txtItemPrice = (TextBox)TestUtils.GetControlNamed(addModal, "txtItemPrice", true);
            btnAdd = (Button)TestUtils.GetControlNamed(addModal, "btnAdd", true);
            btnCancel = (Button)TestUtils.GetControlNamed(addModal, "btnCancel", true);

            Assert.NotNull(txtItemName);
            Assert.NotNull(cboItemType);
            Assert.NotNull(txtItemID);
            Assert.NotNull(numericItemStock);
            Assert.NotNull(txtItemPrice);
            Assert.NotNull(btnAdd);
            Assert.NotNull(btnCancel);
        }

        [Fact]
        public void ShouldHaveAllControlsInUpdateModal()
        {
            updateModal = new InventoryManagementFormUpdate();
            updateModal.Show();

            txtItemNameUpdate = (TextBox)TestUtils.GetControlNamed(updateModal, "txtItemName", true);
            cboItemTypeUpdate = (ComboBox)TestUtils.GetControlNamed(updateModal, "cboItemType", true);
            txtItemIDUpdate = (TextBox)TestUtils.GetControlNamed(updateModal, "txtItemID", true);
            numericItemStockUpdate = (NumericUpDown)TestUtils.GetControlNamed(updateModal, "numericItemStock", true);
            txtItemPriceUpdate = (TextBox)TestUtils.GetControlNamed(updateModal, "txtItemPrice", true);
            btnUpdate = (Button)TestUtils.GetControlNamed(updateModal, "btnUpdate", true);
            btnCancelUpdate = (Button)TestUtils.GetControlNamed(updateModal, "btnCancel", true);

            Assert.NotNull(txtItemNameUpdate);
            Assert.NotNull(cboItemTypeUpdate);
            Assert.NotNull(txtItemIDUpdate);
            Assert.NotNull(numericItemStockUpdate);
            Assert.NotNull(txtItemPriceUpdate);
            Assert.NotNull(btnUpdate);
            Assert.NotNull(btnCancelUpdate);
        }

        [Fact]
        public void ShouldOpenAddModal()
        {
            Boolean isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                isModalShown = form.addForm.Visible;
                form.addForm.Close();
            });

            btnAddItem.PerformClick();
            registerTask.Wait();
            Assert.True(isModalShown);
        }

        [Fact]
        public void ShouldCloseAddModal()
        {
            Boolean isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                btnCancel = (Button)TestUtils.GetControlNamed(form.addForm, "btnCancel", true);
                btnCancel.PerformClick();
                await Task.Delay(TimeSpan.FromSeconds(3));
                isModalShown = form.addForm.Visible;
            });

            btnAddItem.PerformClick();
            registerTask.Wait();
            Assert.False(isModalShown);
        }

        [Fact]
        public void ShouldOpenUpdateModal()
        {
            Boolean isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                isModalShown = form.updateForm.Visible;
                form.updateForm.Close();
            });

            string[] sampleItem = { "Food", "001", "FunChum", "10", "10.50" };
            ItemList.Items.Add(new ListViewItem(sampleItem));

            ItemList.Items[0].Selected = true;

            btnUpdateItem.PerformClick();
            registerTask.Wait();
            Assert.True(isModalShown);
        }

        [Fact]
        public void ShouldCloseUpdateModal()
        {
            Boolean isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                btnCancelUpdate = (Button)TestUtils.GetControlNamed(form.updateForm, "btnCancel", true);
                btnCancelUpdate.PerformClick();
                await Task.Delay(TimeSpan.FromSeconds(3));
                isModalShown = form.updateForm.Visible;
            });

            string[] sampleItem = { "Food", "001", "FunChum", "10", "10.50" };
            ItemList.Items.Add(new ListViewItem(sampleItem));

            ItemList.Items[0].Selected = true;

            btnUpdateItem.PerformClick();
            registerTask.Wait();
            Assert.False(isModalShown);
        }

        [Fact]
        public void ShouldAddItem()
        {
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                txtItemName = (TextBox)TestUtils.GetControlNamed(form.addForm, "txtItemName", true);
                cboItemType = (ComboBox)TestUtils.GetControlNamed(form.addForm, "cboItemType", true);
                txtItemID = (TextBox)TestUtils.GetControlNamed(form.addForm, "txtItemID", true);
                numericItemStock = (NumericUpDown)TestUtils.GetControlNamed(form.addForm, "numericItemStock", true);
                txtItemPrice = (TextBox)TestUtils.GetControlNamed(form.addForm, "txtItemPrice", true);
                btnAdd = (Button)TestUtils.GetControlNamed(form.addForm, "btnAdd", true);
                btnCancel = (Button)TestUtils.GetControlNamed(form.addForm, "btnCancel", true);

                txtItemName.Text = "Test Item";
                cboItemType.SelectedIndex = 0;
                txtItemID.Text = "123456";
                numericItemStock.Value = 10;
                txtItemPrice.Text = "100";    
                
                btnAdd.PerformClick();
            });

            btnAddItem.PerformClick();
            registerTask.Wait();
            Assert.Equal(1, ItemList.Items.Count);
        }

        [Fact]
        public void ShouldShowItemDetailsWhenClickUpdateButton()
        {
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                txtItemNameUpdate = (TextBox)TestUtils.GetControlNamed(form.updateForm, "txtItemName", true);
                cboItemTypeUpdate = (ComboBox)TestUtils.GetControlNamed(form.updateForm, "cboItemType", true);
                txtItemIDUpdate = (TextBox)TestUtils.GetControlNamed(form.updateForm, "txtItemID", true);
                numericItemStockUpdate = (NumericUpDown)TestUtils.GetControlNamed(form.updateForm, "numericItemStock", true);
                txtItemPriceUpdate = (TextBox)TestUtils.GetControlNamed(form.updateForm, "txtItemPrice", true);
                btnUpdate = (Button)TestUtils.GetControlNamed(form.updateForm, "btnUpdate", true);
                btnCancelUpdate = (Button)TestUtils.GetControlNamed(form.updateForm, "btnCancel", true);

                form.updateForm.Close();
            });

            string[] sampleItem = { "Food", "001", "FunChum", "10", "10.50" };
            ItemList.Items.Add(new ListViewItem(sampleItem));

            ItemList.Items[0].Selected = true;

            btnUpdateItem.PerformClick();

            registerTask.Wait();
            Assert.Equal("Food", cboItemTypeUpdate.SelectedItem.ToString());
            Assert.Equal("001", txtItemIDUpdate.Text);
            Assert.Equal("FunChum", txtItemNameUpdate.Text);
            Assert.Equal("10", numericItemStockUpdate.Value.ToString());
            Assert.Equal("10.50", txtItemPriceUpdate.Text);
        }

        [Fact]
        public void ShouldUpdateItem()
        {
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                txtItemNameUpdate = (TextBox)TestUtils.GetControlNamed(form.updateForm, "txtItemName", true);
                cboItemTypeUpdate = (ComboBox)TestUtils.GetControlNamed(form.updateForm, "cboItemType", true);
                txtItemIDUpdate = (TextBox)TestUtils.GetControlNamed(form.updateForm, "txtItemID", true);
                numericItemStockUpdate = (NumericUpDown)TestUtils.GetControlNamed(form.updateForm, "numericItemStock", true);
                txtItemPriceUpdate = (TextBox)TestUtils.GetControlNamed(form.updateForm, "txtItemPrice", true);
                btnUpdate = (Button)TestUtils.GetControlNamed(form.updateForm, "btnUpdate", true);
                btnCancelUpdate = (Button)TestUtils.GetControlNamed(form.updateForm, "btnCancel", true);

                cboItemTypeUpdate.SelectedIndex = 0;
                txtItemIDUpdate.Text = "123456";
                txtItemNameUpdate.Text = "Test Item";
                numericItemStockUpdate.Value = 10;
                txtItemPriceUpdate.Text = "100";

                btnUpdate.PerformClick();
            });

            string[] sampleItem = { "Food", "001", "FunChum", "10", "10.50" };
            ItemList.Items.Add(new ListViewItem(sampleItem));

            ItemList.Items[0].Selected = true;

            btnUpdateItem.PerformClick();
            registerTask.Wait();

            Assert.Equal("Food", ItemList.Items[0].SubItems[0].Text);
            Assert.Equal("123456", ItemList.Items[0].SubItems[1].Text);
            Assert.Equal("Test Item", ItemList.Items[0].SubItems[2].Text);
            Assert.Equal("10", ItemList.Items[0].SubItems[3].Text);
            Assert.Equal("100", ItemList.Items[0].SubItems[4].Text);
        }

        [Fact]
        public void ShouldDeleteItem()
        {
            string[] sampleItem = { "Food", "001", "FunChum", "10", "10.50" };
            ItemList.Items.Add(new ListViewItem(sampleItem));

            ItemList.Items[0].Selected = true;

            btnDeleteItem.PerformClick();

            Assert.Equal(0, ItemList.Items.Count);
        }
    }
}
