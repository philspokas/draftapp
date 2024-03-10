<template>
  <dl>
    <dt>Name</dt>
    <dd>
      <c-display :model="team" for="name" />
    </dd>

    <dt>Abbreviation</dt>
    <dd>
      <c-display :model="team" for="abbreviation" />
    </dd>

    <dt>Mascot</dt>
    <dd>
      <c-display :model="team" for="mascot" />
    </dd>

    <dt>Logo URL</dt>
    <dd>
      <c-display :model="team" for="logourl" />
    </dd>

  </dl>
</template>

<script setup lang="ts"> 
import { TeamViewModel } from "@/viewmodels.g";

const props = defineProps<{ id: number }>();
const team = new TeamViewModel();

team.$load(props.id);
</script>