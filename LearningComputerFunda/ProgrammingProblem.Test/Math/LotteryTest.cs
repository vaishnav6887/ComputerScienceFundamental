using System;
using System.Linq;
using System.Collections.Generic;
using ComputerFunda.ProgrammingProblem.Math;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingProblem.Test.Math
{
    [TestCategory("Math")]
    [TestClass]
    public class LotteryTest
    {
        [TestMethod]
        public void Lottery_Test_Old_System()
        {
            Lottery obj = new Lottery(20000, 65000);

            int masterRecieved = 90100;
            int totalRecieved = 234500;

            for (int i = 1; i <= masterRecieved; i++)
            {
                obj.ApplyPetition(new Petition()
                {
                    IsMasterDegree = true,
                    PetitionId = i
                });
            }

            for (int i = masterRecieved + 1; i <= totalRecieved; i++)
            {
                obj.ApplyPetition(new Petition()
                {
                    IsMasterDegree = false,
                    PetitionId = i
                });
            }

            obj.ShuffleList(obj.ReceivedPetitions);

            obj.Randamize();

            int masterSelectedCount = obj.SelectedPetitions.Count(s => s.IsMasterDegree);
            int generalSelectedCount = obj.SelectedPetitions.Count(s => !s.IsMasterDegree);

            double masterSelectedPercentage = ((double) masterSelectedCount / 85000) * 100;

            double generalSelectedPercentage = ((double) generalSelectedCount / 85000) * 100;
        }

        [TestMethod]
        public void Lottery_Test_New_System()
        {
            Lottery obj = new Lottery(20000, 65000);

            int masterRecieved = 90100;
            int totalRecieved = 234500;

            for (int i = 1; i <= masterRecieved; i++)
            {
                obj.ApplyPetition(new Petition()
                {
                    IsMasterDegree = true,
                    PetitionId = i
                });
            }

            for (int i = masterRecieved + 1; i <= totalRecieved; i++)
            {
                obj.ApplyPetition(new Petition()
                {
                    IsMasterDegree = false,
                    PetitionId = i
                });
            }

            obj.ShuffleList(obj.ReceivedPetitions);

            obj.RandamizeNew();

            int masterSelectedCount = obj.SelectedPetitions.Count(s => s.IsMasterDegree);
            int generalSelectedCount = obj.SelectedPetitions.Count(s => !s.IsMasterDegree);

            double masterSelectedPercentage = ((double)masterSelectedCount / 85000) * 100;

            double generalSelectedPercentage = ((double)generalSelectedCount / 85000) * 100;
        }
    }
}
