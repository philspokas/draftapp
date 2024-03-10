using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace DraftApp.Web.Models
{
    public partial class PlayerDtoGen : GeneratedDto<DraftApp.Data.Models.Player>
    {
        public PlayerDtoGen() { }

        private int? _PlayerId;
        private string _Name;
        private string _Email;
        private string _Mobile;
        private int? _Sequence;

        public int? PlayerId
        {
            get => _PlayerId;
            set { _PlayerId = value; Changed(nameof(PlayerId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }
        public string Email
        {
            get => _Email;
            set { _Email = value; Changed(nameof(Email)); }
        }
        public string Mobile
        {
            get => _Mobile;
            set { _Mobile = value; Changed(nameof(Mobile)); }
        }
        public int? Sequence
        {
            get => _Sequence;
            set { _Sequence = value; Changed(nameof(Sequence)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(DraftApp.Data.Models.Player obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.PlayerId = obj.PlayerId;
            this.Name = obj.Name;
            this.Email = obj.Email;
            this.Mobile = obj.Mobile;
            this.Sequence = obj.Sequence;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(DraftApp.Data.Models.Player entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(PlayerId))) entity.PlayerId = (PlayerId ?? entity.PlayerId);
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(Email))) entity.Email = Email;
            if (ShouldMapTo(nameof(Mobile))) entity.Mobile = Mobile;
            if (ShouldMapTo(nameof(Sequence))) entity.Sequence = (Sequence ?? entity.Sequence);
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override DraftApp.Data.Models.Player MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new DraftApp.Data.Models.Player()
            {
                Name = Name,
                Email = Email,
                Mobile = Mobile,
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(PlayerId))) entity.PlayerId = (PlayerId ?? entity.PlayerId);
            if (ShouldMapTo(nameof(Sequence))) entity.Sequence = (Sequence ?? entity.Sequence);

            return entity;
        }
    }
}
