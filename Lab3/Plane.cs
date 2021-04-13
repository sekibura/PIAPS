using Lab3.Composite;
using Lab3.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Plane : IFlyableUnit
    {
        private List<IFlyableUnit> onBoardMember;

        public void InitPlane()
        {
            onBoardMember = new List<IFlyableUnit>();
            addPilots();
            addStewardess();

            initBussinessClass();
            initEconomyClass();
            initFirstClass();
        }

        public void AddUnit(IFlyableUnit unit)
        {
            onBoardMember.Add(unit);
        }

        public float GetWeight()
        {
            float weight = 0f;
            foreach (var member in onBoardMember)
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

        }
        public void PrintWeightInfo()
        {
            foreach (var member in onBoardMember)
            {
                Console.WriteLine(member.ToString() + " - " + member.GetWeight());
            }
        }
    }
}
