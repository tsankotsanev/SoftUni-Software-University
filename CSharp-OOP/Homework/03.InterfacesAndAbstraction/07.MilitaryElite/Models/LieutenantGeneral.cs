using System.Collections.Generic;
using System.Text;
using _07.MilitaryElite.Contracts;

namespace _07.MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private ICollection<ISoldier> privates;
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            privates = new List<ISoldier>();
        }

        public IReadOnlyCollection<ISoldier> Privates =>
            (IReadOnlyCollection<ISoldier>)privates;

        public void AddPrivate(ISoldier @private)
        {
            privates.Add(@private);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");

            foreach (var soldier in Privates)
            {
                sb.AppendLine($"  {soldier}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
