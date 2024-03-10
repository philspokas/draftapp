
using DraftApp.Web.Models;
using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Api;
using IntelliTect.Coalesce.Api.Behaviors;
using IntelliTect.Coalesce.Api.Controllers;
using IntelliTect.Coalesce.Api.DataSources;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Mapping.IncludeTrees;
using IntelliTect.Coalesce.Models;
using IntelliTect.Coalesce.TypeDefinition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DraftApp.Web.Api
{
    [Route("api/TourneyTeam")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class TourneyTeamController
        : BaseApiController<DraftApp.Data.Models.TourneyTeam, TourneyTeamDtoGen, DraftApp.Data.AppDbContext>
    {
        public TourneyTeamController(CrudContext<DraftApp.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<DraftApp.Data.Models.TourneyTeam>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<TourneyTeamDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<DraftApp.Data.Models.TourneyTeam> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<TourneyTeamDtoGen>> List(
            ListParameters parameters,
            IDataSource<DraftApp.Data.Models.TourneyTeam> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<DraftApp.Data.Models.TourneyTeam> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<TourneyTeamDtoGen>> Save(
            [FromForm] TourneyTeamDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<DraftApp.Data.Models.TourneyTeam> dataSource,
            IBehaviors<DraftApp.Data.Models.TourneyTeam> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<TourneyTeamDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<TourneyTeamDtoGen>> Delete(
            int id,
            IBehaviors<DraftApp.Data.Models.TourneyTeam> behaviors,
            IDataSource<DraftApp.Data.Models.TourneyTeam> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
