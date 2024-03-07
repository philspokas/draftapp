<template>
  <dl>
    <dt>Name</dt>
    <dd>
      <c-display :model="player" for="name" />
    </dd>

    <dt>email</dt>
    <dd>
      <c-display :model="player" for="email" />
    </dd>

    <dt>Mobile</dt>
    <dd>
      <c-display :model="player" for="mobile" />
    </dd>

  </dl>
</template>

<script setup lang="ts"> 
import { PlayerViewModel } from "@/viewmodels.g";

const props = defineProps<{ id: number }>();
const player = new PlayerViewModel();

player.$load(props.id);
</script>