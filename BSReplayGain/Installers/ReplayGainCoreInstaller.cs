﻿using BSReplayGain.Managers;
using Zenject;

namespace BSReplayGain.Installers
{
    internal class ReplayGainCoreInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ReplayGainManager>().AsSingle();
        }
    }
}