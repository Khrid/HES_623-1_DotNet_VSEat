﻿using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
using Microsoft.Extensions.Configuration;

namespace BLL
{
    public class OrdersStatusHistoryManager : IOrdersStatusHistoryManager
    {
        public IOrdersStatusHistoryDB OrdersStatusHistoryDB { get;  }

        public OrdersStatusHistoryManager(IConfiguration configuration)
        {
            OrdersStatusHistoryDB = new OrdersStatusHistoryDB(configuration);
        }

        public OrdersStatusHistory AddOrdersStatusHistory(OrdersStatusHistory ordersStatusHistory)
        {
            return OrdersStatusHistoryDB.AddOrdersStatusHistory(ordersStatusHistory);
        }

        public List<OrdersStatusHistory> GetAllOrdersStatusHistory()
        {
            return OrdersStatusHistoryDB.GetAllOrdersStatusHistory();
        }

        public OrdersStatusHistory GetOrdersStatusHistoryById(int id)
        {
            return OrdersStatusHistoryDB.GetOrdersStatusHistoryById(id);
        }
    }
}