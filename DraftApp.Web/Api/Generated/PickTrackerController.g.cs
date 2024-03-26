
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
    [Route("api/PickTracker")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class PickTrackerController
        : BaseApiController<DraftApp.Data.Models.PickTracker, PickTrackerDtoGen, DraftApp.Data.AppDbContext>
    {
        public PickTrackerController(CrudContext<DraftApp.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<DraftApp.Data.Models.PickTracker>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<PickTrackerDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<DraftApp.Data.Models.PickTracker> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<PickTrackerDtoGen>> List(
            ListParameters parameters,
            IDataSource<DraftApp.Data.Models.PickTracker> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<DraftApp.Data.Models.PickTracker> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<PickTrackerDtoGen>> Save(
            [FromForm] PickTrackerDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<DraftApp.Data.Models.PickTracker> dataSource,
            IBehaviors<DraftApp.Data.Models.PickTracker> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<PickTrackerDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<PickTrackerDtoGen>> Delete(
            int id,
            IBehaviors<DraftApp.Data.Models.PickTracker> behaviors,
            IDataSource<DraftApp.Data.Models.PickTracker> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);

        // Methods from data class exposed through API Controller.

        /// <summary>
        /// Method: StartDraft
        /// </summary>
        [HttpPost("StartDraft")]
        [Authorize]
        public virtual async Task<ItemResult<PickTrackerDtoGen>> StartDraft(
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromForm(Name = "id")] int id)
        {
            var dataSource = dataSourceFactory.GetDataSource<DraftApp.Data.Models.PickTracker, DraftApp.Data.Models.PickTracker>("Default");
            var (itemResult, _) = await dataSource.GetItemAsync(id, new DataSourceParameters());
            if (!itemResult.WasSuccessful)
            {
                return new ItemResult<PickTrackerDtoGen>(itemResult);
            }
            var item = itemResult.Object;
            IncludeTree includeTree = null;
            var _mappingContext = new MappingContext(Context);
            var _methodResult = await item.StartDraft(
                Db
            );
            await Db.SaveChangesAsync();
            var _result = new ItemResult<PickTrackerDtoGen>();
            _result.Object = Mapper.MapToDto<DraftApp.Data.Models.PickTracker, PickTrackerDtoGen>(_methodResult, _mappingContext, includeTree);
            return _result;
        }

        /// <summary>
        /// Method: NextPlayer
        /// </summary>
        [HttpPost("NextPlayer")]
        [Authorize]
        public virtual async Task<ItemResult<PickTrackerDtoGen>> NextPlayer(
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromForm(Name = "id")] int id)
        {
            var dataSource = dataSourceFactory.GetDataSource<DraftApp.Data.Models.PickTracker, DraftApp.Data.Models.PickTracker>("Default");
            var (itemResult, _) = await dataSource.GetItemAsync(id, new DataSourceParameters());
            if (!itemResult.WasSuccessful)
            {
                return new ItemResult<PickTrackerDtoGen>(itemResult);
            }
            var item = itemResult.Object;
            IncludeTree includeTree = null;
            var _mappingContext = new MappingContext(Context);
            var _methodResult = await item.NextPlayer(
                Db
            );
            await Db.SaveChangesAsync();
            var _result = new ItemResult<PickTrackerDtoGen>();
            _result.Object = Mapper.MapToDto<DraftApp.Data.Models.PickTracker, PickTrackerDtoGen>(_methodResult, _mappingContext, includeTree);
            return _result;
        }
    }
}
