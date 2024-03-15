import * as metadata from './metadata.g'
import { Model, DataSource, convertToModel, mapToModel } from 'coalesce-vue/lib/model'

export enum WidgetCategory {
  Whizbangs = 0,
  Sprecklesprockets = 1,
  Discombobulators = 2,
}


export interface Pick extends Model<typeof metadata.Pick> {
  pickId: number | null
  playerId: number | null
  player: Player | null
  tourneyTeamId: number | null
  tourneyTeam: TourneyTeam | null
  pickNumber: number | null
}
export class Pick {
  
  /** Mutates the input object and its descendents into a valid Pick implementation. */
  static convert(data?: Partial<Pick>): Pick {
    return convertToModel(data || {}, metadata.Pick) 
  }
  
  /** Maps the input object and its descendents to a new, valid Pick implementation. */
  static map(data?: Partial<Pick>): Pick {
    return mapToModel(data || {}, metadata.Pick) 
  }
  
  /** Instantiate a new Pick, optionally basing it on the given data. */
  constructor(data?: Partial<Pick> | {[k: string]: any}) {
    Object.assign(this, Pick.map(data || {}));
  }
}


export interface Player extends Model<typeof metadata.Player> {
  playerId: number | null
  name: string | null
  email: string | null
  mobile: string | null
  sequence: number | null
}
export class Player {
  
  /** Mutates the input object and its descendents into a valid Player implementation. */
  static convert(data?: Partial<Player>): Player {
    return convertToModel(data || {}, metadata.Player) 
  }
  
  /** Maps the input object and its descendents to a new, valid Player implementation. */
  static map(data?: Partial<Player>): Player {
    return mapToModel(data || {}, metadata.Player) 
  }
  
  /** Instantiate a new Player, optionally basing it on the given data. */
  constructor(data?: Partial<Player> | {[k: string]: any}) {
    Object.assign(this, Player.map(data || {}));
  }
}


export interface Team extends Model<typeof metadata.Team> {
  teamId: number | null
  name: string | null
  abbreviation: string | null
  mascot: string | null
  logoURL: string | null
}
export class Team {
  
  /** Mutates the input object and its descendents into a valid Team implementation. */
  static convert(data?: Partial<Team>): Team {
    return convertToModel(data || {}, metadata.Team) 
  }
  
  /** Maps the input object and its descendents to a new, valid Team implementation. */
  static map(data?: Partial<Team>): Team {
    return mapToModel(data || {}, metadata.Team) 
  }
  
  /** Instantiate a new Team, optionally basing it on the given data. */
  constructor(data?: Partial<Team> | {[k: string]: any}) {
    Object.assign(this, Team.map(data || {}));
  }
}


export interface TourneyTeam extends Model<typeof metadata.TourneyTeam> {
  tourneyTeamID: number | null
  teamID: number | null
  team: Team | null
  seed: number | null
  region: string | null
  bracketPosition: string | null
  bracketId: number | null
  playerID: number | null
  player: Player | null
  pickSequence: number | null
  isPlayin: boolean | null
}
export class TourneyTeam {
  
  /** Mutates the input object and its descendents into a valid TourneyTeam implementation. */
  static convert(data?: Partial<TourneyTeam>): TourneyTeam {
    return convertToModel(data || {}, metadata.TourneyTeam) 
  }
  
  /** Maps the input object and its descendents to a new, valid TourneyTeam implementation. */
  static map(data?: Partial<TourneyTeam>): TourneyTeam {
    return mapToModel(data || {}, metadata.TourneyTeam) 
  }
  
  /** Instantiate a new TourneyTeam, optionally basing it on the given data. */
  constructor(data?: Partial<TourneyTeam> | {[k: string]: any}) {
    Object.assign(this, TourneyTeam.map(data || {}));
  }
}


export interface Widget extends Model<typeof metadata.Widget> {
  widgetId: number | null
  name: string | null
  category: WidgetCategory | null
  inventedOn: Date | null
}
export class Widget {
  
  /** Mutates the input object and its descendents into a valid Widget implementation. */
  static convert(data?: Partial<Widget>): Widget {
    return convertToModel(data || {}, metadata.Widget) 
  }
  
  /** Maps the input object and its descendents to a new, valid Widget implementation. */
  static map(data?: Partial<Widget>): Widget {
    return mapToModel(data || {}, metadata.Widget) 
  }
  
  /** Instantiate a new Widget, optionally basing it on the given data. */
  constructor(data?: Partial<Widget> | {[k: string]: any}) {
    Object.assign(this, Widget.map(data || {}));
  }
}


