using System;

namespace Payment_Processing_System
{
    public class PhysicalProduct : IPayment
    {
        public string HandleOrder()
        {
            return Constants.PHYSICAL_PRODUCT_RULE;
        }
    }

    public class Book : IPayment
    {
        public string HandleOrder()
        {
            return Constants.BOOK_RULE;
        }
    }

    public class MemberShip : IPayment
    {
        public string HandleOrder()
        {
            return Constants.MEMBERSHIP_RULE;
        }
    }

    public class UpgradeMemberShip : IPayment
    {
        public string HandleOrder()
        {
            return Constants.UPGRADE_MEMBERSHIP_RULE;
        }
    }

    public class VideoLearningtoSki : IPayment
    {
        public string HandleOrder()
        {
            return Constants.VIDEO_LEARNING_TO_SKI;
        }
    }

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
