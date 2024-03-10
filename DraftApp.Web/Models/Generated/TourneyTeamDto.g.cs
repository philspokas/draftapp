using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace DraftApp.Web.Models
{
    public partial class TourneyTeamDtoGen : GeneratedDto<DraftApp.Data.Models.TourneyTeam>
    {
        public TourneyTeamDtoGen() { }

        private int? _TourneyTeamID;
        private int? _TeamID;
        private DraftApp.Web.Models.TeamDtoGen _Team;
        private int? _Seed;
        private string _Region;
        private string _BracketPosition;

        public int? TourneyTeamID
        {
            get => _TourneyTeamID;
            set { _TourneyTeamID = value; Changed(nameof(TourneyTeamID)); }
        }
        public int? TeamID
        {
            get => _TeamID;
            set { _TeamID = value; Changed(nameof(TeamID)); }
        }
        public DraftApp.Web.Models.TeamDtoGen Team
        {
            get => _Team;
            set { _Team = value; Changed(nameof(Team)); }
        }
        public int? Seed
        {
            get => _Seed;
            set { _Seed = value; Changed(nameof(Seed)); }
        }
        public string Region
        {
            get => _Region;
            set { _Region = value; Changed(nameof(Region)); }
        }
        public string BracketPosition
        {
            get => _BracketPosition;
            set { _BracketPosition = value; Changed(nameof(BracketPosition)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(DraftApp.Data.Models.TourneyTeam obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.TourneyTeamID = obj.TourneyTeamID;
            this.TeamID = obj.TeamID;
            this.Seed = obj.Seed;
            this.Region = obj.Region;
            this.BracketPosition = obj.BracketPosition;
            if (tree == null || tree[nameof(this.Team)] != null)
                this.Team = obj.Team.MapToDto<DraftApp.Data.Models.Team, TeamDtoGen>(context, tree?[nameof(this.Team)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(DraftApp.Data.Models.TourneyTeam entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(TourneyTeamID))) entity.TourneyTeamID = (TourneyTeamID ?? entity.TourneyTeamID);
            if (ShouldMapTo(nameof(TeamID))) entity.TeamID = (TeamID ?? entity.TeamID);
            if (ShouldMapTo(nameof(Seed))) entity.Seed = (Seed ?? entity.Seed);
            if (ShouldMapTo(nameof(Region))) entity.Region = Region;
            if (ShouldMapTo(nameof(BracketPosition))) entity.BracketPosition = BracketPosition;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override DraftApp.Data.Models.TourneyTeam MapToNew(IMappingContext context)
        {
            var entity = new DraftApp.Data.Models.TourneyTeam();
            MapTo(entity, context);
            return entity;
        }
    }
}
