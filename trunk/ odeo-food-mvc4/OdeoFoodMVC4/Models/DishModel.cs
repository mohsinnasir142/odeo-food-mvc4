using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace OdeoFoodMVC4.Models
{
    public class DishModel
    {

        public DataTable getAllDishes() {

            SqlConnection conn = ConnectionManager.getConnection();
            string query = "select itemId as ID,itemName as Name,itemPrice as Price,itemDescription as Description,itemImageUrl as Image from item ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public void InsertDishType(DishModelClasses model) {
            SqlConnection conn = ConnectionManager.getConnection();
            conn.Open();
            string query = "insert into itemtype values('"+model.DishCategoryTB+"','"+model.DishDescriptionTB+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<SelectListItem> getItemTypeNames()
        {
            SqlConnection conn = ConnectionManager.getConnection();
            string query = "select itemTypeCategory as category,itemTypeId as id from itemType ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<SelectListItem> items = new List<SelectListItem>();
            while(reader.Read()){
                items.Add(new SelectListItem { Text = reader["category"].ToString(), Value = reader["id"].ToString() + "+" + reader["category"].ToString() });
            }
            conn.Close();
            return items;
        }
        public void InsertDish(CreateDishModel model)
        {  
            SqlConnection conn = ConnectionManager.getConnection();
            conn.Open();
            string query = "insert into item values('" + model.ItemName + "'," + model.ItemPrice + ",'"+model.ItemDescription+"',"+model.ItemTypeFK+",'"+model.ItemImageUrl+"','"+model.ItemServing+"','"+model.itemDishType+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery(); 
            conn.Close();  
        }
        public DataTable getAllDishTypes()
        {

            SqlConnection conn = ConnectionManager.getConnection();
            string query = "select itemTypeId as ID ,itemTypeCategory as Category ,itemTypeDescription as Description from itemType ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }



    }
}