import * as $metadata from './metadata.g'
import * as $models from './models.g'
import * as $apiClients from './api-clients.g'
import { ViewModel, ListViewModel, ServiceViewModel, DeepPartial, defineProps } from 'coalesce-vue/lib/viewmodel'

export interface PlayerViewModel extends $models.Player {
  playerId: number | null;
  name: string | null;
  email: string | null;
  mobile: string | null;
}
export class PlayerViewModel extends ViewModel<$models.Player, $apiClients.PlayerApiClient, number> implements $models.Player  {
  
  constructor(initialData?: DeepPartial<$models.Player> | null) {
    super($metadata.Player, new $apiClients.PlayerApiClient(), initialData)
  }
}
defineProps(PlayerViewModel, $metadata.Player)

export class PlayerListViewModel extends ListViewModel<$models.Player, $apiClients.PlayerApiClient, PlayerViewModel> {
  
  constructor() {
    super($metadata.Player, new $apiClients.PlayerApiClient())
  }
}


export interface WidgetViewModel extends $models.Widget {
  widgetId: number | null;
  name: string | null;
  category: $models.WidgetCategory | null;
  inventedOn: Date | null;
}
export class WidgetViewModel extends ViewModel<$models.Widget, $apiClients.WidgetApiClient, number> implements $models.Widget  {
  
  constructor(initialData?: DeepPartial<$models.Widget> | null) {
    super($metadata.Widget, new $apiClients.WidgetApiClient(), initialData)
  }
}
defineProps(WidgetViewModel, $metadata.Widget)

export class WidgetListViewModel extends ListViewModel<$models.Widget, $apiClients.WidgetApiClient, WidgetViewModel> {
  
  constructor() {
    super($metadata.Widget, new $apiClients.WidgetApiClient())
  }
}


const viewModelTypeLookup = ViewModel.typeLookup = {
  Player: PlayerViewModel,
  Widget: WidgetViewModel,
}
const listViewModelTypeLookup = ListViewModel.typeLookup = {
  Player: PlayerListViewModel,
  Widget: WidgetListViewModel,
}
const serviceViewModelTypeLookup = ServiceViewModel.typeLookup = {
}

