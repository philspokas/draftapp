import {
  Domain, getEnumMeta, solidify, ModelType, ObjectType,
  PrimitiveProperty, ForeignKeyProperty, PrimaryKeyProperty,
  ModelCollectionNavigationProperty, ModelReferenceNavigationProperty,
  HiddenAreas, BehaviorFlags
} from 'coalesce-vue/lib/metadata'


const domain: Domain = { enums: {}, types: {}, services: {} }
export const WidgetCategory = domain.enums.WidgetCategory = {
  name: "WidgetCategory",
  displayName: "Widget Category",
  type: "enum",
  ...getEnumMeta<"Whizbangs"|"Sprecklesprockets"|"Discombobulators">([
  {
    value: 0,
    strValue: "Whizbangs",
    displayName: "Whizbangs",
  },
  {
    value: 1,
    strValue: "Sprecklesprockets",
    displayName: "Sprecklesprockets",
  },
  {
    value: 2,
    strValue: "Discombobulators",
    displayName: "Discombobulators",
  },
  ]),
}
export const Pick = domain.types.Pick = {
  name: "Pick",
  displayName: "Pick",
  get displayProp() { return this.props.pickId }, 
  type: "model",
  controllerRoute: "Pick",
  get keyProp() { return this.props.pickId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    pickId: {
      name: "pickId",
      displayName: "Pick Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    playerId: {
      name: "playerId",
      displayName: "Player Id",
      type: "number",
      role: "foreignKey",
      get principalKey() { return (domain.types.Player as ModelType).props.playerId as PrimaryKeyProperty },
      get principalType() { return (domain.types.Player as ModelType) },
      get navigationProp() { return (domain.types.Pick as ModelType).props.player as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => val != null || "Player is required.",
      }
    },
    player: {
      name: "player",
      displayName: "Player",
      type: "model",
      get typeDef() { return (domain.types.Player as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.Pick as ModelType).props.playerId as ForeignKeyProperty },
      get principalKey() { return (domain.types.Player as ModelType).props.playerId as PrimaryKeyProperty },
      dontSerialize: true,
    },
    tourneyTeamId: {
      name: "tourneyTeamId",
      displayName: "Tourney Team Id",
      type: "number",
      role: "foreignKey",
      get principalKey() { return (domain.types.TourneyTeam as ModelType).props.tourneyTeamID as PrimaryKeyProperty },
      get principalType() { return (domain.types.TourneyTeam as ModelType) },
      get navigationProp() { return (domain.types.Pick as ModelType).props.tourneyTeam as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => val != null || "Tourney Team is required.",
      }
    },
    tourneyTeam: {
      name: "tourneyTeam",
      displayName: "Tourney Team",
      type: "model",
      get typeDef() { return (domain.types.TourneyTeam as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.Pick as ModelType).props.tourneyTeamId as ForeignKeyProperty },
      get principalKey() { return (domain.types.TourneyTeam as ModelType).props.tourneyTeamID as PrimaryKeyProperty },
      dontSerialize: true,
    },
    pickNumber: {
      name: "pickNumber",
      displayName: "Pick Number",
      type: "number",
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const Player = domain.types.Player = {
  name: "Player",
  displayName: "Player",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "Player",
  get keyProp() { return this.props.playerId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    playerId: {
      name: "playerId",
      displayName: "Player Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Name is required.",
      }
    },
    email: {
      name: "email",
      displayName: "Email",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Email is required.",
      }
    },
    mobile: {
      name: "mobile",
      displayName: "Mobile",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Mobile is required.",
      }
    },
    sequence: {
      name: "sequence",
      displayName: "Sequence",
      type: "number",
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const Team = domain.types.Team = {
  name: "Team",
  displayName: "Team",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "Team",
  get keyProp() { return this.props.teamId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    teamId: {
      name: "teamId",
      displayName: "Team Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Name is required.",
      }
    },
    abbreviation: {
      name: "abbreviation",
      displayName: "Abbreviation",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Abbreviation is required.",
      }
    },
    mascot: {
      name: "mascot",
      displayName: "Mascot",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Mascot is required.",
      }
    },
    logoURL: {
      name: "logoURL",
      displayName: "Logo URL",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Logo URL is required.",
      }
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const TourneyTeam = domain.types.TourneyTeam = {
  name: "TourneyTeam",
  displayName: "Tourney Team",
  get displayProp() { return this.props.tourneyTeamID }, 
  type: "model",
  controllerRoute: "TourneyTeam",
  get keyProp() { return this.props.tourneyTeamID }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    tourneyTeamID: {
      name: "tourneyTeamID",
      displayName: "Tourney Team ID",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    teamID: {
      name: "teamID",
      displayName: "Team ID",
      type: "number",
      role: "value",
    },
    team: {
      name: "team",
      displayName: "Team",
      type: "model",
      get typeDef() { return (domain.types.Team as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.TourneyTeam as ModelType).props.teamID as ForeignKeyProperty },
      get principalKey() { return (domain.types.Team as ModelType).props.teamId as PrimaryKeyProperty },
      dontSerialize: true,
    },
    seed: {
      name: "seed",
      displayName: "Seed",
      type: "number",
      role: "value",
    },
    region: {
      name: "region",
      displayName: "Region",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Region is required.",
      }
    },
    bracketPosition: {
      name: "bracketPosition",
      displayName: "Bracket Position",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Bracket Position is required.",
      }
    },
    bracketId: {
      name: "bracketId",
      displayName: "Bracket Id",
      type: "number",
      role: "value",
    },
    playerID: {
      name: "playerID",
      displayName: "Player ID",
      type: "number",
      role: "value",
    },
    player: {
      name: "player",
      displayName: "Player",
      type: "model",
      get typeDef() { return (domain.types.Player as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.TourneyTeam as ModelType).props.playerID as ForeignKeyProperty },
      get principalKey() { return (domain.types.Player as ModelType).props.playerId as PrimaryKeyProperty },
      dontSerialize: true,
    },
    pickSequence: {
      name: "pickSequence",
      displayName: "Pick Sequence",
      type: "number",
      role: "value",
    },
    isPlayin: {
      name: "isPlayin",
      displayName: "Is Playin",
      type: "boolean",
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const Widget = domain.types.Widget = {
  name: "Widget",
  displayName: "Widget",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "Widget",
  get keyProp() { return this.props.widgetId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    widgetId: {
      name: "widgetId",
      displayName: "Widget Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Name is required.",
      }
    },
    category: {
      name: "category",
      displayName: "Category",
      type: "enum",
      get typeDef() { return domain.enums.WidgetCategory },
      role: "value",
      rules: {
        required: val => val != null || "Category is required.",
      }
    },
    inventedOn: {
      name: "inventedOn",
      displayName: "Invented On",
      type: "date",
      dateKind: "datetime",
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
}

interface AppDomain extends Domain {
  enums: {
    WidgetCategory: typeof WidgetCategory
  }
  types: {
    Pick: typeof Pick
    Player: typeof Player
    Team: typeof Team
    TourneyTeam: typeof TourneyTeam
    Widget: typeof Widget
  }
  services: {
  }
}

solidify(domain)

export default domain as unknown as AppDomain
