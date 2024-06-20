using System;

public delegate void HealthChangedEventHandler(object sender, HealthChangedEventArgs e);

public class HealthChangedEventArgs : EventArgs
{
    public int NewHealth { get; }

    public HealthChangedEventArgs(int newHealth)
    {
        NewHealth = newHealth;
    }
}

public class Character
{
    public event HealthChangedEventHandler HealthChanged;

    private int _health;
    public int Health
    {
        get => _health;
        set
        {
            _health = value;
            OnHealthChanged(_health);
        }
    }

    protected virtual void OnHealthChanged(int newHealth)
    {
        HealthChanged?.Invoke(this, new HealthChangedEventArgs(newHealth));
    }
}