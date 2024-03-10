using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace DraftApp.Web.Models
{
    public partial class PickDtoGen : GeneratedDto<DraftApp.Data.Models.Pick>
    {
        public PickDtoGen() { }

        private int? _PickId;
        private int? _PlayerId;
        private DraftApp.Web.Models.PlayerDtoGen _Player;
        private int? _TourneyTeamId;
        private DraftApp.Web.Models.TourneyTeamDtoGen _TourneyTeam;
        private int? _PickNumber;

        public int? PickId
        {
            get => _PickId;
            set { _PickId = value; Changed(nameof(PickId)); }
        }
        public int? PlayerId
        {
            get => _PlayerId;
            set { _PlayerId = value; Changed(nameof(PlayerId)); }
        }
        public DraftApp.Web.Models.PlayerDtoGen Player
        {
            get => _Player;
            set { _Player = value; Changed(nameof(Player)); }
        }
        public int? TourneyTeamId
        {
            get => _TourneyTeamId;
            set { _TourneyTeamId = value; Changed(nameof(TourneyTeamId)); }
        }
        public DraftApp.Web.Models.TourneyTeamDtoGen TourneyTeam
        {
            get => _TourneyTeam;
            set { _TourneyTeam = value; Changed(nameof(TourneyTeam)); }
        }
        public int? PickNumber
        {
            get => _PickNumber;
            set { _PickNumber = value; Changed(nameof(PickNumber)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(DraftApp.Data.Models.Pick obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.PickId = obj.PickId;
            this.PlayerId = obj.PlayerId;
            this.TourneyTeamId = obj.TourneyTeamId;
            this.PickNumber = obj.PickNumber;
            if (tree == null || tree[nameof(this.Player)] != null)
                this.Player = obj.Player.MapToDto<DraftApp.Data.Models.Player, PlayerDtoGen>(context, tree?[nameof(this.Player)]);

            if (tree == null || tree[nameof(this.TourneyTeam)] != null)
                this.TourneyTeam = obj.TourneyTeam.MapToDto<DraftApp.Data.Models.TourneyTeam, TourneyTeamDtoGen>(context, tree?[nameof(this.TourneyTeam)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(DraftApp.Data.Models.Pick entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(PickId))) entity.PickId = (PickId ?? entity.PickId);
            if (ShouldMapTo(nameof(PlayerId))) entity.PlayerId = (PlayerId ?? entity.PlayerId);
            if (ShouldMapTo(nameof(TourneyTeamId))) entity.TourneyTeamId = (TourneyTeamId ?? entity.TourneyTeamId);
            if (ShouldMapTo(nameof(PickNumber))) entity.PickNumber = (PickNumber ?? entity.PickNumber);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override DraftApp.Data.Models.Pick MapToNew(IMappingContext context)
        {
            var entity = new DraftApp.Data.Models.Pick();
            MapTo(entity, context);
            return entity;
        }
    }
}
