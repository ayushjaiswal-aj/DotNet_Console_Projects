using System;

class HPVISACard : VISACard
{
    public new double ComputeRewardPoints(string _type, double _amount)
    {
        //fill code here
        if ("Fuel" == _type)
        {
            return (base.ComputeRewardPoints(_type, _amount) + 10);
        }
        return base.ComputeRewardPoints(_type, _amount);
    }
}