﻿using SharkGaming.OrderFile;
using SharkGaming.Users.Customer;

namespace SharkGaming.Order
{
    public class OrderClass
    {
        public static int nextId = 0;
        public int Id { get; set; }
        public string DeliveryAddress { get; set; }
        public DateOnly Date { get; set; }
        public DateTime Time { get; set; }
        public CustomerClass Customer { get; set; }
        public double TotalPrice { get; set; }

        private List<OrderItemsClass> _orderItems = new List<OrderItemsClass>();
        private static List<OrderClass> _orders = new List<OrderClass>();

        public OrderClass(CustomerClass customer, string deliveryAdress, DateOnly date, DateTime time, List<OrderItemsClass> orderitems)
        {
            Id = nextId++;
            Customer = customer;
            DeliveryAddress = deliveryAdress;
            Date = date;
            Time = time;
            _orderItems = orderitems;
            TotalPrice = CalculateTotalPrice();
            _orders.Add(this);
        }

        public OrderClass()
        {

        }

        public List<OrderItemsClass> GetOrderItems()
        {
            return _orderItems;
        }

        public static List<OrderClass> GetOrders()
        {
            return _orders;
        }
        public double CalculateTotalPrice()
        {
            double totalPrice = 0;

            if (_orderItems != null)
            {
                foreach (OrderItemsClass item in _orderItems)
                {
                    totalPrice = totalPrice + item.Price + 1000;
                }
                return totalPrice;
            }
            return 0;
        }

    }
}
