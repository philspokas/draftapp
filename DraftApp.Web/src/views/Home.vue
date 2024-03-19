<template>
  <div class="home">
    <!-- <HelloWorld msg="Welcome to your new Vue.js Coalesce application!" /> -->
      <v-card><v-card-title>{{ pageTitle }}</v-card-title></v-card>
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
          >
            <v-list-item-title>{{ team.team?.name }}</v-list-item-title>
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
import { PlayerListViewModel, TourneyTeamListViewModel } from "@/viewmodels.g";
import { watch } from "vue";

var pageTitle = "Pick Teams - " // + currentPlayer().name;
const props = defineProps({ galleryVersion: Number });

const playerList = new PlayerListViewModel();
playerList.$pageSize = 100;
playerList.$load();
playerList.$useAutoLoad({ wait: 0 });

const tourneyTeamList = new TourneyTeamListViewModel();
tourneyTeamList.$pageSize = 100;
tourneyTeamList.$load();
tourneyTeamList.$useAutoLoad({ wait: 0 });

function tourneyTeamClick(team: TourneyTeam) {
  console.log(currentPlayer().name + ' selected ' + team.team?.name)
  team.player = currentPlayer()
  pageTitle = "clicked " + team.team?.name;
  return "clicked "+team.team?.name
}

function currentPlayer() {
  return playerList.$items[1];
}

function nextPlayer() {
  return "Ray"
}

watch(
  () => props.galleryVersion,
  () => playerList.$load(),
  () => tourneyTeamList.$load()
);

</script>
