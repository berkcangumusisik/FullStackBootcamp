using System;

public delegate void OrderCompletedEventHandler(object sender, OrderEventArgs e);

public class OrderEventArgs : EventArgs
{
    public string OrderId { get; }
    public double OrderAmount { get; }

    public OrderEventArgs(string orderId, double orderAmount)
    {
        OrderId = orderId;
        OrderAmount = orderAmount;
    }
}

public class OrderProcessor
{
    public event OrderCompletedEventHandler OrderCompleted;

    public void CompleteOrder(string orderId, double orderAmount)
    {
        Console.WriteLine("Sipariş tamamlandı.");
        OnOrderCompleted(orderId, orderAmount);
    }

    protected virtual void OnOrderCompleted(string orderId, double orderAmount)
    {
        OrderCompleted?.Invoke(this, new OrderEventArgs(orderId, orderAmount));
    }
}