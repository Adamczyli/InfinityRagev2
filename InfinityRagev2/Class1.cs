using Exiled.API.Features;
using Exiled.CreditTags;
using Exiled.Events.EventArgs.Scp096;
using Scp096 = Exiled.Events.Handlers.Scp096;

namespace InfinityRage
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "Infinity rage096";
        public override string Author => ".Adamczyli <3";
        public override string Prefix => "infinityrage";

        public override void OnEnabled()
        {
            base.OnEnabled();

            Scp096.AddingTarget += OnAddingTarget;
            Scp096.CalmingDown += OnRagingEnded;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            Scp096.AddingTarget -= OnAddingTarget;
            Scp096.CalmingDown -= OnRagingEnded;
        }

        private void OnAddingTarget(AddingTargetEventArgs ev)
        {
            ev.Target.ShowHint($"Spojrzałeś na twarz <color=red>scp 096</color>!");
            ev.Player.ShowHint($"dodano <color=#FF0101>{ev.Scp096.Targets.Count} Targetów</color>", 1);
        }

        private void OnRagingEnded(CalmingDownEventArgs ev)
        {
            if (ev.Scp096.Targets.Count > 0)
            {
                ev.IsAllowed = false;

                ev.Player.ShowHint($"Rage trwa dalej, ponieważ pozostało <color=#FF0101>{ev.Scp096.Targets.Count}</color> targetów.", 5);
            }
            if (ev.Scp096.Targets.Count < 0)
                ev.Player.ShowHint($"Rage zakończony, ponieważ nie ma już targetów.", 1);
            {
                ev.IsAllowed = true;
            }
        }
    }
}