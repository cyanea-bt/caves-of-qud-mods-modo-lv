﻿using System;
using System.Collections.Generic;
using HarmonyLib;
using ModoMods.Core.Data;
using ModoMods.Core.Utils;
using ModoMods.SkillTraining.Data;
using ModoMods.SkillTraining.Utils;
using XRL;
using XRL.UI;
using XRL.World;

namespace ModoMods.SkillTraining.Trainers {
  /// <summary>Trains "Snake Oiler" skill.</summary>
  /// <remarks>
  /// Attached to player to listen for trade start events.
  /// When a trade is started, also attaches to the trader, to wait for "take object" event. 
  /// </remarks>
  public class SnakeOilerTrainer : ModPart {
    public override ISet<Int32> WantEventIds => new HashSet<Int32> { StartTradeEvent.ID };

    public override Boolean HandleEvent(StartTradeEvent ev) {
      // Party member trading doesn't count
      if (ev.Trader.IsPlayerLed())
        ev.Trader.RemovePart<TradeListener>();
      // Non-creatures are containers (which trigger the same events).
      else if (ev.Trader.IsCreature)
        ev.Trader.RequirePart<TradeListener>();
      return base.HandleEvent(ev);
    }
  }

  [HarmonyPatch] public class TradeListener : ModPart {
    public override void Register(GameObject obj, IEventRegistrar reg) {
      obj.RegisterPartEvent(this, QudEventNames.CommandTakeObject);
      base.Register(obj, reg);
    }

    public override Boolean FireEvent(Event ev) {
      var item = ev.GetGameObjectParameter("Object");

      if (ev.ID != QudEventNames.CommandTakeObject
          || TradeUI.ScreenMode != TradeUI.TradeScreenMode.Trade
          || !this.ParentObject.IsCreature
          // Getting items doesn't train selling them
          || this.ParentObject.IsPlayer()
          || item == null
          || item.ValueEach <= 1)
        return base.FireEvent(ev);
      
      var itemCount = item.Stacker?.Number ?? 1m;
      var bonus = Math.Round(new Decimal(item.Value) / 1000, 2);
      Output.DebugLog($"Sold {itemCount} item(s) worth {item.Value}, bonus: {bonus}.");
      bonus *= 1m / TrainingData.For(PlayerAction.TradeItem).DefaultAmount;
      // Only player trades things through a UI
      The.Player?.Training()?.HandleTrainingAction(PlayerAction.TradeItem, itemCount + bonus);

      return base.FireEvent(ev);
    }

    // ReSharper disable once UnusedMember.Global
    // ReSharper disable once InconsistentNaming
    [HarmonyPostfix][HarmonyPatch(typeof(TradeUI), nameof(TradeUI.ShowTradeScreen))]
    public static void AfterTradeScreen(GameObject Trader) {
      Trader.RemovePart<TradeListener>();
    }
  }
}