﻿using System;
using System.Runtime.CompilerServices;
using InControl;

namespace RWF.ExtensionMethods
{
    [Serializable]
    public class PlayerActionsAdditionalData
    {
        public PlayerAction increaseTeamID;
        public PlayerAction decreaseTeamID;


        public PlayerActionsAdditionalData()
        {
            this.increaseTeamID = null;
            this.decreaseTeamID = null;
        }
    }
    public static class PlayerActionsExtension
    {
        public static readonly ConditionalWeakTable<PlayerActions, PlayerActionsAdditionalData> data =
            new ConditionalWeakTable<PlayerActions, PlayerActionsAdditionalData>();

        public static PlayerActionsAdditionalData GetAdditionalData(this PlayerActions playerActions)
        {
            return data.GetOrCreateValue(playerActions);
        }

        public static void AddData(this PlayerActions playerActions, PlayerActionsAdditionalData value)
        {
            try
            {
                data.Add(playerActions, value);
            }
            catch (Exception) { }
        }
    }
}
