<template>
  <div class="home">
    <v-card>
      <v-card-title>{{ pageTitle }}</v-card-title>
    </v-card>
    <v-btn @click=startDraft()>Start</v-btn>
    <v-text-field>"{{ 'tracker: '+trackerVM.playerIndex+','+trackerVM.direction }}"</v-text-field>
    <v-card 
      class="mx-auto" 
      max-width="300"
    >
      <v-list density="compact">
        <v-list-subheader>TOURNEY TEAMS</v-list-subheader>
        <v-list-item
          v-for="team in tourneyTeamList.$items"
          :key="team.$stableId"
          @click="tourneyTeamClick(team)"
          :disabled="isPicked(team)"
        >
          <v-list-item-title>{{ displayTeam(team) }}</v-list-item-title>
          <v-list-item-subtitle>{{ 'Seed: ' + team.seed + ', ' + team.region + ' (' + team.bracketPosition + ')' }}</v-list-item-subtitle>
        </v-list-item>
      </v-list>
    </v-card>

    <v-list density="compact">
      <v-list-subheader>PLAYERS</v-list-subheader>
      <v-list-item
        v-for="player in playerList.$items"
        :key="player.$stableId"
        :title="player.name + ' (' + player.sequence + ')'"
      ></v-list-item>
    </v-list>

  </div>
</template>

<script setup lang="ts">
useTitle("Home");
import { TourneyTeam } from "@/models.g";
import {
  PlayerViewModel,
  PlayerListViewModel,
  TourneyTeamViewModel,
  TourneyTeamListViewModel,
  PickTrackerViewModel
} from "@/viewmodels.g";
import { ref, watch } from "vue";

const playerList = new PlayerListViewModel();
playerList.$pageSize = 100;
playerList.$load();

const tourneyTeamList = new TourneyTeamListViewModel();
tourneyTeamList.$pageSize = 100;
tourneyTeamList.$load();

const trackerVM = new PickTrackerViewModel();
trackerVM.$load(1); 

const pageTitle = ref("Picking Teams"); 
// setTitle();

function startDraft() {
  trackerVM.startDraft();
  trackerVM.$load(1);
  setTitle();
}

function tourneyTeamClick(team: TourneyTeamViewModel) {
  console.log(currentPlayer().name + ' selected ' + team.team?.name)
  team.$save({ playerID: currentPlayer().playerId });
  nextPlayer();
  setTitle();
  return team.team?.name
}

function displayTeam(team: TourneyTeam) {
  if (team.player) {
    return team.team?.name + ' - ' + team.player.name;
  }
  else {
    return team.team?.name;
  }
}

function isPicked(team: TourneyTeam): boolean {
  return team.playerID != null
}

function currentPlayer(): PlayerViewModel {
  console.log('current player index: '+trackerVM.playerIndex)
  return playerList.$items[trackerVM.playerIndex-1];
}

function nextPlayer() {
  trackerVM.nextPlayer();
  console.log('nextPlayer player index: ' + trackerVM.playerIndex);
  trackerVM.$load(1);
  console.log('load player index: ' + trackerVM.playerIndex);
}

function setTitle() {
  pageTitle.value = 'Now picking: ' + currentPlayer().name
}

// watch(
//   () => props.galleryVersion,
//   () => playerList.$load()
// );

</script>
