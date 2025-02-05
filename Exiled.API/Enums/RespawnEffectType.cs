// -----------------------------------------------------------------------
// <copyright file="RespawnEffectType.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Enums
{
    /// <summary>
    /// Layers game respawn effects.
    /// </summary>
    public enum RespawnEffectType : byte
    {
        /// <summary>
        /// Plays the <see cref="Side.ChaosInsurgency"/> music to alive <see cref="RoleType.ClassD"/> and <see cref="Side.ChaosInsurgency"/>.
        /// </summary>
        PlayChaosInsurgencyMusic = 0,

        /// <summary>
        /// Summons the <see cref="Side.ChaosInsurgency"/> van.
        /// </summary>
        SummonChaosInsurgencyVan = 128,

        /// <summary>
        /// Summons the NTF chopper.
        /// </summary>
        SummonNtfChopper = 129,
    }
}
