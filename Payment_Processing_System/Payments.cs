using System;

namespace Payment_Processing_System
{
    /// <summary>
    /// The Physical Product.
    /// </summary>
    public class PhysicalProduct : IPayment
    {
        public string HandleOrder()
        {
            return Constants.PHYSICAL_PRODUCT_RULE;
        }
    }

    /// <summary>
    /// The Book.
    /// </summary>
    public class Book : IPayment
    {
        public string HandleOrder()
        {
            return Constants.BOOK_RULE;
        }
    }

    /// <summary>
    /// The Member Ship.
    /// </summary>
    public class MemberShip : IPayment
    {
        public string HandleOrder()
        {
            return Constants.MEMBERSHIP_RULE;
        }
    }

    /// <summary>
    /// The Upgrade MemberShip.
    /// </summary>
    public class UpgradeMemberShip : IPayment
    {
        public string HandleOrder()
        {
            return Constants.UPGRADE_MEMBERSHIP_RULE;
        }
    }

    /// <summary>
    /// Video "Learning to Ski".
    /// </summary>
    public class VideoLearningtoSki : IPayment
    {
        public string HandleOrder()
        {
            return Constants.VIDEO_LEARNING_TO_SKI;
        }
    }

    /// <summary>
    /// The BusinessRulesEngine.
    /// </summary>
    public class BusinessRulesEngine
    {
        public IPayment _payment;

        public BusinessRulesEngine(IPayment payment)
        {
            _payment = payment;
        }

        public string HandleOrder()
        {
            return _payment.HandleOrder();
        }
    }
}
