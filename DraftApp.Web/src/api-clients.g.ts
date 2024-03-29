import * as $metadata from './metadata.g'
import * as $models from './models.g'
import { AxiosClient, ModelApiClient, ServiceApiClient, ItemResult, ListResult } from 'coalesce-vue/lib/api-client'
import { AxiosPromise, AxiosResponse, AxiosRequestConfig } from 'axios'

export class PickApiClient extends ModelApiClient<$models.Pick> {
  constructor() { super($metadata.Pick) }
}


export class PickTrackerApiClient extends ModelApiClient<$models.PickTracker> {
  constructor() { super($metadata.PickTracker) }
  public startDraft(id: number, $config?: AxiosRequestConfig): AxiosPromise<ItemResult<$models.PickTracker>> {
    const $method = this.$metadata.methods.startDraft
    const $params =  {
      id,
    }
    return this.$invoke($method, $params, $config)
  }
  
  public nextPlayer(id: number, $config?: AxiosRequestConfig): AxiosPromise<ItemResult<$models.PickTracker>> {
    const $method = this.$metadata.methods.nextPlayer
    const $params =  {
      id,
    }
    return this.$invoke($method, $params, $config)
  }
  
}


export class PlayerApiClient extends ModelApiClient<$models.Player> {
  constructor() { super($metadata.Player) }
}


export class TeamApiClient extends ModelApiClient<$models.Team> {
  constructor() { super($metadata.Team) }
}


export class TourneyTeamApiClient extends ModelApiClient<$models.TourneyTeam> {
  constructor() { super($metadata.TourneyTeam) }
}


export class WidgetApiClient extends ModelApiClient<$models.Widget> {
  constructor() { super($metadata.Widget) }
}


