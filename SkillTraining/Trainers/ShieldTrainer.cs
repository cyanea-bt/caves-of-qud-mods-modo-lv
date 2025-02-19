﻿using System;
using System.Collections.Generic;
using ModoMods.Core.Data;
using ModoMods.Core.Utils;
using ModoMods.SkillTraining.Data;
using ModoMods.SkillTraining.Utils;
using XRL.World;

namespace ModoMods.SkillTraining.Trainers {
  /// <summary>Trains Shield skill.</summary>
  public class ShieldTrainer : ModPart {
    public override ISet<Int32> WantEventIds => new HashSet<Int32> { AfterShieldBlockEvent.ID };

    public override Boolean HandleEvent(AfterShieldBlockEvent ev) {
      if (ev.Defender.CanTrainSkills()) {
        PlayerAction action;
        if (ev.Defender.HasSkill(QudSkillClasses.DeftBlocking))
          action = PlayerAction.DeftBlock;
        else if (ev.Defender.HasSkill(QudSkillClasses.SwiftBlocking))
          action = PlayerAction.SwiftBlock;
        else if (ev.Defender.HasSkill(QudSkillClasses.Shield))
          action = PlayerAction.SkilledBlock;
        else
          action = PlayerAction.NativeBlock;
        ev.Defender.Training()?.HandleTrainingAction(action);
      }
      return base.HandleEvent(ev);
    }
  }
}