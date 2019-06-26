using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Math
{
    public class Petition
    {
        public bool IsMasterDegree { get; set; }

        public int PetitionId { get; set; }
    }

    public class Lottery
    {
        public List<Petition> ReceivedPetitions { get; set; }

        public List<Petition> SelectedPetitions { get; set; }

        public List<Petition> RejectedPetitions { get; set; }

        public int MasterQuota { get; set; }

        public int GeneralQuota { get; set; }

        public int TotalRecievedPetitionCount {
            get
            {
                return ReceivedPetitions.Count();
            }
        }

        public Lottery(int _masterQuota, int _generalQuota)
        {
            ReceivedPetitions = new List<Petition>();
            SelectedPetitions = new List<Petition>();
            RejectedPetitions = new List<Petition>();

            MasterQuota = _masterQuota;
            GeneralQuota = _generalQuota;
        }

        public void ApplyPetition(Petition petition)
        {
            ReceivedPetitions.Add(petition);
        }

        public void Randamize()
        {
            var masterPetitions = ReceivedPetitions.Where(s => s.IsMasterDegree).ToList();

            RandomSelect(masterPetitions, MasterQuota);

            var nonMasterPetitions = ReceivedPetitions.Where(s => !s.IsMasterDegree).ToList();

            nonMasterPetitions.AddRange(masterPetitions);

            RandomSelect(nonMasterPetitions, GeneralQuota);

            RejectedPetitions = nonMasterPetitions;
        }

        public void RandamizeNew()
        {
            RandomSelect(ReceivedPetitions, GeneralQuota);

            var masterPetitions = ReceivedPetitions.Where(s => s.IsMasterDegree).ToList();

            RandomSelect(masterPetitions, MasterQuota);

            ReceivedPetitions.Where(s => !s.IsMasterDegree).ToList().AddRange(masterPetitions);

            RejectedPetitions = ReceivedPetitions;
        }

        private List<Petition> RandomSelect(List<Petition> petitions, int maxCount)
        {
            List<Petition> current = new List<Petition>();
            Random r = new Random();

            while (current.Count < maxCount)
            {
                int luckyPetitionNo = r.Next(petitions.Count - 1);

                current.Add(petitions.ElementAt(luckyPetitionNo));

                petitions.RemoveAt(luckyPetitionNo);
            }

            SelectedPetitions.AddRange(current);

            return petitions;
        }

        public void ShuffleList(List<Petition> list)
        {
            Random random = new Random();
            if (list.Count > 1)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    Petition tmp = list[i];
                    int randomIndex = random.Next(i + 1);

                    //Swap elements
                    list[i] = list[randomIndex];
                    list[randomIndex] = tmp;
                }
            }
        }
    }
}
