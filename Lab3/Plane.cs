using Lab3.Composite;
using Lab3.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Plane : IFlyableUnit
    {
        private List<IFlyableUnit> _onBoardMember;
        private float _maxWeight = 2500f;
        private WeightCard _weightCard = new WeightCard();

        public void InitPlane()
        {
            _onBoardMember = new List<IFlyableUnit>();
            addPilots();
            addStewardess();

            initBussinessClass();
            initEconomyClass();
            initFirstClass();
        }

        public void AddUnit(IFlyableUnit unit)
        {
            _onBoardMember.Add(unit);
        }

        public float GetWeight()
        {
            float weight = 0f;
            foreach (var member in _onBoardMember)
            {
                weight += member.GetWeight();
            }
            return weight;
        }

        public void RemoveAnyUnit()
        {
            throw new NotImplementedException();
        }

        private void addPilots()
        {
            for (int i = 0; i < 2; i++)
            {
               AddUnit(new Pilot());
            }
        }

        private void addStewardess()
        {
            for (int i = 0; i < 6; i++)
            {
                AddUnit(new Stewardess());
            }
        }

        private void initBussinessClass()
        {
            BussinessClass bussinessClass = new BussinessClass();
            for (int i = 0; i < bussinessClass.GetMaxNumOfPassengers(); i++)
            {
                bussinessClass.AddUnit(new PassangerBusinessClass());
            }
            AddUnit(bussinessClass);
            
        }
        private void initEconomyClass()
        {
            EconomyClass economyClass = new EconomyClass();
            for (int i = 0; i < economyClass.GetMaxNumOfPassengers(); i++)
            {
                economyClass.AddUnit(new PassangerEconomyСlass());
            }
            AddUnit(economyClass);
        }
        private void initFirstClass()
        {
            FirstClass firstClass = new FirstClass();
            for (int i = 0; i < firstClass.GetMaxNumOfPassengers(); i++)
            {
                firstClass.AddUnit(new PassangerFirstClass());
            }
            AddUnit(firstClass);
        }

        public void StartFlight()
        {
            if (_weightCard.GetSummaryWeight() > _maxWeight)
            {
                //TODO 
                //FIX OVERLOAD
                EconomyClass economyClass = (EconomyClass)_onBoardMember.Find(item => item is EconomyClass);
                economyClass.RemoveOverload(_weightCard.GetSummaryWeight()-_maxWeight);
                PrintWeightInfo();
            }
            Console.WriteLine("Start Flight");
        }
        public void PrintWeightInfo()
        {
 
            foreach (var member in _onBoardMember)
            {
                Console.WriteLine(member.GetType()+ " - " + member.GetWeight());
                Console.WriteLine(member is Pilot);
                switch (member)
                {
                    case Pilot p:
                        _weightCard.PilotWeight = member.GetWeight();
                        break;
                    case Stewardess p:
                        _weightCard.StewardessWeight = member.GetWeight();
                        break;
                    case FirstClass p:
                        _weightCard.FirstClassWeight = member.GetWeight();
                        break;
                    case BussinessClass p:
                        _weightCard.BusinessClassWeight = member.GetWeight();
                        break;
                    case EconomyClass p:
                        _weightCard.EconomyClassWeight = member.GetWeight();
                        break;
                }
            }

            Console.WriteLine(Schemes.WeightScheme(_weightCard));
        }


    }
}
