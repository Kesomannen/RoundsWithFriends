﻿using System;
using UnityEngine;

namespace RWF.GameModes
{
	public class ArmsRace : IGameMode
	{
		public string Name {
			get { return "ArmsRace"; }
		}

		public GameObject gameObject {
			get {
				return GameObject.Find("/Game/Code/Game Modes").transform.Find("[GameMode] Arms race").gameObject;
			}
        }

		public bool IsRoundStartCeaseFire {
			get {
				return false;
            }
        }

		public void StartGame() {
			GM_ArmsRace.instance.StartGame();
		}

		public void PlayerJoined(Player player) {
			GM_ArmsRace.instance.PlayerJoined(player);
		}

		public void PlayerDied(Player player, int playersAlive) {
			GM_ArmsRace.instance.PlayerDied(player, playersAlive);
		}

		public void AddStartGameAction(Action action) {
			GM_ArmsRace.instance.StartGameAction += action;
		}
	}
}
