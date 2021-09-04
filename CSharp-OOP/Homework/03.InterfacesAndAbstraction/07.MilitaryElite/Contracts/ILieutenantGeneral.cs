using System.Collections.Generic;

namespace _07.MilitaryElite.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        public IReadOnlyCollection<ISoldier> Privates { get; }
       public  void AddPrivate(ISoldier @private);
    }
}
