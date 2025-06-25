using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAccounting;

class AccountingModel : ModelBase
{
    private double _price;
    public double Price
    {
        get => _price;
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
            _price = value;
            Notify(nameof(Price));
            _total = _price * _nightsCount * (1 - _discount / 100);
            Notify(nameof(Total));
        }
    }

    private int _nightsCount;
    public int NightsCount
    {
        get => _nightsCount;
        set
        {
            if (value < 1) throw new ArgumentOutOfRangeException(nameof(value));
            _nightsCount = value;
            Notify(nameof(NightsCount));
            _total = _price * _nightsCount * (1 - _discount / 100);
            Notify(nameof(Total));
        }
    }

    private double _discount;
    public double Discount
    {
        get => _discount;
        set
        {
            if (value > 100) throw new ArgumentOutOfRangeException(nameof(value));
            _discount = value; 
            Notify(nameof(Discount));
            _total = _price * _nightsCount * (1 - _discount / 100);
            Notify(nameof(Total));
        }
    }

    private double _total;
    public double Total
    {
        get => _total;
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
            _total = value;
            Notify(nameof(Total));
            _discount = 100 * (1 - _total / (_price * _nightsCount));
            Notify(nameof(Discount));
        }
    }
}