﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Models
{
    class StatisticsModel
    {
        public DataSet FillDataSetUnpaid()
        {

            string sqlBills = "SELECT BillCode, Name , Phone , FullName, BillDate , Total FROM dbo.Customers , dbo.Bills, dbo.Users WHERE dbo.Customers.ID = dbo.Bills.CusID AND UserID = Users.ID AND Paid IS NULL";
            string sqlBillDetails = "SELECT BillDetails.BillCode, ServiceName, BillDetails.Price, Quantity, BillDetails.Total FROM dbo.Services, dbo.BillDetails WHERE dbo.BillDetails.ServID = dbo.Services.ID";


            DataTable bills = new DataTable();
            bills = Models.Connection.FillDataTable(sqlBills);
            DataTable billDetails = new DataTable();
            billDetails = Models.Connection.FillDataTable(sqlBillDetails);

            bills.TableName = "Bills";
            billDetails.TableName = "Units";

            DataSet ds = new DataSet();
            ds = new DataSet();
            ds.Tables.Add(bills);
            ds.Tables.Add(billDetails);

            DataRelation dr = new DataRelation("Test", bills.Columns["BillCode"], billDetails.Columns["BillCode"], false);


            try
            {

                ds.Relations.Add(ds.Tables["Bills"].Columns["BillCode"], ds.Tables["Units"].Columns["BillCode"]);

            }
            catch (Exception ex)
            { }

            return ds;
        }


        public DataSet FillDataSetPaid()
        {

            string sqlBills = "SELECT BillCode, Name , Phone , FullName, BillDate , Total FROM dbo.Customers , dbo.Bills, dbo.Users WHERE dbo.Customers.ID = dbo.Bills.CusID AND UserID = Users.ID AND Paid IS NOT NULL";
            string sqlBillDetails = "SELECT BillDetails.BillCode, ServiceName, BillDetails.Price, Quantity, BillDetails.Total FROM dbo.Services, dbo.BillDetails WHERE dbo.BillDetails.ServID = dbo.Services.ID";


            DataTable bills = new DataTable();
            bills = Models.Connection.FillDataTable(sqlBills);
            DataTable billDetails = new DataTable();
            billDetails = Models.Connection.FillDataTable(sqlBillDetails);

            bills.TableName = "Bills";
            billDetails.TableName = "Units";

            DataSet ds = new DataSet();
            ds = new DataSet();
            ds.Tables.Add(bills);
            ds.Tables.Add(billDetails);

            DataRelation dr = new DataRelation("Test", bills.Columns["BillCode"], billDetails.Columns["BillCode"], false);


            try
            {

                ds.Relations.Add(ds.Tables["Bills"].Columns["BillCode"], ds.Tables["Units"].Columns["BillCode"]);

            }
            catch (Exception ex)
            { }

            return ds;
        }
    }
}
