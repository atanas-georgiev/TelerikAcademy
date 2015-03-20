using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    class HoldingPenModified : HoldingPen
    {
        protected override void DispatchCommand(string[] commandWords)
        {
            try
            { 
                base.DispatchCommand(commandWords); 
            }
            catch
            {

            }            
        }
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            try
            {
                var unit = this.GetUnit(commandWords[2]);
                switch (commandWords[1])
                {
                    case "PowerCatalyst":
                        unit.AddSupplement(new PowerCatalyst());
                        break;
                    case "HealthCatalyst":
                        unit.AddSupplement(new HealthCatalyst());
                        break;
                    case "AggressionCatalyst":
                        unit.AddSupplement(new AggressionCatalyst());
                        break;
                    case "Weapon":
                        unit.AddSupplement(new Weapon());
                        break;
                    default:
                        break;
                }
            }
            catch
            {

            }
        }

        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            try
            {
                switch (commandWords[1])
                {
                    case "Tank":
                        var tank = new Tank(commandWords[2]);
                        this.InsertUnit(tank);
                        break;
                    case "Marine":
                        var marine = new Marine(commandWords[2]);
                        this.InsertUnit(marine);
                        break;
                    case "Parasite":
                        var parasite = new Parasite(commandWords[2]);
                        this.InsertUnit(parasite);
                        break;
                    case "Queen":
                        var queen = new Queen(commandWords[2]);
                        this.InsertUnit(queen);
                        break;
                    default:
                        base.ExecuteInsertUnitCommand(commandWords);
                        break;
                }
            }
            catch
            {

            }
        }

        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            try
            {
                switch (interaction.InteractionType)
                {
                    case InteractionType.Attack:
                        Unit targetUnit = this.GetUnit(interaction.TargetUnit);
                        targetUnit.DecreaseBaseHealth(interaction.SourceUnit.Power);
                        break;

                    case InteractionType.Infest:
                        Unit targetUnit1 = this.GetUnit(interaction.TargetUnit);
                        if (InfestationRequirements.RequiredClassificationToInfest(targetUnit1.UnitClassification) == interaction.SourceUnit.UnitClassification)
                        {
                            targetUnit1.AddSupplement(new InfestationSpores());
                        }
                        break;
                    default:
                        break;
                }
            }
            catch
            {

            }
        }
    }
}
