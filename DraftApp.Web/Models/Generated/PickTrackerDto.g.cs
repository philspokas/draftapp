using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace DraftApp.Web.Models
{
    public partial class PickTrackerDtoGen : GeneratedDto<DraftApp.Data.Models.PickTracker>
    {
        public PickTrackerDtoGen() { }

        private int? _PickTrackerID;
        private int? _CurrentPick;
        private bool? _RepeatPlayer;
        private int? _PlayerIndex;
        private int? _Direction;

        public int? PickTrackerID
        {
            get => _PickTrackerID;
            set { _PickTrackerID = value; Changed(nameof(PickTrackerID)); }
        }
        public int? CurrentPick
        {
            get => _CurrentPick;
            set { _CurrentPick = value; Changed(nameof(CurrentPick)); }
        }
        public bool? RepeatPlayer
        {
            get => _RepeatPlayer;
            set { _RepeatPlayer = value; Changed(nameof(RepeatPlayer)); }
        }
        public int? PlayerIndex
        {
            get => _PlayerIndex;
            set { _PlayerIndex = value; Changed(nameof(PlayerIndex)); }
        }
        public int? Direction
        {
            get => _Direction;
            set { _Direction = value; Changed(nameof(Direction)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(DraftApp.Data.Models.PickTracker obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.PickTrackerID = obj.PickTrackerID;
            this.CurrentPick = obj.CurrentPick;
            this.RepeatPlayer = obj.RepeatPlayer;
            this.PlayerIndex = obj.PlayerIndex;
            this.Direction = obj.Direction;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(DraftApp.Data.Models.PickTracker entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(PickTrackerID))) entity.PickTrackerID = (PickTrackerID ?? entity.PickTrackerID);
            if (ShouldMapTo(nameof(CurrentPick))) entity.CurrentPick = (CurrentPick ?? entity.CurrentPick);
            if (ShouldMapTo(nameof(RepeatPlayer))) entity.RepeatPlayer = (RepeatPlayer ?? entity.RepeatPlayer);
            if (ShouldMapTo(nameof(PlayerIndex))) entity.PlayerIndex = (PlayerIndex ?? entity.PlayerIndex);
            if (ShouldMapTo(nameof(Direction))) entity.Direction = (Direction ?? entity.Direction);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override DraftApp.Data.Models.PickTracker MapToNew(IMappingContext context)
        {
            var entity = new DraftApp.Data.Models.PickTracker();
            MapTo(entity, context);
            return entity;
        }
    }
}
