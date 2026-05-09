using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace nituz_project_23
{
    public class InventoryItem
    {
        private int inventoryItemID;
        private string name;
        private ItemCategory category;
        private int quantity;
        private int maxQuantity;
        private int minQuantity;
        private string description;

        public InventoryItem(int inventoryItemID, string name, ItemCategory category, int quantity,
        int maxQuantity, int minQuantity, string description, Boolean isNew)
        {

            this.inventoryItemID = inventoryItemID;
            this.name = name;
            this.category = category;
            this.quantity = quantity;
            this.maxQuantity = maxQuantity;
            this.minQuantity = minQuantity;
            this.description = description;

            if (isNew)
            {
                this.createInventoryItem();
                Program.inventoryItems.Add(this);
            }

        }

        public void createInventoryItem()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_inventory_items @inventoryItemID, @name, @Category, @quantity, @maxQuantity, @minQuantity, @description";
            c.Parameters.AddWithValue("@inventoryItemID", this.inventoryItemID.ToString());
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@Category", this.category.ToString());
            c.Parameters.AddWithValue("@quantity", this.quantity.ToString());
            c.Parameters.AddWithValue("@maxQuantity", this.maxQuantity.ToString());
            c.Parameters.AddWithValue("@minQuantity", this.minQuantity.ToString());
            c.Parameters.AddWithValue("@description", this.description.ToString());

            SQL_CON SQLSC = new SQL_CON();
            int rowsAffected = SQLSC.execute_non_query(c);

            if (rowsAffected >= 1)
            {
                // הודעת הצלחה ורענון
                MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void updateInventoryItem(string name, ItemCategory category, int quantity, int maxQuantity, int minQuantity, string description)
        {
            this.name = name;
            this.category = category;
            this.quantity = quantity;
            this.maxQuantity = maxQuantity;
            this.minQuantity = minQuantity;
            this.description = description;
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_update_inventory_item  @inventoryItemID, @name, @Category, @quantity, @maxQuantity, @minQuantity, @description";
            c.Parameters.AddWithValue("@inventoryItemID", this.inventoryItemID.ToString());
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@Category", this.category.ToString());
            c.Parameters.AddWithValue("@quantity", this.quantity.ToString());
            c.Parameters.AddWithValue("@maxQuantity", this.maxQuantity.ToString());
            c.Parameters.AddWithValue("@minQuantity", this.minQuantity.ToString());
            c.Parameters.AddWithValue("@description", this.description.ToString());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void deleteInventoryItem()
        {
            Program.inventoryItems.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_inventory_item @inventoryItemID";
            c.Parameters.AddWithValue("@inventoryItemID", this.inventoryItemID.ToString());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public int getInventoryItemID()
        {
            return this.inventoryItemID;
        }

        public string getName()
        {
            return this.name;
        }

        public ItemCategory getCategory()
        {
            return this.category;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public int getMaxQuantity()
        {
            return this.maxQuantity;
        }

        public int getMinQuantity()
        {
            return this.minQuantity;
        }

        public string getDescription()
        {
            return this.description;
        }

    }
}
