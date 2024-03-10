using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace DraftApp.Web.Models
{
    public partial class TeamDtoGen : GeneratedDto<DraftApp.Data.Models.Team>
    {
        public TeamDtoGen() { }

        private int? _TeamId;
        private string _Name;
        private string _Abbreviation;
        private string _Mascot;
        private string _LogoURL;

        public int? TeamId
        {
            get => _TeamId;
            set { _TeamId = value; Changed(nameof(TeamId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }
        public string Abbreviation
        {
            get => _Abbreviation;
            set { _Abbreviation = value; Changed(nameof(Abbreviation)); }
        }
        public string Mascot
        {
            get => _Mascot;
            set { _Mascot = value; Changed(nameof(Mascot)); }
        }
        public string LogoURL
        {
            get => _LogoURL;
            set { _LogoURL = value; Changed(nameof(LogoURL)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(DraftApp.Data.Models.Team obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.TeamId = obj.TeamId;
            this.Name = obj.Name;
            this.Abbreviation = obj.Abbreviation;
            this.Mascot = obj.Mascot;
            this.LogoURL = obj.LogoURL;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(DraftApp.Data.Models.Team entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(TeamId))) entity.TeamId = (TeamId ?? entity.TeamId);
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(Abbreviation))) entity.Abbreviation = Abbreviation;
            if (ShouldMapTo(nameof(Mascot))) entity.Mascot = Mascot;
            if (ShouldMapTo(nameof(LogoURL))) entity.LogoURL = LogoURL;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override DraftApp.Data.Models.Team MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new DraftApp.Data.Models.Team()
            {
                Name = Name,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(TeamId))) entity.TeamId = (TeamId ?? entity.TeamId);
            if (ShouldMapTo(nameof(Abbreviation))) entity.Abbreviation = Abbreviation;
            if (ShouldMapTo(nameof(Mascot))) entity.Mascot = Mascot;
            if (ShouldMapTo(nameof(LogoURL))) entity.LogoURL = LogoURL;

            return entity;
        }
    }
}
