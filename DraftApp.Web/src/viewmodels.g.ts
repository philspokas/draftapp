import * as $metadata from './metadata.g'
import * as $models from './models.g'
import * as $apiClients from './api-clients.g'
import { ViewModel, ListViewModel, ServiceViewModel, DeepPartial, defineProps } from 'coalesce-vue/lib/viewmodel'

export interface PickViewModel extends $models.Pick {
  pickId: number | null;
  playerId: number | null;
  player: PlayerViewModel | null;
  tourneyTeamId: number | null;
  tourneyTeam: TourneyTeamViewModel | null;
  pickNumber: number | null;
}
export class PickViewModel extends ViewModel<$models.Pick, $apiClients.PickApiClient, number> implements $models.Pick  {
  
  constructor(initialData?: DeepPartial<$models.Pick> | null) {
    super($metadata.Pick, new $apiClients.PickApiClient(), initialData)
  }
}
defineProps(PickViewModel, $metadata.Pick)

export class PickListViewModel extends ListViewModel<$models.Pick, $apiClients.PickApiClient, PickViewModel> {
  
  constructor() {
    super($metadata.Pick, new $apiClients.PickApiClient())
  }
}


export interface PickTrackerViewModel extends $models.PickTracker {
  pickTrackerID: number | null;
  currentPick: number | null;
  repeatPlayer: boolean | null;
  playerIndex: number | null;
  direction: number | null;
}
export class PickTrackerViewModel extends ViewModel<$models.PickTracker, $apiClients.PickTrackerApiClient, number> implements $models.PickTracker  {
  
  public get startDraft() {
    const startDraft = this.$apiClient.$makeCaller(
      this.$metadata.methods.startDraft,
      (c) => c.startDraft(this.$primaryKey),
      () => ({}),
      (c, args) => c.startDraft(this.$primaryKey))
    
    Object.defineProperty(this, 'startDraft', {value: startDraft});
    return startDraft
  }
  
  public get nextPlayer() {
    const nextPlayer = this.$apiClient.$makeCaller(
      this.$metadata.methods.nextPlayer,
      (c) => c.nextPlayer(this.$primaryKey),
      () => ({}),
      (c, args) => c.nextPlayer(this.$primaryKey))
    
    Object.defineProperty(this, 'nextPlayer', {value: nextPlayer});
    return nextPlayer
  }
  
  constructor(initialData?: DeepPartial<$models.PickTracker> | null) {
    super($metadata.PickTracker, new $apiClients.PickTrackerApiClient(), initialData)
  }
}
defineProps(PickTrackerViewModel, $metadata.PickTracker)

export class PickTrackerListViewModel extends ListViewModel<$models.PickTracker, $apiClients.PickTrackerApiClient, PickTrackerViewModel> {
  
  constructor() {
    super($metadata.PickTracker, new $apiClients.PickTrackerApiClient())
  }
}


export interface PlayerViewModel extends $models.Player {
  playerId: number | null;
  name: string | null;
  email: string | null;
  mobile: string | null;
  sequence: number | null;
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


export interface TeamViewModel extends $models.Team {
  teamId: number | null;
  name: string | null;
  abbreviation: string | null;
  mascot: string | null;
  logoURL: string | null;
}
export class TeamViewModel extends ViewModel<$models.Team, $apiClients.TeamApiClient, number> implements $models.Team  {
  
  constructor(initialData?: DeepPartial<$models.Team> | null) {
    super($metadata.Team, new $apiClients.TeamApiClient(), initialData)
  }
}
defineProps(TeamViewModel, $metadata.Team)

export class TeamListViewModel extends ListViewModel<$models.Team, $apiClients.TeamApiClient, TeamViewModel> {
  
  constructor() {
    super($metadata.Team, new $apiClients.TeamApiClient())
  }
}


export interface TourneyTeamViewModel extends $models.TourneyTeam {
  tourneyTeamID: number | null;
  teamID: number | null;
  team: TeamViewModel | null;
  seed: number | null;
  region: string | null;
  bracketPosition: string | null;
  bracketId: number | null;
  playerID: number | null;
  player: PlayerViewModel | null;
  pickSequence: number | null;
  isPlayin: boolean | null;
}
export class TourneyTeamViewModel extends ViewModel<$models.TourneyTeam, $apiClients.TourneyTeamApiClient, number> implements $models.TourneyTeam  {
  
  constructor(initialData?: DeepPartial<$models.TourneyTeam> | null) {
    super($metadata.TourneyTeam, new $apiClients.TourneyTeamApiClient(), initialData)
  }
}
defineProps(TourneyTeamViewModel, $metadata.TourneyTeam)

export class TourneyTeamListViewModel extends ListViewModel<$models.TourneyTeam, $apiClients.TourneyTeamApiClient, TourneyTeamViewModel> {
  
  constructor() {
    super($metadata.TourneyTeam, new $apiClients.TourneyTeamApiClient())
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
  Pick: PickViewModel,
  PickTracker: PickTrackerViewModel,
  Player: PlayerViewModel,
  Team: TeamViewModel,
  TourneyTeam: TourneyTeamViewModel,
  Widget: WidgetViewModel,
}
const listViewModelTypeLookup = ListViewModel.typeLookup = {
  Pick: PickListViewModel,
  PickTracker: PickTrackerListViewModel,
  Player: PlayerListViewModel,
  Team: TeamListViewModel,
  TourneyTeam: TourneyTeamListViewModel,
  Widget: WidgetListViewModel,
}
const serviceViewModelTypeLookup = ServiceViewModel.typeLookup = {
}

