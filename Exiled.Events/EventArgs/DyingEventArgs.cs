// -----------------------------------------------------------------------
// <copyright file="DyingEventArgs.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Events.EventArgs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Exiled.API.Features;
    using Exiled.API.Features.Items;

    /// <summary>
    /// Contains all information before a player dies.
    /// </summary>
    public class DyingEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DyingEventArgs"/> class.
        /// </summary>
        /// <param name="killer"><inheritdoc cref="Killer"/></param>
        /// <param name="target"><inheritdoc cref="Target"/></param>
        /// <param name="hitInformation"><inheritdoc cref="HitInformation"/></param>
        /// <param name="isAllowed"><inheritdoc cref="IsAllowed"/></param>
        public DyingEventArgs(Player killer, Player target, PlayerStats.HitInfo hitInformation, bool isAllowed = true)
        {
            ItemsToDrop = new List<Item>(target.Items.ToList());
            Killer = killer;
            Target = target;
            HitInformation = hitInformation;
            IsAllowed = isAllowed;
        }

        /// <summary>
        /// Gets the killing player.
        /// </summary>
        public Player Killer { get; }

        /// <summary>
        /// Gets the dying player.
        /// </summary>
        public Player Target { get; }

        /// <summary>
        /// Gets or sets the list of items to be dropped.
        /// </summary>
        public List<Item> ItemsToDrop { get; set; }

        /// <summary>
        /// Gets or sets the hit information.
        /// </summary>
        public PlayerStats.HitInfo HitInformation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the player can be killed.
        /// </summary>
        public bool IsAllowed { get; set; }
    }
}
