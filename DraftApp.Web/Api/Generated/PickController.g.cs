
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
    [Route("api/Pick")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class PickController
        : BaseApiController<DraftApp.Data.Models.Pick, PickDtoGen, DraftApp.Data.AppDbContext>
    {
        public PickController(CrudContext<DraftApp.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<DraftApp.Data.Models.Pick>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<PickDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<DraftApp.Data.Models.Pick> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<PickDtoGen>> List(
            ListParameters parameters,
            IDataSource<DraftApp.Data.Models.Pick> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<DraftApp.Data.Models.Pick> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<PickDtoGen>> Save(
            [FromForm] PickDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<DraftApp.Data.Models.Pick> dataSource,
            IBehaviors<DraftApp.Data.Models.Pick> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<PickDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<PickDtoGen>> Delete(
            int id,
            IBehaviors<DraftApp.Data.Models.Pick> behaviors,
            IDataSource<DraftApp.Data.Models.Pick> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
