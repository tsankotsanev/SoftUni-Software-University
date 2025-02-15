﻿using System.Collections.Generic;

namespace _07.MilitaryElite.Contracts
{
    interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }
        void AddMission(IMission mission);

    }
}
