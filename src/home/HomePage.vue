<template>
  <div class="home">
    <div>
      <img
        class="character"
        src="@/assets/yoda.png"
        alt="yoda"
        aria-hidden="true"
      />
    </div>
    <div class="get-started">
      <router-link to="/build">Get started</router-link> building your card!
    </div>
  </div>
</template>

<script lang="ts">
import { Component, Prop, Vue } from "vue-property-decorator";

@Component
export default class HomePage extends Vue {
  @Prop() private msg!: string;
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.home {
  text-align: center;
}

.character {
  height: 300px;
}
</style>
